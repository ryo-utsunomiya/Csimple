using System.Collections.Generic;

namespace Csimple
{
    public class Container
    {
        private readonly Dictionary<string, object> _dictionary;

        public Container(Dictionary<string, object> dictionary = null)
        {
            _dictionary = dictionary ?? new Dictionary<string, object>();
        }

        public void Add(string key, object value)
        {
            _dictionary.Add(key, value);
        }

        public void Remove(string key)
        {
            _dictionary.Remove(key);
        }

        public bool Has(string key)
        {
            return _dictionary.ContainsKey(key);
        }

        public object Get(string key)
        {
            return _dictionary[key];
        }
    }
}
