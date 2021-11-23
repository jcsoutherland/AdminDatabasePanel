using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseFinal
{
    public class Tickets
    {
        public int MovieId { get; set; }
        public int TicketPrice { get; set; }
        public int GlobalTicketSales { get; set; }

        public string FullInfo
        {
            get
            {
                return $"Movie Id: {MovieId} | Ticket Price: {TicketPrice} | GlobalTicketSales: {GlobalTicketSales} | Box Office: ${(TicketPrice*GlobalTicketSales)}";
            }
        }

    }
}
