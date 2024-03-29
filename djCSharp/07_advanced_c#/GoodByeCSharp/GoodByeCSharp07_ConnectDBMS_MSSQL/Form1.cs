using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoodByeCSharp07_ConnectDBMS_MSSQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //DB연결을 보여주기 위해서 Form에다가 바로 DB연결 코드를 쓰고 있지만
        //이건 좋은 코드는 아님... 주차 관리 할 때는 DBHelper, DataManager로 분리예정
        private SqlConnection conn = new SqlConnection();
        private void ConnectDB() //트랜잭션 하기 전에 연결 후 완료 후에 연결끊기
        {//트랜잭션 : insert, update, delete 행동 단위, 하나의 트랜잭션이 insert문 하나 일 수도 있고 insert100개일 수도 있음
            conn.ConnectionString = $"Data Source=({"local"}); " +
                $"Initial Catalog = {"ProjectDataBase"}; Integrated Security = {"SSPI"}; Timeout={3}";
            conn = new SqlConnection(conn.ConnectionString);
            conn.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ConnectDB(); //DBMS에 연결한 것
                SqlCommand cmd = new SqlCommand(); //SQL문 보낼 객체
                cmd.Connection = conn; //어디로 연결할 지 지정
                cmd.CommandText = "select * from testtable"; //전송할 SQL문 작성
                SqlDataAdapter da = new SqlDataAdapter(cmd); //SQL 데이터 처리할 변수
                DataSet ds = new DataSet(); //실제 데이터 저장할 객체
                da.Fill(ds, "mytest"); //da를 통해서 ds에 mytest라는 이름으로 sql 결과문을 넣음
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = ds; 
                dataGridView1.DataMember = "mytest";
            }
            catch (Exception ex)
            {
            }
            finally
            {
                conn.Close(); //java에서는 이 코드를 try catch 감싸야 하기도 함
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
