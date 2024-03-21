using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCSharp037
{
    //Food만으론 인스턴스 못 만듦
    //추상화 = 구체화를 못 한다 = 인스턴스 못 만든다.
    //Food f = new Food(); // <- 이거 안 됨!!!
    public abstract class Food //추상화된 클래스
    {
        public string name { get; set; }
        public int price { get; set; }

        public abstract void taste();//시식을 추상화
        //Food를 상속받은 클래스에서 이 메서드를 구체화해야 함
        //음식마다 시식하는 방법은 다 다르기 때문이다.

    }
}
