using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Affecto.Configuration.Extensions.Tests
{
    [TestClass]
    public class ConfigurationElementCollectionTests
    {
        private TestConfigurationSection settings;
            
        [TestInitialize]
        public void Setup()
        {
            settings = TestConfigurationSection.Settings;
        }

        [TestMethod]
        public void TestCollectionIsNotNull()
        {
            Assert.IsNotNull(settings.TestElementsCollection);
        }

        [TestMethod]
        public void EmptyCollectionIsNotNull()
        {
            Assert.IsNotNull(settings.EmptyElementsCollection);
        }

        [TestMethod]
        public void MissingCollectionIsNotNull()
        {
            Assert.IsNotNull(settings.MissingCollection);
        }

        [TestMethod]
        public void EmptyCollectionContainsNoItems()
        {
            Assert.IsFalse(settings.EmptyElementsCollection.Any());
        }

        [TestMethod]
        public void MissingCollectionContainsNoItems()
        {
            Assert.IsFalse(settings.MissingCollection.Any());
        }

        [TestMethod]
        public void TestCollectionContainsAllItems()
        {
            Assert.AreEqual(3, settings.TestElementsCollection.Count);
            Assert.AreEqual("first", settings.TestElementsCollection.ElementAt(0).Key);
            Assert.AreEqual("second", settings.TestElementsCollection.ElementAt(1).Key);
            Assert.AreEqual("third", settings.TestElementsCollection.ElementAt(2).Key);
        }

        [TestMethod]
        public void CorrectElementIsReturnedByElementKey()
        {
            TestElement element = settings.TestElementsCollection["first"];
            Assert.IsNotNull(element);
            Assert.AreEqual("first", element.Key);
            Assert.AreEqual("1st", element.Value);
        }
    }
}