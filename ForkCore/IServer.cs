using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForkCore
{
    public interface IServer
    {
        int Add(int x, int y);
        int Divide(int x, int y);

        int DoStuff(int x);
    }
}
