namespace Ambev.DeveloperEvaluation.ORM.Options
{
    public interface IMongoDatabaseSettings
    {
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}
