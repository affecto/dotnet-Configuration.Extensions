using System.Configuration;

namespace Affecto.Configuration.Extensions.Tests
{
    public class TestConfigurationSection : ConfigurationSection
    {
        private static readonly TestConfigurationSection SettingsInstance = ConfigurationManager.GetSection("testConfiguration") as TestConfigurationSection;

        public static TestConfigurationSection Settings
        {
            get { return SettingsInstance; }
        }

        [ConfigurationProperty("testElements", IsDefaultCollection = true)]
        [ConfigurationCollection(typeof(ConfigurationElementCollection<TestElement>), AddItemName = "testElement")]
        public ConfigurationElementCollection<TestElement> TestElementsCollection
        {
            get { return (ConfigurationElementCollection<TestElement>) base["testElements"]; }
        }

        [ConfigurationProperty("emptyElements", IsDefaultCollection = true)]
        [ConfigurationCollection(typeof(ConfigurationElementCollection<TestElement>), AddItemName = "testElement")]
        public ConfigurationElementCollection<TestElement> EmptyElementsCollection
        {
            get { return (ConfigurationElementCollection<TestElement>) base["emptyElements"]; }
        }

        [ConfigurationProperty("missing", IsDefaultCollection = true)]
        [ConfigurationCollection(typeof(ConfigurationElementCollection<TestElement>), AddItemName = "testElement")]
        public ConfigurationElementCollection<TestElement> MissingCollection
        {
            get { return (ConfigurationElementCollection<TestElement>) base["missing"]; }
        }
    }
}