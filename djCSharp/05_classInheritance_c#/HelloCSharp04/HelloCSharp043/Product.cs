using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCSharp043
{
    //두 개의 Product를 비교할 때 가격을 기준으로 비교할 수 있게 됨
    public class Product : IComparable<Product>
    {
        public string name { get; set; }
        public int price { get; set; }

        public int CompareTo(Product other)
        {
            return price.CompareTo(other.price);
        }
        public override string ToString() 
        {
            return "제품:" + name + ",가격:" + price;
        }
    }
}
