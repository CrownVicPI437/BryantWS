namespace BlazorApp1.Context;

public class SqlConnectionConfiguration
{
    public SqlConnectionConfiguration(string value) => Value = value;
    public string Value { get; }
}