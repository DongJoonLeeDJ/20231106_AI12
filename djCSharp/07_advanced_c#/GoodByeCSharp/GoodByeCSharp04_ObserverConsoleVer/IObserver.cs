using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodByeCSharp04_ObserverConsoleVer
{
    public interface IObserver //관찰자의 역할 정의
    {
        void update(string value);
    }
}
