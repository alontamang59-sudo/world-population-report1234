Java
public class Database {

    private String server;
    private String database;

    public Database() {
        server = "localhost";
        database = "world";
    }

    public String getServer() {
        return server;
    }

    public String getDatabase() {
        return database;
    }
}
