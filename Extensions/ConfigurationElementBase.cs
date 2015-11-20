using System.Configuration;

namespace Affecto.Configuration.Extensions
{
    public abstract class ConfigurationElementBase : ConfigurationElement
    {
        public abstract string ElementKey { get; }
    }
}