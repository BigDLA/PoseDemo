using System;
using System.Collections.Generic;

namespace FooConsole
{
    public class FooObject : IFooObject
    {
        public string Attr { get; set; }

        public FooObject(string attr)
        {
            Attr = attr;
        }
        
        public IEnumerable<string> GetIEnumerable()
        {
            var dictionary = new Dictionary<string, string>() { { "foo", "b" } };
            return dictionary.Values;
        }

    }
}
