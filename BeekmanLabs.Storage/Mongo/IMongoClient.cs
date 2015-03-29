using MongoDB.Driver;

namespace BeekmanLabs.Storage.Mongo
{
    public interface IMongoClient
    {
        MongoDatabase GetDatabase(string name, MongoDatabaseSettings settings = null);
    }
}
