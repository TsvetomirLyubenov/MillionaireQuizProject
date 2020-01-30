import java.security.NoSuchAlgorithmException;
import java.util.HashMap;

public class Validator {

    private static boolean isEmailValid(String email) {

        return email.matches("[\\S]+[@][\\S]+[.][\\S]+");
    }

    private static boolean isUserNameValid(String userName) {

        return userName.matches("[\\S]*[a-zA-Z][\\S]*");
    }

    private static boolean isDifficultyValid(String difficulty) {

        return difficulty.equals("easy") || difficulty.equals("medium") || difficulty.equals("hard");
    }

    private static boolean isScoreValid(String userName) {

        return userName.matches("[\\d]*[0-9][\\d]*");
    }

    public static boolean isPasswordValid(String password) {

        return (password.matches("[\\S]*[a-z][\\S]*") && password.matches("[\\S]*[A-Z][\\S]*") && password.matches("[\\S]*[0-9][\\S]*"));
    }

    public static boolean isRegisterValid(String command, HashMap<String, String> parameters) {

        boolean checkUserName = parameters.get(Constants.USER_NAME) != null && isUserNameValid(parameters.get(Constants.USER_NAME));
        boolean checkPassword = parameters.get(Constants.PASSWORD) != null;
        boolean checkConfirmedPassword = parameters.get(Constants.CONFIRMED_PASSWORD) != null;
        boolean checkEmail = parameters.get(Constants.EMAIL) != null && isEmailValid(parameters.get(Constants.EMAIL));

        return command.equals(Constants.REGISTER_COMMAND) && checkUserName && checkPassword && checkConfirmedPassword && checkEmail;
    }

    public static boolean isLoginValid(String command, HashMap<String, String> parameters) {

        boolean checkPassword = parameters.get(Constants.PASSWORD) != null && isPasswordValid(parameters.get(Constants.PASSWORD));
        boolean checkUserName = parameters.get(Constants.USER_NAME) != null && isUserNameValid(parameters.get(Constants.USER_NAME));

        return command.equals(Constants.LOGIN_COMMAND) && checkUserName && checkPassword;
    }

    public static boolean isResetValid(String command, HashMap<String, String> parameters) {

        boolean checkEmail = parameters.get(Constants.EMAIL) != null && isEmailValid(parameters.get(Constants.EMAIL));
        boolean checkOldPassword = parameters.get(Constants.OLD_PASSWORD) != null;
        boolean checkNewPassword = parameters.get(Constants.NEW_PASSWORD) != null;

        return command.equals(Constants.RESET_COMMAND) && checkEmail && checkOldPassword && checkNewPassword;
    }

    public static boolean isCreateTemporaryPasswordValid(String command, HashMap<String, String> parameters) {

        boolean checkEmail = parameters.get(Constants.EMAIL) != null && isEmailValid(parameters.get(Constants.EMAIL));
        boolean checkTemporaryPassword = parameters.get(Constants.TEMPORARY_PASSWORD) != null && isPasswordValid(parameters.get(Constants.TEMPORARY_PASSWORD));

        return command.equals(Constants.CREATE_TEMPORARY_PASSWORD_COMMAND) && checkEmail && checkTemporaryPassword;
    }

    public static boolean isLogoutValid(String command, HashMap<String, String> parameters) {

        boolean checkUserName = parameters.get(Constants.USER_NAME) != null && isUserNameValid(parameters.get(Constants.USER_NAME));

        return command.equals(Constants.LOGOUT_COMMAND) && checkUserName;
    }

    public static boolean isEndGameValid(String command, HashMap<String, String> parameters) {

        return command.equals(Constants.END_GAME_COMMAND) && parameters.isEmpty();
    }

    public static boolean isGetQuestionValid(String command, HashMap<String, String> parameters) {

        boolean checkDifficulty = parameters.get(Constants.DIFFICULTY) != null && isDifficultyValid(parameters.get(Constants.DIFFICULTY));

        return command.equals(Constants.GET_QUESTION_COMMAND) && checkDifficulty;
    }
    public static boolean isUpdateScoreValid(String command, HashMap<String, String> parameters) {

        boolean checkUserName = parameters.get(Constants.USER_NAME) != null && isUserNameValid(parameters.get(Constants.USER_NAME));
        boolean checkScore = parameters.get(Constants.SCORE) != null && isScoreValid(parameters.get(Constants.SCORE));

        return command.equals(Constants.UPDATE_SCORE_COMMAND) && checkUserName && checkScore;
    }

    public static boolean isGetRankingsValid(String command, HashMap<String, String> parameters) {

        return command.equals(Constants.GET_RANKINGS_COMMAND) && parameters.isEmpty();
    }

    public static boolean isGetUserScoreByNameValid(String command, HashMap<String, String> parameters) {

        boolean checkUserName = parameters.get(Constants.USER_NAME) != null && isUserNameValid(parameters.get(Constants.USER_NAME));

        return command.equals(Constants.GET_USER_SCORE_BY_NAME_COMMAND) && checkUserName;
    }

    public static boolean isPasswordCorrect(User user, String password) {

        String sha1Password = "";

        try {

            sha1Password = HashGenerator.sha1(password);

        } catch (NoSuchAlgorithmException ex) {

            System.out.println("Algorithm not available.");
            ExceptionLogger.logException(ex);
        }

        return user.getHashedPassword().equals(sha1Password);
    }

    public static HashMap<String, String> getParameters(String[] tokens) {

        HashMap<String, String> parameters = new HashMap<>();

        for (int i = 1; i < tokens.length - 1; i += 2) {

            parameters.put(tokens[i], tokens[i+1]);
        }

        return parameters;
    }
}
