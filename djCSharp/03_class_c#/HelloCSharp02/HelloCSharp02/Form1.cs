using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloCSharp02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //프로그램 시작하자마자 label1과 label2에 있는 텍스트를 지움
            label1.Text = "";
            label2.Text = ""; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = textBox_test.Text;
            int[] lotto = new int[6];
            Random r = new Random();
            for(int i = 0; i<lotto.Length; i++)
            {
                int num = r.Next(45)+1; //1~45까지의 값
                if(lotto.Contains(num)) //num이 lotto안에 이미 있는 경우
                {
                    i--;
                    continue;
                }
                lotto[i] = num;
            }
            int bns = r.Next(45) + 1;
            while(lotto.Contains(bns))
                bns = r.Next(45) + 1;
            Array.Sort(lotto); //오름 차순 정렬
            label2.Text = string.Join(",", lotto);
            label2.Text += " 보너스 번호 : " + bns;
        }

        //버튼 클릭시 디자인 창에서는 없었던
        //텍스트 박스 하나가 새로 생기게 됨
        private void button2_Click(object sender, EventArgs e)
        {
            TextBox temp = new TextBox();
            temp.Text = "임시 텍스트 박스";
            temp.Location = new Point(100, 100);
            Controls.Add(temp);
        }
    }
}
