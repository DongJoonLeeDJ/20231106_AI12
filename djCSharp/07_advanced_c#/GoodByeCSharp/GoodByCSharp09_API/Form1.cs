using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoodByCSharp09_API
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //JSON 형식이라면 별도의 라이브러리(nuget패키지 활용) 필요
            //XML 형식이라면 별도의 라이브러리가 필요하진 않음
            string url = "https://api.odcloud.kr/api/3082925/v1/uddi:b4759786-c28c-41dd-b600-a9abdbec3ae1?page=1&perPage=10&returnType=JSON&serviceKey=MgX2EIv5i2myv26gGKACE9U5XFuLIi%2BggnKqN8I0BaN4mpFOsHCmqIopmOqpyukSrphm6MrV0aY0Nf4YVB3ceA%3D%3D";
        }
    }
}
