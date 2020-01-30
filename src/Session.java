import java.util.UUID;

public class Session {

    private final String userName;
    private final String id;

    public Session(String userName) {

        this.userName = userName;
        this.id = UUID.randomUUID().toString();
    }

    public String getUserName() {

        return userName;
    }

    public String getID() {

        return id;
    }
}
