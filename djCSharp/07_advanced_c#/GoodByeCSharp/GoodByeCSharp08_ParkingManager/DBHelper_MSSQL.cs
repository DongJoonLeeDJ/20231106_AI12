using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodByeCSharp08_ParkingManager
{
    public class DBHelper_MSSQL : DBHelper
    {
        //DoQuery() // ps 값은 자동으로 "-1"을 대입함
        //DoQuery("123") // ps 값을 "123"을 대입함
        protected override void ConnectDB()
        {
            conn.ConnectionString = $"Data Source=({"local"}); " +
                 $"Initial Catalog = {"ProjectDataBase"}; Integrated Security = {"SSPI"}; Timeout={3}";
            conn.Open();
        }
        public override void DoQuery(string ps = "-1") //select, 전체 or 특정 공간 정보
        {
            try
            {
                ConnectDB();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                if (ps.Equals("-1")) //매개 변수 없는 경우
                    cmd.CommandText = "select * from parkingmanager";
                else
                {
                    cmd.CommandText = "select * from parkingmanager where parkingspot=@parkingspot";
                    cmd.Parameters.AddWithValue("@parkingspot", ps);
                }
                da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds, "parkingManager");
                dt = ds.Tables[0];
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                System.Windows.Forms.MessageBox.Show(ex.StackTrace);
            }
            finally
            {
                conn.Close();
            }
        }

        public override void DoQuery(ParkingCar car, bool isremove)
        {
            throw new NotImplementedException();
        }

    }
}
