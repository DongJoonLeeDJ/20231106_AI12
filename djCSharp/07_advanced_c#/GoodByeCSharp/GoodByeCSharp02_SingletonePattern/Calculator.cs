using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodByeCSharp02_SingletonePattern
{
    public class Calculator
    {
        public int plus(int x, int y) { return x + y; }
        public virtual int minus(int x, int y) { return x - y; }
    }
}
