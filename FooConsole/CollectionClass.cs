using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FooConsole
{
    public class CollectionClass : ICollectionClass
    {
        internal static ConcurrentDictionary<string, ConcurrentDictionary<ICollectionClass, ICollectionClass>> CollectionClassCollection = 
            new();

        public static ICollectionClass SomeStaticMethod(ICollectionClass obj)
        { 
            if (CollectionClassCollection["foo"].TryGetValue(obj, out ICollectionClass returnedObj))
                return returnedObj;
            return null;
        }
    }
}
