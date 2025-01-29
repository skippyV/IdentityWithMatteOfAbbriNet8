namespace IdentityWithMatteOfAbbriNet8.Data
{
    public class MongoDbConfig
    {
        public string DatabaseName { get; init; }
        public string Host { get; init; }
        public int Port { get; init; }
        public string ConnectionString => $"mongodb://{Host}:{Port}/{DatabaseName}";
    }
}
