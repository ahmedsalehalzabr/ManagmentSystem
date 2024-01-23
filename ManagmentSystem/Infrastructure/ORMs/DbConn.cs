namespace Infrastructure.ORM;

public enum ConnectionType
{
    SqlServer,
    PostgreSQL,
}

public static class DBConn
{
    public static readonly ConnectionType ConnectionType = ConnectionType.SqlServer;

    public static string ConnectionString => ConnectionType switch
    {
        ConnectionType.SqlServer => "Server=DESKTOP-CKRA04M\\SQLEXPRESS; Database=ManagmentSystem; " +
            "Trusted_Connection=True; MultipleActiveResultSets=true; User Id=sa; Password=771143849; TrustServerCertificate=True;",

        ConnectionType.PostgreSQL => "Server=localhost; Port=5432; Database=ManagmentSystem; " +
            "User Id=postgres; Password=postgres;",

        _ => "",
    };
}