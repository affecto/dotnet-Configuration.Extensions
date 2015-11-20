namespace Affecto.Configuration.Extensions
{
    public interface IApplicationConfiguration
    {
        string GetAppSetting(string key);
        string GetConnectionString(string key);
    }
}