using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodByeCSharp04_ObserverConsoleVer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Star2Observer s2o1 = new Star2Observer();
            s2o1.isObserverMode = true; //관측 모드
            IObserver s2o2 = new Star2Observer(); //다형성 적용
            (s2o2 as Star2Observer).isObserverMode = false; //감시 모드


            Star1Observer s1o1 = new Star1Observer();
            IObserver s1o2 = new Star1Observer(); //다형성 적용

            Protoss kalai = new Protoss();
            kalai.name = "칼라이"; //스타1, 스타2 다 등장함
            ISubject nerazim = new Protoss();
            (nerazim as Protoss).name = "네라짐"; //스타2에만 등장함

            kalai.register(s1o1);
            kalai.register(s1o2);
            kalai.register(s2o1);
            kalai.register(s2o2);
            kalai.notify("적이 공격중입니다.");

            nerazim.register(s2o1);
            nerazim.register(s2o2);
            nerazim.notify("적이 공격중이다!!!!");

            Protoss taldarim = new Protoss();
            taldarim.name = "탈다림";
            taldarim.register(s2o1);
            taldarim.register(s2o2);
            taldarim.unregister(s2o2); //알라라크의 라크쉬르를 훔쳐보는 옵져버 하나 부셨음. 즉 제외됨
            taldarim.notify("라크쉬르가 시작되었다!");

            //옵저버 패턴은 일괄적으로 특정 인터페이스에 있는 메서드를 호출 가능하고
            //일괄적으로 호출할 그룹에 특정 객체를 추가하거나 제외할 수 있는 것이다.
        }
    }
}
