using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FooConsole
{
    public class LolObject : ILolObject
    {
        public LolObject()
        {
            
        }

        public byte[] LolMethod()
        {
            var a = new CollectionClass();
            var fooObject = new FooObject("lol");
            CollectionClass.CollectionClassCollection["foo"] = new ConcurrentDictionary<ICollectionClass, ICollectionClass>
            {
                [a] = new CollectionClass()
            };
            var foo = CollectionClass.SomeStaticMethod(a);
            return fooObject.FooRecall();
        }
    }
}
