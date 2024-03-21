using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCSharp03
{
    internal class Program
    {
        static void change(int input)
        {
            input++;
        }
        //클래스 말고, 배열이나 List도 똑같이 참조복사 개념 적용됨
        //참고로 구조체(Struct)는 일반 자료형처럼 값 복사 개념 적용됨
        static void change(Student student)
        {
            student.name = "이주섭";
            student.score = 90;
            student.age = 20;
        }
        //ref = 참조자
        //메서드 안에서 값이 바뀌면 원본도 같이 바뀜
        static void change(ref int input)
        {
            input++;
        }
        static void Main(string[] args)
        {
            int a = 10;
            int b = a;
            b = 20;
            Console.WriteLine("a="+a+",b="+b); //서로 영향x
            change(a);
            Console.WriteLine("a="+a);

            Student s = new Student();
            s.name = "권성직";
            s.age = 30;
            s.score = 100;
            Student s2 = new Student();
            s2.name = "이유탁";
            s2.age = s.age;
            s2.score = 80;
            Console.WriteLine(s.name + "," + s.age + "," + s.score);
            Console.WriteLine(s2.name + "," + s2.age + "," + s2.score);
            Student dj = s;
            dj.score = 0;
            dj.name = "이동준";
            Console.WriteLine(s.name+","+s.age+","+s.score);
            Console.WriteLine(dj.name+","+ dj.age+","+ dj.score);
            change(s);
            Console.WriteLine(s.name + "," + s.age + "," + s.score);

            Console.WriteLine("a="+a); //ctrl+d ->한 줄복붙, 
            change(ref a);
            Console.WriteLine("a="+a);//alt+화살표위아래 -> 코드 이동


        }
    }
}
