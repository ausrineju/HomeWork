using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HomeWork
{
    class Filtering : ICanFilterCollections
    {
        
        public Dictionary<int, string> FilterDictionaryKeys(Dictionary<int, string> data, Func<int, bool> filterLogic)
        {
            Dictionary<int, string> newDictionary = new Dictionary<int, string>();
            foreach (var x in data)
            {
                int key = x.Key;
                string value = x.Value;
                bool result = filterLogic(key);
                if (result)
                {
                    newDictionary.Add(key, value);
                }
            }
            return newDictionary;
        }

        public Dictionary<int, string> FilterDictionaryValues(Dictionary<int, string> data, Func<string, bool> filterLogic)
        {
            Dictionary<int, string> newDictionary = new Dictionary<int, string>();
            foreach(var x in data)
            {
                int key = x.Key;
                string value = x.Value;
                bool result = filterLogic(value);
                if (result)
                {
                    newDictionary.Add(key, value);
                }
            }
            return newDictionary;
        }

        public IEnumerable<int> FilterIntegers(IEnumerable<int> data, Func<int, bool> filterLogic)
        {
            List<int> newList = new List<int>();
            
            foreach(int x in data)
            {
                bool result = filterLogic(x);
                if (result)
                {
                    newList.Add(x);
                }
            }
            return newList;
        }

        public IEnumerable<string> FilterStrings(IEnumerable<string> data, Func<string, bool> filterLogic)
        {

            List<string> newList = new List<string>();

            foreach (string x in data)
            {
                bool result = filterLogic(x);
                if (result)
                {
                    newList.Add(x);
                }
            }
            return newList;
        }

        public IEnumerable<string> FilterStrings(IEnumerable<string> data, IEnumerable<string> filter)
        {
            List<string> newList = new List<string>();
            foreach (string x in data)
            {
                if (!filter.Contains(x))
                {
                    newList.Add(x);
                }
            }
            return newList;
            
        }
    }
}
