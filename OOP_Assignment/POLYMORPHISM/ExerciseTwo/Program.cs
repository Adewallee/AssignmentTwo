class Program
{
    static void Main()
    {
        try
        {
            // Create a SQL Server connection
            DbConnection sqlConnection = new SqlConnection("Server=myServerAddress;Database=myDataBase;User  Id=myUsername;Password=myPassword;");
            DbCommand sqlCommand = new DbCommand(sqlConnection, "SELECT * FROM Users");
            sqlCommand.Execute();

            // Create an Oracle connection
            DbConnection oracleConnection = new OracleConnection("Data Source=myOracleDB;User  Id=myUsername;Password=myPassword;");
            DbCommand oracleCommand = new DbCommand(oracleConnection, "SELECT * FROM Employees");
            oracleCommand.Execute();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}