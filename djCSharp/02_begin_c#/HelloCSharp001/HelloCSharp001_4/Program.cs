using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCSharp001_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("언제 태어났니?(년도, ex. 1989)");
            int year = int.Parse(Console.ReadLine());
            year = year % 12; //0~11
            if(year==9) {
                Console.WriteLine("뱀띠!");
            }
            else if(year==10)
                Console.WriteLine("말띠");
            else if(year==11)
                Console.WriteLine("양띠");
            else if(year==0)
                Console.WriteLine("원숭이띠");
            else if(year==1)
                Console.WriteLine("닭띠");
            else if(year==2)
                Console.WriteLine("개띠");
            else if(year==3)
                Console.WriteLine("돼지띠");
            else if(year==4)
                Console.WriteLine("쥐띠");
            else if(year==5)
                Console.WriteLine("소띠");
            else if(year==6)
                Console.WriteLine("호랑이띠");
            else if(year==7)
                Console.WriteLine("토끼띠");
            else if(year==8)
                Console.WriteLine("용띠");
            else
                Console.WriteLine($"{year}???");

            year = DateTime.Now.Year % 12;

            switch (year)
            {
                case 9:
                    Console.WriteLine("뱀띠!");
                    break;
                case 10:
                    Console.WriteLine("말띠");
                    break;
                case 11:
                    Console.WriteLine("양띠");
                    break;
                case 0:
                    Console.WriteLine("원숭이띠");
                    break;
                case 1:
                    Console.WriteLine("닭띠");
                    break;
                case 2:
                    Console.WriteLine("개띠");
                    break;
                case 3:
                    Console.WriteLine("돼지띠");
                    break;
                case 4:
                    Console.WriteLine("쥐띠");
                    break;
                case 5:
                    Console.WriteLine("소띠");
                    break;
                case 6:
                    Console.WriteLine("호랑이띠");
                    break;
                case 7:
                    Console.WriteLine("토끼띠");
                    break;
                case 8:
                    Console.WriteLine("용띠");
                    break;
                default:
                    Console.WriteLine("이게 나올 일은 없다.");
                    //Console.WriteLine($"{year}???");
                    break;
            }

            Console.WriteLine("몇 월에 태어나셨나요?");
            int month = int.Parse(Console.ReadLine());
            if(month==12 || month == 1 || month==2)
                Console.WriteLine("겨울");
            else if(month>=3 && month <=5)
                Console.WriteLine("봄");
            else if(month>5 && month <9) //6,7,8
                Console.WriteLine("여름");
            else if(month>=9 && month<=11)
                Console.WriteLine("가을");
            else
                Console.WriteLine("어느 별에서 왔니?");

            month = DateTime.Now.Month;
            switch (month)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("Winter");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("Spring");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Summer");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Autumn");
                    break;
                default:
                    Console.WriteLine("?????????");
                    break;
            }

        }
    }
}
