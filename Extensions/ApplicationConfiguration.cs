using System.Configuration;

namespace Affecto.Configuration.Extensions
{
    public class ApplicationConfiguration : IApplicationConfiguration
    {
        public string GetAppSetting(string key)
        {
            return ConfigurationManager.AppSettings.Get(key);
        }

        public string GetConnectionString(string key)
        {
            ConnectionStringSettings connectionString = ConfigurationManager.ConnectionStrings[key];
            if (connectionString != null)
            {
                return connectionString.ConnectionString; 
            }
                
            return null;
        }
    }
}