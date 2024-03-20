using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCSharp025
{
    public class Rectangle //사각형
    {
        public int width { get; set; }//각 사각형마다
        public int height { get; set; }//너비,높이다름
        public static string color { get; set; }//모두 색깔은 같다고 가정하자

        //getArea : 인스턴스 메서드, 인스턴스 메서드이므로
        //각 인스턴스마다 결과가 다를 수 있음
        public int getArea() { return width*height; }//자신의 넓이

        //일반적인 사각형의 넓이 구해주는 메서드
        //클래스 메서드이므로 매개변수에 따라서 결과가 변함
        public static int calcRecArea(int w, int h) { return w*h; }
    }
}
