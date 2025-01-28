using System;
using Pose;

namespace FooConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var fooObject = new FooObject("bum");
            fooObject.FooStatic();

            Shim fooStaticShim = Shim.Replace(() => FooExtensions.FooRecall(fooObject)).With(delegate(IFooObject obj) 
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Shim");
                Console.ForegroundColor = ConsoleColor.White;
                return new byte[1];
            });

            var lolObject = TopObject.Lol; ;

            // just to make sure the method works
            var b = lolObject.LolMethod();


            byte[] a = new byte[0];
            PoseContext.Isolate(() =>
            {
                a = lolObject.LolMethod();
            }, fooStaticShim);

            Console.WriteLine(a[0].ToString());
        }
    }
}
