using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    interface ICanFilterCollections
    {
        IEnumerable<string> FilterStrings(IEnumerable<string> data, Func<string, bool> filterLogic);
        IEnumerable<string> FilterStrings(IEnumerable<string> data, IEnumerable<string> filter);
        IEnumerable<int> FilterIntegers(IEnumerable<int> data, Func<int, bool> filterLogic);
        Dictionary<int, string> FilterDictionaryValues(Dictionary<int, string> data, Func<string, bool> filterLogic);
        Dictionary<int, string> FilterDictionaryKeys(Dictionary<int, string> data, Func<int, bool> filterLogic);

    }
}
