using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCSharp022
{
    public class Product //internal을 public으로 바꾸기
    {
        //{ get; set; } = java의 Getter/Setter와 같은 것
        //Getter/Setter를 축약한 것
        //name,price : 인스턴스 변수, 인스턴스 별로 값이 다름
        //countOfProduct : 클래스 변수, 클래스 공통 값
        public string name { get; set; }
        public int price { get; set; }
        public static int countOfProduct = 0;

        //public Product() {} // 이렇게 아무 것도 없는 생성자가 암묵적으로 있음
        //public Product() //생성자
        //{
        //    countOfProduct++;
        //}
    }
}
