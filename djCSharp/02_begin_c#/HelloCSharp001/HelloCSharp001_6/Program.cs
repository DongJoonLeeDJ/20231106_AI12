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

            int[] numbers = new int[5];
            for(int i = 0; i<numbers.Length; i++) 
            {
                Console.WriteLine(i+1+"번째 값 입력");
                numbers[i] = int.Parse(Console.ReadLine());
            }
            //가장 첫번째 값이 최댓값, 최솟값이라고 가정
            int max = numbers[0];
            int min = numbers[0];
            for(int i = 1; i<numbers.Length; i++)
            {
                if (max < numbers[i])
                    max = numbers[i];
                if (min > numbers[i]) //if if 대신 //if else를 쓰게 되면 안 됨
                    min = numbers[i]; //다만 if else if를 쓸 경우에는 되긴 함
            }
            Console.WriteLine("최댓값:"+max);
            Console.WriteLine("최솟값:"+min);

            //한글 다 출력하기
            for (char i = '가'; i <= '힣'; i++)
                Console.Write(i);
            Console.WriteLine();

        }
    }
}
