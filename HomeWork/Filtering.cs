using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    class Filtering : IFilterICanFilterCollections
    {
        public Dictionary<int, string> FilterDictionaryKeys(Dictionary<int, string> data, Func<int, bool> filterLogic)
        {
            throw new NotImplementedException();
        }

        public Dictionary<int, string> FilterDictionaryValues(Dictionary<int, string> data, Func<string, bool> filterLogic)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<int> FilterIntegers(IEnumerable<int> data, Func<int, bool> filterLogic)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<string> FilterStrings(IEnumerable<string> data, Func<string, bool> filterLogic)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<string> FilterStrings(IEnumerable<string> data, IEnumerable<string> filter)
        {
            throw new NotImplementedException();
        }

   
    }
}
