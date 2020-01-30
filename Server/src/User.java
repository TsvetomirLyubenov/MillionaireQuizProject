import java.security.NoSuchAlgorithmException;

public class User {

    private String userName;
    private String email;
    private String hashedPassword;

    public User(String userName, String email, String hashedPassword) {

        this.userName = userName;
        this.email = email;
        this.hashedPassword = hashedPassword;
    }

    public String getUserName() {

        return userName;
    }

    public String getHashedPassword() {

        return hashedPassword;
    }

    public void setHashedPassword(String password) {

        try {

            this.hashedPassword = HashGenerator.sha1(password);

        } catch(NoSuchAlgorithmException ex) {

            this.hashedPassword = null;
            System.out.println("Could not set the password.");
            ExceptionLogger.logException(ex);
        }
    }
}
