using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloCSharp035
{
    public partial class Form1 : Form
    {
        int mytime = 0; //현재 경과 시간
        const int LIMIT = 10; //제한 시간
        int answer = 0; //정답
        public Form1()
        {
            InitializeComponent();
            label1.Text = "";
            answer = new Random().Next(9) + 1;//1~9 중 하나 맞추기
            Console.WriteLine(answer);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            mytime++;
            if (mytime >= LIMIT)
                label1.Text = "TimeOver";
            else
                label1.Text = mytime +"/" +LIMIT+"초 경과";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int mynum = int.Parse(textBox1.Text);
            if(mynum==answer)
            {
                label1.Text = "정답!";
                timer1.Enabled = false; //타이머 1 중단
            }
        }
    }
}
