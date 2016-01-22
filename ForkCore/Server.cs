using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForkCore
{
    public class Server:IServer
    {
        public int Add(int x, int y)
        {
            return x + y;
        }


        public int Divide(int x, int y)
        {
            return x / y;
        }


        public int DoStuff(int x)
        {
            return x + 5;
        }
    }
}
