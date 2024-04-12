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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Quality : Form
    {
        public Quality()
        {
            InitializeComponent();
        }
        string connectionString = $"Data Source=({"local"});"
                                    + $"Initial Catalog = {"ProductDataProject"}; Integrated Security = {"SSPI"}; Timeout={3}";

        private void Form_Load(object sender, EventArgs e)
        {
            LoadComboBoxData();
        }
        private void LoadComboBoxData()
        {
            string[] dates = { "2022-01-08", "2022-01-18", "2022-01-19", "2022-01-20", "2022-02-10","2022-02-11", "2022-02-17", "2022-02-18", "2022-02-23", "2022-02-24",
                               "2022-02-25", "2022-03-02", "2022-03-03", "2022-03-04", "2022-03-07","2022-03-08", "2022-03-17", "2022-03-18", "2022-03-21", "2022-03-22",
                               "2022-03-23", "2022-03-24", "2022-03-25", "2022-04-01", "2022-04-04","2022-04-05", "2022-04-06", "2022-04-07", "2022-04-08", "2022-04-11",
                               "2022-04-12", "2022-04-13", "2022-04-14", "2022-04-15", "2022-04-18","2022-04-19", "2022-04-29", "2022-05-02", "2022-05-03", "2022-05-04",
                               "2022-05-09", "2022-05-10", "2022-05-11", "2022-05-12", "2022-05-13","2022-05-16", "2022-05-17", "2022-05-31", "2022-06-03", "2022-06-07",
                               "2022-06-08", "2022-06-09", "2022-06-10", "2022-06-13", "2022-06-14","2022-06-15", "2022-06-16", "2022-06-17", "2022-06-20", "2022-06-21",
                               "2022-06-22", "2022-06-23", "2022-06-24", "2022-06-27", "2022-06-28","2022-06-29", "2022-06-30", "2022-07-01", "2022-07-04", "2022-07-05",
                               "2022-07-06", "2022-07-07", "2022-07-08", "2022-07-11", "2022-07-25","2022-07-26", "2022-07-27", "2022-07-28", "2022-07-29", "2022-08-03" };

            comboBox1.Items.AddRange(dates);
        }

       
        private void LoadDataForSelectedDate(string selectedDate)
        {
            string query = "SELECT TRIM(PageNo) AS PageNo, TRIM(Speed) AS Speed, TRIM(Length) AS Length, TRIM(RealPower) AS RealPower, TRIM(SetFrequency) AS SetFrequency,"
                                + " TRIM(SetDuty) AS SetDuty, TRIM(SetPower) AS SetPower, TRIM(GateOnTime) AS GateOnTime, TRIM(SUBSTRING(WorkingTime, 1, 11)) AS WorkingTime FROM ProductData"
                                + " WHERE CONVERT(date, WorkingTime) = @SelectedDate";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@SelectedDate", selectedDate);

                connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;

                connection.Close();
            }
        }
        private void LoadDataForSelectedDateFine(string selectedDate2)
        {
            string query2 = "SELECT TRIM(PageNo) AS PageNo, TRIM(Speed) AS Speed, TRIM(Length) AS Length, TRIM(RealPower) AS RealPower, TRIM(SetFrequency) AS SetFrequency,"
                                + " TRIM(SetDuty) AS SetDuty, TRIM(SetPower) AS SetPower, TRIM(GateOnTime) AS GateOnTime, TRIM(SUBSTRING(WorkingTime, 1, 11)) AS WorkingTime FROM ProductData"
                                + " WHERE CONVERT(date, WorkingTime) = @SelectedDate"
                                + " and RealPower BETWEEN 1650 AND 1750 OR RealPower BETWEEN 670 AND 720";

            using (SqlConnection connection2 = new SqlConnection(connectionString))
            {

                SqlCommand command2 = new SqlCommand(query2, connection2);

                command2.Parameters.AddWithValue("@SelectedDate", selectedDate2);

                connection2.Open();

                SqlDataAdapter adapter2 = new SqlDataAdapter(command2);
                DataTable dataTable2 = new DataTable();
                adapter2.Fill(dataTable2);

                dataGridView2.DataSource = dataTable2;

                connection2.Close();
            }


        }
        private void LoadDataForSelectedDateError(string selectedDate2)
        {
            string query2 = "SELECT TRIM(PageNo) AS PageNo, TRIM(Speed) AS Speed, TRIM(Length) AS Length, TRIM(RealPower) AS RealPower, TRIM(SetFrequency) AS SetFrequency,"
                                + " TRIM(SetDuty) AS SetDuty, TRIM(SetPower) AS SetPower, TRIM(GateOnTime) AS GateOnTime, TRIM(SUBSTRING(WorkingTime, 1, 11)) AS WorkingTime FROM ProductData"
                                + " WHERE CONVERT(date, WorkingTime) = @SelectedDate"
                                + " and ([RealPower] < 1650 OR [RealPower] > 1750) AND ([RealPower] < 670 OR [RealPower] > 720)";

            using (SqlConnection connection2 = new SqlConnection(connectionString))
            {

                SqlCommand command2 = new SqlCommand(query2, connection2);

                command2.Parameters.AddWithValue("@SelectedDate", selectedDate2);

                connection2.Open();

                SqlDataAdapter adapter2 = new SqlDataAdapter(command2);
                DataTable dataTable2 = new DataTable();
                adapter2.Fill(dataTable2);

                dataGridView2.DataSource = dataTable2;

               
                
                
                
                connection2.Close();
            }


        }
        private void all_button_Click(object sender, EventArgs e)
        {
            string selectedDate = comboBox1.SelectedItem.ToString();
            LoadDataForSelectedDate(selectedDate);

        }

        private void fine_button_Click(object sender, EventArgs e)
        {
            string selectedDate2 = comboBox1.SelectedItem.ToString();
            LoadDataForSelectedDateFine(selectedDate2);
        }

        private void error_button_Click(object sender, EventArgs e)
        {
            string selectedDate3 = comboBox1.SelectedItem.ToString();
            LoadDataForSelectedDateError(selectedDate3);
        }

        private void LoadDataForSelectedDatechart(string selectedDate4)
        {
            string query6 = "delete from fine_table";

            using (SqlConnection connection6 = new SqlConnection(connectionString))
            {

                SqlCommand command6 = new SqlCommand(query6, connection6);

                command6.Parameters.AddWithValue("@SelectedDate", selectedDate4);

                connection6.Open();

                SqlDataAdapter adapter6 = new SqlDataAdapter(command6);
                DataTable dataTable6 = new DataTable();
                adapter6.Fill(dataTable6);

                

                connection6.Close();

            }

            string query4 = "INSERT INTO fine_table([PageNo],[Speed],[Length],[RealPower],[SetFrequency],[SetDuty],[SetPower],[GateOnTime],[WorkingTime] )SELECT [PageNo],[Speed],[Length],[RealPower],[SetFrequency],[SetDuty],[SetPower],[GateOnTime],[WorkingTime] FROM ProductData WHERE CONVERT(date, WorkingTime) = @SelectedDate and RealPower BETWEEN 1650 AND 1750 OR RealPower BETWEEN 670 AND 720";

            using (SqlConnection connection4 = new SqlConnection(connectionString))
            {

                SqlCommand command4 = new SqlCommand(query4, connection4);

                command4.Parameters.AddWithValue("@SelectedDate", selectedDate4);

                connection4.Open();

                SqlDataAdapter adapter4 = new SqlDataAdapter(command4);
                DataTable dataTable4 = new DataTable();
                adapter4.Fill(dataTable4);

              

                connection4.Close();

            }
            //string query5 = " select count(*) from fine_table"; 
            string query5 = "select count(*) 양품, (select count(*) from ProductData)-count(*) 불량품, (select count(*) from ProductData) 전체개수 from fine_table";

            using (SqlConnection connection5 = new SqlConnection(connectionString))
            {

                SqlCommand command5 = new SqlCommand(query5, connection5);

                //command5.Parameters.AddWithValue("@SelectedDate", selectedDate4);

                connection5.Open();

                SqlDataAdapter adapter5 = new SqlDataAdapter(command5);
                DataTable dataTable5 = new DataTable();
                adapter5.Fill(dataTable5);

                dataGridView2.DataSource = dataTable5;

                connection5.Close();
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selectedDate4 = comboBox1.SelectedItem.ToString();
            LoadDataForSelectedDatechart(selectedDate4);

            string good = dataGridView2.Rows[0].Cells[0].Value.ToString(); //셀에 있는 값을 읽어옴
            string bad = dataGridView2.Rows[0].Cells[1].Value.ToString(); //셀에 있는 값을 읽어옴
            chart1.Series[0].Points.Clear(); //값들 모두 제거

            chart1.Series[0].Points.Add(new double[] {double.Parse(good) });
            chart1.Series[0].Points.Add(new double[] { double.Parse(bad) });
            chart1.Series[0].Points[0].LegendText = "양품 개수";
            chart1.Series[0].Points[1].LegendText = "불량품 개수";



        }
    }
}


