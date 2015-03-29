using System.Data.Entity;

namespace BeekmanLabs.Storage.Repository
{
    public class DatabaseRespositoryContext : DbContext
    {
        public DatabaseRespositoryContext() { }

        public DatabaseRespositoryContext(string connectionString)
            : base(connectionString)
        { }
    }
}
