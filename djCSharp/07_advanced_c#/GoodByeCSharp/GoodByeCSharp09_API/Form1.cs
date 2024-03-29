using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoodByeCSharp09_API
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //dataGridView1.Columns.AddRange("상호명", "소재지도로명주소");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //xml도 기상청에서 이미 해봤고, 승인받고 가져다 쓰는 방식은 유사하다
            //xml은 태그 형태에 따라서 코드가 좀 달라질 수 있다.
            string url = "https://api.odcloud.kr/api/3082925/v1/uddi:b4759786-c28c-41dd-b600-a9abdbec3ae1?page=1&perPage=10&returnType=JSON&serviceKey=MgX2EIv5i2myv26gGKACE9U5XFuLIi%2BggnKqN8I0BaN4mpFOsHCmqIopmOqpyukSrphm6MrV0aY0Nf4YVB3ceA%3D%3D";
            WebClient wc = new WebClient();
            wc.Encoding = Encoding.UTF8;
            var json = wc.DownloadString(url);
            var jArray = JObject.Parse(json);
            var jData = jArray["data"];

            dataGridView1.Rows.Clear();
            foreach( var item in jData ) 
            {
                dataGridView1.Rows.Add(item["상호명"].ToString(), item["소재지도로명주소"]);
            }


        }
    }
}
