namespace Ambev.DeveloperEvaluation.ORM.Options
{
    public class MongoDatabaseSettings : IMongoDatabaseSettings
    {
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
}
