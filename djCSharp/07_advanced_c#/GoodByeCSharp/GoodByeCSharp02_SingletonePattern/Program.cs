using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodByeCSharp02_SingletonePattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int test = MyMath.getInstance().power(5);
            //int test = MyMath.power(5);
            Console.WriteLine(  test  );
            Console.WriteLine( MyMath._getInstance.power(5) );
        }
    }
}
