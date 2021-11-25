using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseFinal
{
    public class Staff : Table
    {
        public string type = "Staff";
        public int StaffId { get; set; }
        public int TheaterId { get; set; }
        public int Hours { get; set; }
        public int HourlyPay { get; set; }
        public bool IsRemoved { get; set; }

        public string FullInfo
        {
            get
            {
                return $"{StaffId}: Hours Worked: {Hours} Hourly Pay: ${HourlyPay} Paycheck: ${(Hours*HourlyPay)}  {IsRemoved}";
            }
        }
    }
}
