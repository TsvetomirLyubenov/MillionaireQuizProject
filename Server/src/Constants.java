public class Constants {

    public static final String EXCEPTIONS_PATH_NAME = "resources/logs/exceptions.txt";

    private static final String DB_NAME = "millionaire.db";

    public static final String CONNECTION_STRING = "jdbc:sqlite:" + DB_NAME;

    public static final String REGISTER_COMMAND = "register";
    public static final String LOGIN_COMMAND = "login";
    public static final String RESET_COMMAND = "reset-password";
    public static final String CREATE_TEMPORARY_PASSWORD_COMMAND = "create-temporary-password";
    public static final String LOGOUT_COMMAND = "logout";
    public static final String GET_QUESTION_COMMAND = "get-question";
    public static final String UPDATE_SCORE_COMMAND = "update-score";
    public static final String GET_RANKINGS_COMMAND = "get-rankings";
    public static final String GET_USER_SCORE_BY_NAME_COMMAND = "get-user-score";
    public static final String END_GAME_COMMAND = "end-game";

    public static final String USER_NAME = "--username";
    public static final String EMAIL = "--email";
    public static final String PASSWORD = "--password";
    public static final String CONFIRMED_PASSWORD = "--confirmed-password";
    public static final String OLD_PASSWORD = "--old-password";
    public static final String NEW_PASSWORD = "--new-password";
    public static final String DIFFICULTY = "--difficulty";
    public static final String SCORE = "--score";
    public static final String TEMPORARY_PASSWORD = "--temporary-password";

    private static final String TABLE_USERS = "users";
    public static final String COLUMN_USER_ID = "user_id";
    public static final String COLUMN_USER_NAME = "username";
    public static final String COLUMN_USER_EMAIL = "email";
    public static final String COLUMN_USER_PASSWORD = "password";

    private static final String TABLE_SCORES = "scores";
    public static final String COLUMN_SCORE = "score";

    private static final String TABLE_QUESTIONS = "questions";
    private static final String COLUMN_QUESTION_ID = "question_id";
    public static final String COLUMN_QUESTION = "question";
    public static final String COLUMN_ANSWER_A = "answer_a";
    public static final String COLUMN_ANSWER_B = "answer_b";
    public static final String COLUMN_ANSWER_C = "answer_c";
    public static final String COLUMN_ANSWER_D = "answer_d";

    private static final String TABLE_CATEGORIES = "categories";
    private static final String COLUMN_CATEGORY = "category";

    public static final String QUERY_USERS_BY_SCORE =
            "SELECT " + COLUMN_USER_NAME + ", "  + COLUMN_USER_EMAIL + ", " + COLUMN_SCORE +
                    " FROM " + TABLE_USERS +
                    " INNER JOIN " + TABLE_SCORES + " ON " + TABLE_USERS + "." + COLUMN_USER_ID +
                    " = " + TABLE_SCORES + "." + COLUMN_USER_ID +
                    " ORDER BY " + COLUMN_SCORE + " DESC";

    public static final String QUERY_USER_ID_BY_NAME =
            "SELECT " + TABLE_USERS + '.' + COLUMN_USER_ID +
                    " FROM " + TABLE_USERS +
                    " WHERE " + COLUMN_USER_NAME + " = ?";

    public static final String QUERY_USER_ID_BY_EMAIL =
            "SELECT " + TABLE_USERS + '.' + COLUMN_USER_ID +
                    " FROM " + TABLE_USERS +
                    " WHERE " + COLUMN_USER_EMAIL + " = ?";

    public static final String QUERY_USER_BY_NAME =
            "SELECT * " +
                    " FROM " + TABLE_USERS +
                    " WHERE " + COLUMN_USER_NAME + " = ?";

    public static final String QUERY_USER_BY_EMAIL =
            "SELECT * " +
                    " FROM " + TABLE_USERS +
                    " WHERE " + COLUMN_USER_EMAIL + " = ?";

    public static final String QUERY_USER_SCORE_BY_NAME =
            "SELECT " + COLUMN_USER_NAME + ", "  + COLUMN_USER_EMAIL + ", " + COLUMN_SCORE +
                    " FROM " + TABLE_USERS + " JOIN " + TABLE_SCORES + " ON " + TABLE_USERS + "." + COLUMN_USER_ID  +
                    " = " + TABLE_SCORES + "." + COLUMN_USER_ID +
                    " WHERE " + COLUMN_USER_NAME + " = ?";

    public static final String QUERY_EASY_QUESTIONS =
            "SELECT " + TABLE_QUESTIONS + '.' + COLUMN_QUESTION + ", " + TABLE_QUESTIONS + "." + COLUMN_ANSWER_A  + ", " + TABLE_QUESTIONS + "."
                    + COLUMN_ANSWER_B  + ", " + TABLE_QUESTIONS + "." + COLUMN_ANSWER_C + ", " + TABLE_QUESTIONS + "." + COLUMN_ANSWER_D +
                    " FROM " + TABLE_QUESTIONS +
                    " INNER JOIN " + TABLE_CATEGORIES + " ON " + TABLE_QUESTIONS + "." + COLUMN_QUESTION_ID +
                    " = " + TABLE_CATEGORIES + "." + COLUMN_QUESTION_ID +
                    " WHERE " + COLUMN_CATEGORY + " = " + " 'Лесен'";

    public static final String QUERY_MEDIUM_QUESTIONS =
            "SELECT " + TABLE_QUESTIONS + '.' + COLUMN_QUESTION + ", " + TABLE_QUESTIONS + "." + COLUMN_ANSWER_A  + ", " + TABLE_QUESTIONS + "."
                    + COLUMN_ANSWER_B  + ", " + TABLE_QUESTIONS + "." + COLUMN_ANSWER_C + ", " + TABLE_QUESTIONS + "." + COLUMN_ANSWER_D +
                    " FROM " + TABLE_QUESTIONS +
                    " INNER JOIN " + TABLE_CATEGORIES + " ON " + TABLE_QUESTIONS + "." + COLUMN_QUESTION_ID +
                    " = " + TABLE_CATEGORIES + "." + COLUMN_QUESTION_ID +
                    " WHERE " + COLUMN_CATEGORY + "=" + " 'Среден'";

    public static final String QUERY_HARD_QUESTIONS =
            "SELECT " + TABLE_QUESTIONS + '.' + COLUMN_QUESTION + ", " + TABLE_QUESTIONS + "." + COLUMN_ANSWER_A  + ", " + TABLE_QUESTIONS + "."
                    + COLUMN_ANSWER_B  + ", " + TABLE_QUESTIONS + "." + COLUMN_ANSWER_C + ", " + TABLE_QUESTIONS + "." + COLUMN_ANSWER_D +
                    " FROM " + TABLE_QUESTIONS +
                    " INNER JOIN " + TABLE_CATEGORIES + " ON " + TABLE_QUESTIONS + "." + COLUMN_QUESTION_ID +
                    " = " + TABLE_CATEGORIES + "." + COLUMN_QUESTION_ID +
                    " WHERE " + COLUMN_CATEGORY + "=" + " 'Сложен'";

    public static final String INSERT_USER = "INSERT INTO " + TABLE_USERS +
            '(' + COLUMN_USER_NAME + ", " + COLUMN_USER_EMAIL + ", " + COLUMN_USER_PASSWORD + ") VALUES(?, ?, ?)";

    public static final String INSERT_SCORE = "INSERT INTO " + TABLE_SCORES +
            '(' + COLUMN_USER_ID + ", " + COLUMN_SCORE + ") VALUES(?, ?)";

    public static final String UPDATE_SCORE = "UPDATE " + TABLE_SCORES +
            " SET " + COLUMN_SCORE + " = ? WHERE " + COLUMN_USER_ID + " = ?";

    public static final String UPDATE_USER = "UPDATE " + TABLE_USERS +
            " SET " + COLUMN_USER_PASSWORD + " = ? WHERE " + COLUMN_USER_NAME + " = ?";
}
