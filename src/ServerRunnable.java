import com.google.gson.Gson;

import java.io.*;
import java.net.DatagramPacket;
import java.net.DatagramSocket;
import java.net.InetAddress;
import java.nio.charset.StandardCharsets;
import java.security.NoSuchAlgorithmException;
import java.util.*;

public class ServerRunnable implements Runnable {

    private DatagramPacket datagramPacket;
    private Server server;
    private DataSource dataSource;
    private Gson gson;

    public ServerRunnable(DatagramPacket datagramPacket, Server server, DataSource dataSource) {

        this.datagramPacket = datagramPacket;
        this.server = server;
        this.dataSource = dataSource;
        this.gson = new Gson();
    }

    @Override
    public void run() {

        try (DatagramSocket datagramSocket = new DatagramSocket()){
                
            String input = new String(datagramPacket.getData(), 0, datagramPacket.getLength());
            InetAddress clientAddress = datagramPacket.getAddress();
            int clientPort = datagramPacket.getPort();

            if (!input.equals("")) {

                String[] tokens = input.split(" ");

                String command = tokens[0];

                HashMap<String, String> parameters = Validator.getParameters(tokens);

                if (Validator.isRegisterValid(command, parameters)) {

                    String userName = parameters.get(Constants.USER_NAME);
                    String password = parameters.get(Constants.PASSWORD);
                    String confirmedPassword = parameters.get(Constants.CONFIRMED_PASSWORD);
                    String email = parameters.get(Constants.EMAIL);

                    String result = register(userName, email, password, confirmedPassword);

                    datagramPacket = new DatagramPacket(result.getBytes(StandardCharsets.UTF_8), result.getBytes(StandardCharsets.UTF_8).length, clientAddress, clientPort);
                    datagramSocket.send(datagramPacket);
                }

                else if (Validator.isLoginValid(command, parameters)) {

                    String userName = parameters.get(Constants.USER_NAME);
                    String password = parameters.get(Constants.PASSWORD);

                    String result = login(userName, password);

                    datagramPacket = new DatagramPacket(result.getBytes(StandardCharsets.UTF_8), result.getBytes(StandardCharsets.UTF_8).length, clientAddress, clientPort);
                    datagramSocket.send(datagramPacket);
                }

                else if (Validator.isResetValid(command, parameters)) {

                    String email = parameters.get(Constants.EMAIL);
                    String oldPassword = parameters.get(Constants.OLD_PASSWORD);
                    String newPassword = parameters.get(Constants.NEW_PASSWORD);

                    String result = resetPassword(email, oldPassword, newPassword);

                    datagramPacket = new DatagramPacket(result.getBytes(StandardCharsets.UTF_8), result.getBytes(StandardCharsets.UTF_8).length, clientAddress, clientPort);
                    datagramSocket.send(datagramPacket);
                }

                else if (Validator.isCreateTemporaryPasswordValid(command, parameters)) {

                    String email = parameters.get(Constants.EMAIL);
                    String temporaryPassword = parameters.get(Constants.TEMPORARY_PASSWORD);

                    String result = createTemporaryPassword(email, temporaryPassword);

                    datagramPacket = new DatagramPacket(result.getBytes(StandardCharsets.UTF_8), result.getBytes(StandardCharsets.UTF_8).length, clientAddress, clientPort);
                    datagramSocket.send(datagramPacket);
                }

                else if (Validator.isLogoutValid(command, parameters)) {

                    String userName = parameters.get(Constants.USER_NAME);

                    String result = logout(userName);

                    datagramPacket = new DatagramPacket(result.getBytes(StandardCharsets.UTF_8), result.getBytes(StandardCharsets.UTF_8).length, clientAddress, clientPort);
                    datagramSocket.send(datagramPacket);
                }

                else if (Validator.isGetQuestionValid(command, parameters)) {

                    String difficulty = parameters.get(Constants.DIFFICULTY);

                    String result = getQuestion(difficulty);

                    datagramPacket = new DatagramPacket(result.getBytes(StandardCharsets.UTF_8), result.getBytes(StandardCharsets.UTF_8).length, clientAddress, clientPort);
                    datagramSocket.send(datagramPacket);
                }

                else if (Validator.isUpdateScoreValid(command, parameters)) {

                    String userName = parameters.get(Constants.USER_NAME);
                    int score = Integer.parseInt(parameters.get(Constants.SCORE));

                    String result = updateScore(userName, score);

                    datagramPacket = new DatagramPacket(result.getBytes(StandardCharsets.UTF_8), result.getBytes(StandardCharsets.UTF_8).length, clientAddress, clientPort);
                    datagramSocket.send(datagramPacket);

                }

                else if (Validator.isGetUserScoreByNameValid(command, parameters)) {

                    String userName = parameters.get(Constants.USER_NAME);

                    String result = getUserScoreByName(userName);

                    datagramPacket = new DatagramPacket(result.getBytes(StandardCharsets.UTF_8), result.getBytes(StandardCharsets.UTF_8).length, clientAddress, clientPort);
                    datagramSocket.send(datagramPacket);
                }

                else if (Validator.isGetRankingsValid(command, parameters)) {

                    String result = getUsersByScore();

                    datagramPacket = new DatagramPacket(result.getBytes(StandardCharsets.UTF_8), result.getBytes(StandardCharsets.UTF_8).length, clientAddress, clientPort);
                    datagramSocket.send(datagramPacket);
                }

                else if (Validator.isEndGameValid(command, parameters)) {

                    String result = endGame();

                    datagramPacket = new DatagramPacket(result.getBytes(StandardCharsets.UTF_8), result.getBytes(StandardCharsets.UTF_8).length, clientAddress, clientPort);
                    datagramSocket.send(datagramPacket);
                }

                else {

                    String result = "Invalid command.";

                    datagramPacket = new DatagramPacket(result.getBytes(StandardCharsets.UTF_8), result.getBytes(StandardCharsets.UTF_8).length, clientAddress, clientPort);
                    datagramSocket.send(datagramPacket);
                }
            }

        } catch (IOException ex) {

            System.out.println("Error during IO operations.");
            ExceptionLogger.logException(ex);
        }
    }

