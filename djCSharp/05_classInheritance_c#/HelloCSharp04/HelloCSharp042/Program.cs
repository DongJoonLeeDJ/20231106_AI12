using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCSharp042
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //제너릭 활용 예시
            Student<int> s1 = new Student<int>();
            Student<string> s2 = new Student<string>();

            s1.hakbeon = int.Parse("0123");
            s2.hakbeon = "0123";

            Console.WriteLine("s1의 학번 : " + s1.hakbeon);
            Console.WriteLine("s2의 학번 : " + s2.hakbeon);

            //int a = int.Parse("aaa");
            //Console.WriteLine("프로그램이 튕기므로 이 부분 실행 안 됨");
            
            //TryParse는 Parse랑 다르게
            //숫자로 바꿀 수 없는 값이 나와도 프로그램이 종료되진 않음
            //대신 이 함수 자체는 false를 리턴하고, 또 다른 변수에 0을 대입해줌

            //out 키워드 잘 활용하면 swap함수처럼 쓸 수 있고
            //또한 하나의 함수에서 여러 개의 값을 리턴하는 것과 같은 효과를
            //볼 수 있다.
            int a;
            bool fa = int.TryParse("aaa", out a);
            bool fb = int.TryParse("aaa", out int b);
            bool fc = int.TryParse("123", out int c);
            Console.WriteLine("a="+a+",b="+b+",c="+c);
            Console.WriteLine("fa=" + fa + ",fb=" + fb+",fc="+fc);


        }
    }
}
