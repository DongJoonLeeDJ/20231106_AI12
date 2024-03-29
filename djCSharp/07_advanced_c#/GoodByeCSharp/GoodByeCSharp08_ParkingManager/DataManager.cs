using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodByeCSharp08_ParkingManager
{
    public class DataManager
    {
        public static List<ParkingCar> Cars = new List<ParkingCar>();
        private static DBHelper_MSSQL mssql = DBHelper_MSSQL.getIntance; //싱글톤

        public static void Load() //전체 불러오기
        {

        }
        //contents = 로그(=기록)남길 때 쓸 것임
        public static void Save(string cmd, string ps, out string contents) //주차 공간 추가 삭제용 Save
        {

        }
        public static void Save() //주차 출차용
        {

        }
    }
}
