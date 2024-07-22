namespace WinmeierMigratorService.Utilities;

public class LastInsertedModel
{
    public string TableName { get; set; }
    public string? LastInsertedValue { get; set; }
    public bool HasIdentity { get; set; }
    public string PrimaryKey { get; set; }
}
