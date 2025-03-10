public class OracleConnection : DbConnection
{
    public OracleConnection(string connectionString) : base(connectionString) { }

    public override void Open()
    {
        Console.WriteLine($"Opening Oracle connection with connection string: {ConnectionString}");
        // Here you would normally use the Oracle API to open the connection
    }

    public override void Close()
    {
        Console.WriteLine("Closing Oracle connection.");
        // Here you would normally use the Oracle API to close the connection
    }
}