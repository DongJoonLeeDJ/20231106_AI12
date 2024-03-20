using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCSharp025
{
    public class Product
    {
        public string name { get; set; }
        public int price { get; set; }

        //접근 제한자 없으면 private이 기본임
        //private은 해당 클래스 안에서만 접근됨
        //즉 다른 클래스에서는 접근이 불가능
        string description { get; set; }
        private int vipPrice { get; set; }

        //vipPrice 접근하려면 아래와 같은 메서드 필요함
        public void setVipPrice(int vipPrice)
        {
            this.vipPrice = vipPrice;
        }
        public int getVipPrice()
        {
            return vipPrice;
        }


        //생성자 : new  키워드와 함께 쓰이고
        //메모리를 할당하는 시점에 뭘 할지 정해주는 것
        //생성자를 적지 않아도
        //아래와 같이 아무 것도 없는 생성자가
        //자동으로 생성됨
        //public Product()
        //{
        //}
        //생성자를 내가 명시하는 그 순간
        //암묵적으로 만들어졌던 빈 생성자가 없어짐

        //생성자는 웬만하면 앞에 public이 붙음
        public Product(string name, int price)
        {
            this.name = name;
            this.price = price;
        }
        //생성자 역시도 오버로딩이 가능함
        public Product(string name)
        {
            this.name = name;
            Console.WriteLine("아직 가격은 몰라요");
        }
        //매개변수 없는 생성자를 쓰고 싶다면
        //내가 이렇게 만들어야 함
        //public Product()
        //{
        //    Console.WriteLine("일단 제품만 만듦");
        //}
    }
}
