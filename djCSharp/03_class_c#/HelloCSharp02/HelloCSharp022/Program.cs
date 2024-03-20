using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCSharp022
{
    internal class Program
    {
        //static이 붙어 있는 메서드 안에는 static이 붙은
        //메서드나 변수만 사용 가능함
        //static 없는 애는 쓸 수 없음.
        static void HelloWorld()
        {
            Console.WriteLine("Hello World!");
        }
        void HiWorld()
        {
            Console.WriteLine("Hi World!");
        }
        static int count = 0;
        int number = 0;
        static void Main(string[] args)
        {
            HelloWorld();
            //HiWorld();//static 붙은 애가 메모리가 먼저 올라감
            //static 시점에선 static 붙지 않은 변수나 함수는
            //아직 존재하지 않는 것이다.
            Console.WriteLine(count);
            //Console.WriteLine(number);

            //굳이 static 없는 걸 Main에서 쓰고 싶다면
            //자기 자신을 객체화 해야 함
            //이렇게 하면 메모리가 할당이 되게 되고
            //그러면 static이 붙은 메서드 안에서도 쓸 수 있음
            new Program().HiWorld();

            //인스턴스 별로 다른 값 갖는 것 : 인스턴스 변수(static 없음)
            //클래스 별로 같은 값 갖는 것 : 클래스 변수(static 있음)
            Product p1 = new Product();
            p1.name = "감자";
            p1.price = 1000;
            Product.countOfProduct++;

            Product p2 = new Product() {name="당근",price=500};
            Product.countOfProduct++;

            Console.WriteLine(p1.name);
            Console.WriteLine(p1.price);            
            Console.WriteLine(p2.name);
            Console.WriteLine(p2.price);
            Console.WriteLine(Product.countOfProduct);



        }
    }
}
