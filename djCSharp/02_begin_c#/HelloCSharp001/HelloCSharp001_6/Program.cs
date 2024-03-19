using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCSharp001_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int floor = 5; 
            
            for(int i = 0; i < floor; i++) 
            {
                //공백 찍는 부분
                for (int j = floor - i; j > 1; j--)
                    Console.Write(" ");

                //별 찍는 부분
                for (int j = 0; j < 2 * i + 1; j++)
                    Console.Write("*");
                Console.WriteLine();//줄 띄어쓰기
            }
        }
    }
}
