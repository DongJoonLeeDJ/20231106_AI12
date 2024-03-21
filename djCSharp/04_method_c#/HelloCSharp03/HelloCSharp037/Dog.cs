using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCSharp037
{
    public class Dog : Animal //Animal을 상속받음
    {
        public string hairColor { get; set; }
        public void Bark()
        {
            Fight();//Animal을 상속받았으므로 사용 가능
            Console.WriteLine("멍멍 짖는다.");
            //Run(); //Animal 안에서만 호출 됨
        }
        public void Eat() //녹색 줄(=경고)가 뜸, new를 쓰라고 함,new가 자동적용되긴함
        {
            Console.WriteLine("개처럼 먹는다.");
        }
        public override void Charm() //오버라이딩
        {
            base.Charm(); //조상 클래스에 있는 Charm
            Console.WriteLine("주인님 ㅎㅎㅎ");
        }
        public new void cry() //하이딩
        {
            Console.WriteLine("아우우우우우우");
        }

    }
}
