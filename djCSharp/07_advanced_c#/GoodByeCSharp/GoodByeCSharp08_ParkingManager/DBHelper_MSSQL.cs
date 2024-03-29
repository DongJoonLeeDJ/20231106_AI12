using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodByeCSharp08_ParkingManager
{
    public class DBHelper_MSSQL : DBHelper
    {
        public override void DoQuery(string ps = "-1")
        {
            throw new NotImplementedException();
        }

        public override void DoQuery(ParkingCar car, bool isremove)
        {
            throw new NotImplementedException();
        }

        protected override void ConnectDB()
        {
            throw new NotImplementedException();
        }
    }
}
