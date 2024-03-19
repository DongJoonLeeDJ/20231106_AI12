using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCSharp001_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StartPos:
            int sum = 0;
            for (int i = 1; i <= 100; i++)
                sum += i;
            Console.WriteLine("1부터100까지의 합 :"+sum);

            int[] nums = { 11, 10, 50, 27, 30 };
            //nums라는 배열안에 있는 값들을 하나씩 item에 집어넣어서
            //nums의 길이만큼 반복문을 수행하는 것
            //foreach(var 요소 in 컬렉션) {}
            //컬렉션 = 배열이나 List와 같이 여러 개의 값을 저장하는 것
            //java의 for(int item : nums)랑 동일한 것
            foreach(var item in nums) //var 대신 int 써도 됨
                Console.WriteLine(item);

            Console.WriteLine("숫자 입력");
            int num = int.Parse(Console.ReadLine());
            if (num < 0)
                goto StartPos;
            Console.WriteLine("프로그램 종료");

        }
    }
}
