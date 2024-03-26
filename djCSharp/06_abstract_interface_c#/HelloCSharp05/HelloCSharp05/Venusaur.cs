using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCSharp05
{
    public class Venusaur : Ivysaur
    {
        public override void cry()
        {
            Console.WriteLine("꽃꽃 이상해꽃~");
        }
        public override void fight()
        {
            Console.WriteLine("꽃으로 때리면 더 아프다");
        }
        public override void bearFruit()
        {
            Console.WriteLine("최종 진화해도 열매는 없음");
        }
        public override void blooming()
        {
            Console.WriteLine("나무에 가까운 큰 꽃을 피움");
        }
        public override void photosynthesis()
        {
            Console.WriteLine("꽃에 햇빛 영양분을 다 줌");
        }
    }
}
