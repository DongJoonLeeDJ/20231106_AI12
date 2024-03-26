using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCSharp055
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = new List<int>() { 1, 2, 3, 4, 5 };

            //만약 짝수만 가져오고 싶다면?
            List<int> evenNum = new List<int>();
            foreach (var item in nums)
            {
                if (item % 2 == 0)
                    evenNum.Add(item);
            }
            //LINQ = 컬렉션(=배열이나 List)에 있는 값을 SQL 형식으로 가져오는 문법
            // from 요소이름(=임의변수이름) in 컬렉션명 where 조건 select 가져올 값;
            var eventNum2 = from a in nums where a % 2 == 0 select a;

            foreach (var item in evenNum)
                Console.WriteLine(item);
            foreach (var item in eventNum2)
                Console.WriteLine(item);

            List<int> powerNum = new List<int>();
            foreach (var item in nums)
                powerNum.Add(item * item);
            foreach (var item in powerNum)
                Console.WriteLine(item);

            var powerNum2 = from aa in nums select aa * aa;
            foreach (var item in powerNum2)
                Console.WriteLine(item);

            List<int> myeven = evenNum.ToList();
            List<int> mypower = powerNum2.ToList();

            List<int> oddNum = (from item in nums where item % 2 != 0 select item).ToList<int>();
            foreach (var item in oddNum)
                Console.WriteLine(item);

            //익명 객체
            var powerEvenOutput = from item in nums
                                  where item % 2 == 0
                                  select new
                                  {
                                      num = item,
                                      doubleNum = item * 2,
                                      powerNum = item * item
                                    };
            foreach(var item in powerEvenOutput)
            {
                Console.WriteLine(item.num+","+item.doubleNum+","+item.powerNum);
            }

            
            
            List<Product> products = new List<Product>();
            products.Add(new Product() { name = "고구마", price = 5000 });
            products.Add(new Product() { name = "마", price = 2500 });
            products.Add(new Product() { name = "당근", price = 9000 });
            products.Add(new Product() { name = "파", price = 500 });
            products.Add(new Product() { name = "감자", price = 5500 });

            //LINQ의 장단점
            //장점 : for와 if없이 쉽게 값을 뽑아낼 수 있다.
            //단점 : 이 코드들이 모두 1줄로 간주되기 때문에 오류가 생기면 디버깅하기가 너무 힘들다.
            var myproducts = from item in products
                             where item.price > 5000
                             orderby item.name ascending
                             select item;
            List<Product> vipProducts = (from item in products
                                        where item.price > 5000
                                        orderby item.name ascending
                                        select item).ToList<Product>();
            foreach(var item in myproducts)
                Console.WriteLine(item.ToString());
            foreach(var item in vipProducts)
                Console.WriteLine(item.ToString());
            foreach(Product item in myproducts)
                Console.WriteLine(item.ToString());
            foreach (Product item in vipProducts)
                Console.WriteLine(item.ToString());


        }
    }
}
