using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCSharp031
{
    internal class Program
    {
        static void swap(int a, int b)//main의 원본에
        {                                   //영향을 주지 않음
            int t = a; 
            a = b;
            b = t;
        }
        static void swap(ref int a, ref int b)//원본도 같이 바뀜
        {                      
            int t = a;
            a = b;
            b = t;
        }
        static void change(Student student)
        {
            student.name = "안위재";
            student.age = 40;
            student.score = 75;
        }
        static void Main(string[] args)
        {
            int a = 3;
            int b = 5;
            int t = a;
            Console.WriteLine("a="+a+",b="+b);
            a = b;
            b = t;
            Console.WriteLine("a="+a+",b="+b);
            swap(a, b);
            Console.WriteLine("a="+a+",b="+b);
            swap(ref a, ref b);
            Console.WriteLine("a="+a+",b="+b);

            Student s = new Student();
            s.age = 30;
            s.name = "권성직";
            s.score = 100;
            Student dj = s;
            dj.score = 0;
            dj.name = "이동준";
            Console.WriteLine(s.name+","+s.age+","+s.score);
            Console.WriteLine(dj.name+","+ dj.age+","+ dj.score);
            change(dj);
            Console.WriteLine(dj.name+","+ dj.age+","+ dj.score);
        }
    }
}
