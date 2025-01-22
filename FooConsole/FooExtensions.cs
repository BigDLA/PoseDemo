using System;

namespace FooConsole
{
    public static class FooExtensions
    {
        public static byte[] FooStatic(this IFooObject obj)
        {
            Console.WriteLine(obj.Attr + "_original");
            return new byte[0];
        }

        public static byte[] FooRecall(this IFooObject obj) => FooStatic(obj);
    }
}