    private String register(String userName, String email, String password, String confirmedPassword) {

        String message = "";

        if (!password.equals(confirmedPassword)) {

            message += "Passwords don't match.";
        }

        else if (!Validator.isPasswordValid(password)) {

            message += "Password is not valid.";
        }

        else if (dataSource.doesUserExistByName(userName)) {

            message += "A user with that user name already exists.";
        }

        else if (dataSource.doesUserExistByEmail(email)) {

            message += "A user with that email already exists.";
        }

        else {

            try {

                dataSource.insertUser(userName, email, HashGenerator.sha1(password));
                message += "Registration was successful.";

            } catch(NoSuchAlgorithmException ex) {

                System.out.println("Error during password hashing.");
                ExceptionLogger.logException(ex);
            }
        }

        return message;
    }

    private String login(String userName, String password) {

        String message = "";

        User user = dataSource.queryUser("name", userName);

        if (user != null && Validator.isPasswordCorrect(user, password)) {

            if (server.getSessionFromUserName(userName) != null) {

                logout(server.getSessionFromUserName(userName).getID());
            }

            Session session = new Session(userName);

            server.addSession(session);
            message += userName + " successfully logged in.";
        }

        else {

            message += "Incorrect user name or password.";
        }

        return message;
    }

    private String resetPassword(String email, String oldPassword, String newPassword) {

        String message = "";

        User user = dataSource.queryUser("email", email);

        if (user == null) {

            message += "The user does not exist.";
        }

        else if (!Validator.isPasswordCorrect(user, oldPassword)) {

            message += "Incorrect password.";
        }

        else if (!Validator.isPasswordValid(newPassword)) {

            message += "Invalid new password";
        }

        else {

            user.setHashedPassword(newPassword);
            dataSource.updateUser(user.getUserName(), user.getHashedPassword());

            message += "The password has been successfully reset.";
        }

        return message;
    }

    private String createTemporaryPassword(String email, String temporaryPassword) {

        String message = "";

        User user = dataSource.queryUser("email", email);

        if (user != null) {

            user.setHashedPassword(temporaryPassword);
            dataSource.updateUser(user.getUserName(), user.getHashedPassword());

            message += "The password has been successfully reset.";
        }

        else {

            message += "Incorrect user name or password.";
        }

        return message;
    }

    private String logout(String userName) {

        String message = "";

        Session session = server.getSessionFromUserName(userName);

        if (session != null) {

            server.removeSession(session);
            message += "The user was successfully logged out of the system.";
        }

        else {

            message += "The specified user is not logged in.";
        }

        return message;
    }

    private String getQuestion(String difficulty) {

        List<Question> questions = dataSource.queryQuestions(difficulty);

        Question randomQuestion = questions.get(new Random().nextInt(questions.size()));

        randomQuestion.shuffleAnswers();

        return gson.toJson(randomQuestion);
    }

    private String updateScore(String userName, int score) {

        String message = "";

        int userID = dataSource.queryUserIDByName(userName);

        if (userID != -1) {

            dataSource.updateScore(userID, score);
            message += "Score updated successfully.";
        }

        else {

            message += "No such user exists.";
        }

        return message;
    }

    private String getUsersByScore() {

        return gson.toJson(dataSource.queryUsersByScore());
    }

    private String getUserScoreByName(String userName) {

        UserScore userScore = dataSource.queryUserScoreByName(userName);

        return gson.toJson(userScore);
    }

    private String endGame() {

        return "Game Over";
    }
}