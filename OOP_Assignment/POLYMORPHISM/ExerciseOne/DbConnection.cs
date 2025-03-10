using System;

public abstract class DbConnection
{
    public string ConnectionString { get; private set; }
    public TimeSpan Timeout { get; set; }

    public DbConnection(string connectionString)
    {
        if (string.IsNullOrEmpty(connectionString))
        {
            throw new ArgumentException("Connection string cannot be null or empty.", nameof(connectionString));
        }

        ConnectionString = connectionString;
        Timeout = TimeSpan.FromSeconds(30); // Default timeout
    }

    public abstract void Open();
    public abstract void Close();
}