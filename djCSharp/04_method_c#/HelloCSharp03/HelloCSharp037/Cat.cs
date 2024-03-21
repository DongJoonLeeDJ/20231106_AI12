using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCSharp037
{
    public class Cat : Animal
    {
        public void Meow()
        {
            Console.WriteLine("야옹");
        }

        public void Eat() //녹색 줄(=경고)가 뜸, new를 쓰라고 함,new가 자동적용되긴함
        {
            Console.WriteLine("쩝쩝 고양이스럽게 먹는다.");
        }
        public override void Charm() //오버라이딩
        {
            //base.Charm(); //조상 클래스에 있는 Charm
            Console.WriteLine("집사, 잘 했네. 쓰담쓰담");
        }
        public new void cry() //하이딩
        {
            Console.WriteLine("집사 ㅠㅠ 이럴 줄 몰랐어 ㅠㅠㅠㅠㅠ");
        }

    }
}
