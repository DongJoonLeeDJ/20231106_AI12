using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCSharp045
{

    //datagridview 바인딩 하기 전 반드시 해야할 것 (둘 중 하나)
    //1. 한 번 실행을 하고 나서 바인딩한다.
    //2. 빌드->솔루션 정리, 솔루션 빌드, 솔루션 다시 빌드 누르고 바인딩한다.
    public class Student
    {
        public string hakbeon { get; set; } //이거 2개만 데이터그리드뷰에 나옴
        public string name { get; set; } //이거 2개만 데이터그리드뷰에 나옴

        public int age; //이건 datagridview에 안 나옴!!!!
    }
}
