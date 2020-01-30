import java.sql.*;
import java.util.*;

public class DataSource implements AutoCloseable {

    private Connection conn;

    private PreparedStatement insertUser;
    private PreparedStatement insertScore;
    private PreparedStatement updateScore;
    private PreparedStatement queryUserIDByName;
    private PreparedStatement queryUserIDByEmail;
    private PreparedStatement queryUserByName;
    private PreparedStatement queryUserByEmail;
    private PreparedStatement queryUserScore;
    private PreparedStatement updateUser;

    private boolean open() {

        try {

            conn = DriverManager.getConnection(Constants.CONNECTION_STRING);
            insertUser = conn.prepareStatement(Constants.INSERT_USER, Statement.RETURN_GENERATED_KEYS);
            insertScore = conn.prepareStatement(Constants.INSERT_SCORE, Statement.RETURN_GENERATED_KEYS);
            updateScore = conn.prepareStatement(Constants.UPDATE_SCORE, Statement.RETURN_GENERATED_KEYS);
            queryUserIDByName = conn.prepareStatement(Constants.QUERY_USER_ID_BY_NAME, Statement.RETURN_GENERATED_KEYS);
            queryUserIDByEmail = conn.prepareStatement(Constants.QUERY_USER_ID_BY_EMAIL, Statement.RETURN_GENERATED_KEYS);
            queryUserByName = conn.prepareStatement(Constants.QUERY_USER_BY_NAME, Statement.RETURN_GENERATED_KEYS);
            queryUserByEmail = conn.prepareStatement(Constants.QUERY_USER_BY_EMAIL, Statement.RETURN_GENERATED_KEYS);
            updateUser = conn.prepareStatement(Constants.UPDATE_USER, Statement.RETURN_GENERATED_KEYS);
            queryUserScore = conn.prepareStatement(Constants.QUERY_USER_SCORE_BY_NAME, Statement.RETURN_GENERATED_KEYS);

            return true;

        } catch (Exception e) {

            ExceptionLogger.logException(e);
            return false;
        }
    }

    public DataSource() {

        if (!open()) {

            System.out.println("Can't open datasource.");
        }
    }

    public void close() {

        try {

            if (insertUser != null) {
                insertUser.close();
            }

            if (insertScore != null) {
                insertScore.close();
            }

            if (updateScore != null) {
                updateScore.close();
            }

            if (queryUserIDByName != null) {
                queryUserIDByName.close();
            }

            if (queryUserIDByEmail != null) {
                queryUserIDByEmail.close();
            }

            if (queryUserByName != null) {
                queryUserByName.close();
            }

            if (queryUserByEmail != null) {
                queryUserByEmail.close();
            }

            if (queryUserScore != null) {
                queryUserScore.close();
            }

            if (updateUser != null) {
                updateUser.close();
            }

            if (conn != null) {
                conn.close();
            }

        } catch (SQLException e) {

            ExceptionLogger.logException(e);
        }
    }

    public User queryUser(String typeOfQuery, String searchField) {

        try {

            ResultSet results;

            if (typeOfQuery.equals("name")) {

                queryUserByName.setString(1, searchField);
                results = queryUserByName.executeQuery();
            }

            else {

                queryUserByEmail.setString(1, searchField);
                results = queryUserByEmail.executeQuery();
            }

            results.next();

            return new User(results.getString(Constants.COLUMN_USER_NAME), results.getString(Constants.COLUMN_USER_EMAIL), results.getString(Constants.COLUMN_USER_PASSWORD));

        } catch (SQLException e) {

            ExceptionLogger.logException(e);
            return null;
        }
    }

    public UserScore queryUserScoreByName(String userName) {

        try {

            queryUserScore.setString(1, userName);
            ResultSet results = queryUserScore.executeQuery();

            results.next();

            return new UserScore(results.getString(Constants.COLUMN_USER_NAME), results.getString(Constants.COLUMN_USER_EMAIL), results.getInt(Constants.COLUMN_SCORE));

        } catch (SQLException e) {

            ExceptionLogger.logException(e);
            return null;
        }
    }

