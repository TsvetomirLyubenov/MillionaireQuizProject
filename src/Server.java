import java.net.*;
import java.util.*;

public class Server {

    private final HashMap<String, Session> nameSessions;

    public static void main(String[] args) {

        new Server().run();
    }

    private Server() {

        nameSessions = new HashMap<>();
    }

    private void run() {

        try (DatagramSocket datagramSocket = new DatagramSocket(8080);
             DataSource dataSource = new DataSource()) {

            System.out.println("Server is running.");

            while (true) {

                byte[] buf = new byte[65000];
                DatagramPacket datagramPacket = new DatagramPacket(buf, 65000);

                datagramSocket.receive(datagramPacket);

                ServerRunnable runnable = new ServerRunnable(datagramPacket, this, dataSource);
                new Thread(runnable).start();
            }

        } catch (Exception ex) {

            System.out.println("Another server may be running on the same port.");
            ExceptionLogger.logException(ex);
        }
    }

    public synchronized void addSession(Session session) {

        nameSessions.put(session.getUserName(), session);
    }

    public synchronized void removeSession(Session session) {

        if (session != null) {

            nameSessions.remove(session.getUserName());
        }
    }

    public synchronized Session getSessionFromUserName(String userName) {

        return nameSessions.get(userName);
    }
}
