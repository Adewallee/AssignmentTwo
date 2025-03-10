public class DbCommand
{
    private DbConnection _connection;
    private string _instruction;

    public DbCommand(DbConnection connection, string instruction)
    {
        _connection = connection ?? throw new ArgumentNullException(nameof(connection), "Connection cannot be null.");
        _instruction = string.IsNullOrWhiteSpace(instruction) ? throw new ArgumentException("Instruction cannot be null or empty.", nameof(instruction)) : instruction;
    }

    public void Execute()
    {
        _connection.Open();
        Console.WriteLine($"Executing instruction: {_instruction}");
        _connection.Close();
    }
}