    public List<UserScore> queryUsersByScore() {

        try (Statement statement = conn.createStatement();
             ResultSet results = statement.executeQuery(Constants.QUERY_USERS_BY_SCORE)) {

            List<UserScore> userScores = new ArrayList<>();

            while (results.next()) {

                UserScore userScore = new UserScore(results.getString(Constants.COLUMN_USER_NAME), results.getString(Constants.COLUMN_USER_EMAIL), results.getInt(Constants.COLUMN_SCORE));
                userScores.add(userScore);
            }

            return userScores;

        } catch (SQLException e) {

            ExceptionLogger.logException(e);
            return null;
        }
    }

    public List<Question> queryQuestions(String difficulty) {

        String query;

        switch (difficulty) {

            case "easy" : query = Constants.QUERY_EASY_QUESTIONS;
                break;

            case "medium" : query = Constants.QUERY_MEDIUM_QUESTIONS;
                break;

            default : query = Constants.QUERY_HARD_QUESTIONS;
                break;
        }

        try (Statement statement = conn.createStatement();
             ResultSet results = statement.executeQuery(query)) {

            List<Question> questions = new ArrayList<>();

            while (results.next()) {

                List<String> answers = new ArrayList<>();
                Collections.addAll(answers, results.getString(Constants.COLUMN_ANSWER_A), results.getString(Constants.COLUMN_ANSWER_B), results.getString(Constants.COLUMN_ANSWER_C), results.getString(Constants.COLUMN_ANSWER_D));

                Question question = new Question(results.getString(Constants.COLUMN_QUESTION), answers);
                questions.add(question);
            }

            return questions;

        } catch (SQLException e) {

            ExceptionLogger.logException(e);
            return null;
        }
    }

    public int queryUserIDByName(String userName) {

        try {

            queryUserIDByName.setString(1, userName);
            ResultSet results = queryUserIDByName.executeQuery();

            results.next();

            return results.getInt(Constants.COLUMN_USER_ID);

        } catch (SQLException e) {

            ExceptionLogger.logException(e);
            return -1;
        }
    }

    public boolean doesUserExistByEmail(String email) {

        try {

            queryUserIDByEmail.setString(1, email);
            ResultSet results = queryUserIDByEmail.executeQuery();

            return results.next();


        } catch (SQLException e) {

            ExceptionLogger.logException(e);
            return false;
        }
    }

    public boolean doesUserExistByName(String userName) {

        try {

            queryUserIDByName.setString(1, userName);
            ResultSet results = queryUserIDByName.executeQuery();

            return results.next();

        } catch (SQLException e) {

            ExceptionLogger.logException(e);
            return false;
        }
    }

    public void insertUser(String userName, String email, String password) {

        try {

            conn.setAutoCommit(false);

            insertUser.setString(1, userName);
            insertUser.setString(2, email);
            insertUser.setString(3, password);

            insertUser.executeUpdate();

            queryUserIDByName.setString(1, userName);
            ResultSet results = queryUserIDByName.executeQuery();
            results.next();

            int userId = results.getInt(Constants.COLUMN_USER_ID);

            insertScore.setInt(1, userId);
            insertScore.setInt(2, 0);

            insertScore.executeUpdate();

            conn.commit();

        } catch(SQLException e1) {

            ExceptionLogger.logException(e1);

            try {

                System.out.println("Performing rollback");
                conn.rollback();

            } catch(SQLException e2) {

                ExceptionLogger.logException(e2);
            }

        } finally {

            try {

                System.out.println("Resetting default commit behavior");
                conn.setAutoCommit(true);

            } catch(SQLException e) {

                ExceptionLogger.logException(e);
            }
        }
    }

    public void updateScore(int userID, int score) {

        try {

            updateScore.setInt(1, score);
            updateScore.setInt(2, userID);

            updateScore.executeUpdate();

        } catch(SQLException e) {

            ExceptionLogger.logException(e);
        }
    }

    public void updateUser(String userName, String hashedPassword) {

        try {

            updateUser.setString(1, hashedPassword);
            updateUser.setString(2, userName);

            updateUser.executeUpdate();

        } catch(SQLException e) {

            ExceptionLogger.logException(e);
        }

    }
}















