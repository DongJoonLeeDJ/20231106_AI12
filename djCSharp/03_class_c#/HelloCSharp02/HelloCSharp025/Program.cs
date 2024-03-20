using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCSharp025
{
    internal class Program
    {
        //오버로딩 : 매개변수의 개수나 타입 다르면
        //함수(=메서드) 이름 똑같아도 서로 다른 것으로 간주함
        //java에도 존재하는 개념

        static void introduce(int age)
        {
            Console.WriteLine("내 나이는 " + age+"살입니다.");
        }
        static void introduce(string name)
        {
            Console.WriteLine("내 이름은 " + name+"입니다.");
        }
        static void introduce()
        {
            Console.WriteLine("자기 소개 메서드...");
        }

        static void Main(string[] args)
        {
            introduce(35);
            introduce("이동준");
            introduce();
            Rectangle.color = "파란색";
            Rectangle rec1 = new Rectangle();
            rec1.width = 10;
            rec1.height = 5;
            Rectangle rec2 = new Rectangle();
            rec2.width = 7;
            rec2.height = 8;
            Rectangle rec3 = new Rectangle();
            Console.WriteLine
                ("여기 있는 모든 사각형의 색 : " + Rectangle.color);
            //alt shift 화살표 위나 아래 누르면 여러 개 선택 됨
            //ctrl alt 누르고 마우스 클릭하면 여러 군데 선택 가능
            Console.WriteLine(rec1.getArea()); 
            Console.WriteLine(rec2.getArea()); 
            Console.WriteLine(rec3.getArea()); 
            Console.WriteLine(Rectangle.calcRecArea(100,200));

            //Product p = new Product(); //빈 생성자가 사라졌으므로 안 됨
            Product p1 = new Product("고구마",500);
            Console.WriteLine(p1.name+"의 가격:"+p1.price);
            Product p2 = new Product("대게");

            //private 인 것들을 다른 곳에서
            //접근하려면 public인 메서드가
            //필요해 짐...
            //p2.description
            //p2.vipPrice
            //보통 C#에선 웬만하면
            //public... get set을 쓴다
            //java에서 웬만하면 getter/setter쓰듯이 말이다.

        }
    }
}
