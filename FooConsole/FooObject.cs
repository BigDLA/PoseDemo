using System;

namespace FooConsole
{
    public class FooObject : IFooObject
    {
        public string Attr { get; set; }

        public FooObject(string attr)
        {
            Attr = attr;
        }
    }
}
