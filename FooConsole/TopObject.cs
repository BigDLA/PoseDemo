using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FooConsole
{
    public static class TopObject
    {
        private static ILolObject lol;

        public static ILolObject Lol { get
            {
                if(lol == null)
                    lol = new LolObject();

                return lol;
            }
            set 
            { lol = value; } }
    }
}
