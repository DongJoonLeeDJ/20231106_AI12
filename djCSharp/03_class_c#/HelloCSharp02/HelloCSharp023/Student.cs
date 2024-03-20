using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCSharp023
{
    //internal 이랑 public이랑 차이가 존재함
    //internal로 써있어서 안 되는 게 public이면 됨
    public class Student
    {
        public string name { get; set; }
        public int grade { get; set; }
    }
}
