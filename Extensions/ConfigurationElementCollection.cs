using System.Collections.Generic;
using System.Configuration;

namespace Affecto.Configuration.Extensions
{
    public class ConfigurationElementCollection<T> : ConfigurationElementCollection, IEnumerable<T> where T : ConfigurationElementBase, new()
    {
        public new virtual int Count
        {
            get { return base.Count; }
        }

        public new virtual T this[string key]
        {
            get { return (T) BaseGet(key); }
        }

        public new virtual IEnumerator<T> GetEnumerator()
        {
            int count = Count;
            for (int i = 0; i < count; i++)
            {
                yield return (T) BaseGet(i);
            }
        }

        protected override ConfigurationElement CreateNewElement()
        {
            return new T();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((T) element).ElementKey;
        }
    }
}