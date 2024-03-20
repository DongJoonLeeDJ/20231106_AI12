using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloCSharp024
{
    public partial class Form1 : Form
    {
        int answer = 0;
        public Form1()
        {
            InitializeComponent();
            answer = new Random().Next(9) + 1;//1~9중 하나
            Console.WriteLine(answer);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //주의사항 textBox1에 문자를 넣거나 공백이나
            //아무 것도 입력하지 않은 상태로 실행하면 오류남
            int mynum = int.Parse(textBox1.Text);
            if(mynum==answer)
            {
                MessageBox.Show("정답!");
                answer = new Random().Next(9) + 1;
                Console.WriteLine(answer);
            }
            else
            {
                if(mynum>answer)
                    MessageBox.Show("정답보다 더 큰 값임");
                else
                    MessageBox.Show("정답보다 더 작은 값임");
            }
        }

        private void button_Gawi_Click(object sender, EventArgs e)
        {
            int computer = new Random().Next(3);//0,1,2 중 하나 선택
            if(computer==0) //가위
            {
                MessageBox.Show("비김");
            }
            else if(computer==1) //바위
            {
                MessageBox.Show("내가 짐");
            }
            else //보
            {
                MessageBox.Show("내가 이김");
            }
        }

        private void button_Bawi_Click(object sender, EventArgs e)
        {
            int computer = new Random().Next(3);//0,1,2 중 하나 선택
            if (computer == 0) //가위
            {
                MessageBox.Show("내가 이김");
            }
            else if (computer == 1) //바위
            {
                MessageBox.Show("비김");
            }
            else //보
            {
                MessageBox.Show("내가 짐");
            }
        }

        private void button_Bo_Click(object sender, EventArgs e)
        {
            int computer = new Random().Next(3);//0,1,2 중 하나 선택
            if (computer == 0) //가위
            {
                MessageBox.Show("내가 짐");
            }
            else if (computer == 1) //바위
            {
                MessageBox.Show("내가 이김");
            }
            else //보
            {
                MessageBox.Show("비김");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<string> strings = new List<string>();
            strings.Add("안녕");
            strings.Add("반가워");
            strings.Add("Hello");

            label1.Text = strings[new Random().Next(strings.Count)];
        }
    }
}
