using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoodByeCSharp08_ParkingManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            if(DataManager.Cars.Count > 0) //Count가 0이하인 데 중괄호 안에 코드 실행하면
            {                                                   //켜지자 마자 꺼지거나 혹은 셀 클릭할 때 마다 오류남
                dataGridView1.DataSource = DataManager.Cars;
                textBox1.Text = DataManager.Cars[0].parkingSpot;
                textBox2.Text = DataManager.Cars[0].carNumber;
                textBox3.Text = DataManager.Cars[0].driverName;
                textBox4.Text = DataManager.Cars[0].phoneNumber;
                textBox5.Text = textBox1.Text;
            }
        }

        private void writeLog(string contents)
        {
            DataManager.printLog(contents);
            string log = $"[{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff")}]";
            log += contents;
            listBox1.Items.Insert(0, log); //최신 내용이 맨 위에 올라감
            //listBox1.Items.Add(contents); //최신 내용이 맨 아래로 내려감
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //writeLog("버튼 1 클릭(주차)");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //writeLog("버튼 2 클릭(출차)");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //조회
        }

        private void managingSpot(string parkingSpot, string cmd)//주차 공간 추가 or 삭제
        {
            parkingSpot = parkingSpot.Trim(); //공백 제거
            string contents = "";
            //bool check = DataManager.Save(cmd,parkingSpot, out contents);
            if (DataManager.Save(cmd, parkingSpot, out contents)) //추가든 삭제든 성공
                button6.PerformClick(); //전체 조회
            MessageBox.Show(contents);
            writeLog(contents);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //주차공간 추가
            managingSpot(textBox5.Text, "insert");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //주차공간 삭제
            managingSpot(textBox5.Text, "delete");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //전체조회
            DataManager.Load();
            dataGridView1.DataSource = null;
            if (DataManager.Cars.Count > 0)
                dataGridView1.DataSource = DataManager.Cars;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
