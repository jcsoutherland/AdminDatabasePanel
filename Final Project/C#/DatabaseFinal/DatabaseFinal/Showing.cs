using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseFinal
{
    public class Showing
    {
        public int ShowingId { get; set; }
        public int TheaterId { get; set; }
        public int MovieId { get; set; }
        public int Attendance { get; set; }
        public DateTime ShowTime { get; set; }
        public DateTime ShowDate { get; set; }

    }
}
