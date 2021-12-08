using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseFinal
{
    //Inherits Table and gets all column information from SQL server
    public class Staff : Table
    {
        public string type = "Staff";
        public int StaffId { get; set; }
        public int TheaterId { get; set; }
        public int Hours { get; set; }
        public int HourlyPay { get; set; }
        public bool IsRemoved { get; set; }

        //Print string
        public string FullInfo
        {
            get
            {
                return $"{StaffId}: Hours Worked: {Hours} Hourly Pay: ${HourlyPay} Paycheck: ${(Hours*HourlyPay)} Movie Theater: {TheaterId}";
            }
        }
    }
}
