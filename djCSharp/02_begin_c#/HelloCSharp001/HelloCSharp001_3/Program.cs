﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCSharp001_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            // rnd.Next(6)  : 0부터5까지의 정수가 나옴
            int num = rnd.Next(6) + 1;//1~6까지 값 나옴
            //switch 적고 tab키 두 번
            switch (num)
            {
                case 1:
                case 2:
                    Console.WriteLine("1 아님 2 나옴");
                    break;
                case 3:
                    Console.WriteLine( "3이 나옴");
                    break;
                case 4: //C#에서는 case 밑에 코드가 1줄이라도 있으면 break;
                    Console.WriteLine("4가 나옴");//java는 break없어도 돌아는 감
                    break;
                case 5:
                case 6:
                    Console.WriteLine("5~6");
                    break;
                default:
                    break;
            }
        }
    }
}
