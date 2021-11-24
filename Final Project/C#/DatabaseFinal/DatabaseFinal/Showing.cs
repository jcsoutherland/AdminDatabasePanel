using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseFinal
{
    public class Showing : Table
    {
        public string type = "Showing";
        public int ShowingId { get; set; }
        public int TheaterId { get; set; }
        public int MovieId { get; set; }
        public int Attendance { get; set; }
        public TimeSpan ShowTime { get; set; }
        public DateTime ShowDate { get; set; }

        public string FullInfo
        {
            get
            {
                return $"ID: {ShowingId} Attendance: {Attendance} Show Time: {ShowTime} Show Date " + ShowDate.ToShortDateString();
                //return $"ShowDate.ToShortDateString()";
            }
        }

    }
}
