using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodByeCSharp04_ObserverConsoleVer
{
    public class Star2Observer : IObserver
    {
        public bool isObserverMode { get; set; }
        public void update(string value)
        {
            if(isObserverMode)
                Console.WriteLine("!!!멈춰서 관찰 중... 결과 : " + value+"!!!");
            else
                Console.WriteLine("~~~움직이면서 관찰 중... 결과 : " + value+"~~~");
        }
    }
}
