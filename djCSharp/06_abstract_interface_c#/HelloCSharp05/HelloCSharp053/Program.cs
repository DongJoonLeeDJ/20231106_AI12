using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCSharp053
{
    internal class Program
    {

        //반환형이 없고 매개변수가 Product 한 개인 자료형
        delegate void printProduct(Product p); 

        static void printObject(printProduct pp, Product p, int count)
        {
            for(int i = 0; i < count; i++) 
            {
                pp(p);
            }
        }

        static void myproductinfo(Product p) 
        {
            Console.WriteLine("제품명:"+p.name);
            Console.WriteLine("제품가격:"+p.price);
        }

        static int mypriceCompare(Product a, Product b)
        {
            return a.price.CompareTo(b.price);
        }

        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            products.Add(new Product() { name = "감자", price = 5000 });
            products.Add(new Product() { name = "고구마", price = 100 });
            products.Add(new Product() { name = "당근", price = 2500 });
            //products.Sort(); //배열의 두 요소를 비교하지 못했습니다.
            //앞에선 IComparable이라는 인터페이스를 구현해서 Sort를 함

            //public delegate int Comparison<in T>(T x, T y);
            //Sort(Comparison<Product>) com);

            //products.Sort(delegate (Product a, Product b) { return a.price.CompareTo(b.price); });
            //products.Sort( (a,b)=> { return a.price.CompareTo(b.price); });
            products.Sort(mypriceCompare);

            foreach (var item in products)
                Console.WriteLine(item.name + "," + item.price);

            printObject(myproductinfo, products[0], 5);
            printObject(delegate (Product p)
            {
                Console.WriteLine("이름:" + p.name + "," + p.price + "원");
            }, products[0], 5);
            printObject(p => { Console.WriteLine(p.name + ",\\" + p.price); }, products[0], 5);

            printProduct myp = myproductinfo;
            myp = delegate (Product p)
            {
                Console.WriteLine("이름:" + p.name + "," + p.price + "원");
            };
            myp = p => Console.WriteLine(p.name + ",\\" + p.price+"원");
            printObject(myp, products[0], 3);

        }
    }
}
