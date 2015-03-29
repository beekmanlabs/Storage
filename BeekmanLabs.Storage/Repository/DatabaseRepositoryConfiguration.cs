using MySql.Data.Entity;
using MySql.Data.MySqlClient;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.SqlServer;

namespace BeekmanLabs.Storage.Repository
{
    public class DatabaseRepositoryConfiguration : DbConfiguration
    {
        public DatabaseRepositoryConfiguration()
            : base()
        {}

        public DatabaseRepositoryConfiguration(string serverType)
        {
            if (serverType == "MySQL")
            {
                SetExecutionStrategy(MySqlProviderInvariantName.ProviderName, () => new MySqlExecutionStrategy());
                SetProviderFactory(MySqlProviderInvariantName.ProviderName, new MySqlClientFactory()); 
                SetProviderServices(MySqlProviderInvariantName.ProviderName, new MySqlProviderServices());
                SetDefaultConnectionFactory(new MySqlConnectionFactory());
            }
            else if (serverType == "SQLServer")
            {
                SetExecutionStrategy("System.Data.SqlClient", () => new SqlAzureExecutionStrategy());
                SetDefaultConnectionFactory(new LocalDbConnectionFactory("v11.0"));
            }
        }
    }
}
