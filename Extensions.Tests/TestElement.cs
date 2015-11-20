using System.Configuration;

namespace Affecto.Configuration.Extensions.Tests
{
    public class TestElement : ConfigurationElementBase
    {
        [ConfigurationProperty("key", IsRequired = true)]
        public string Key
        {
            get { return (string) this["key"]; }
            set { this["key"] = value; }
        }

        [ConfigurationProperty("value", IsRequired = false)]
        public string Value
        {
            get { return (string) this["value"]; }
            set { this["value"] = value; }
        }

        public override string ElementKey
        {
            get { return Key; }
        }
    }
}