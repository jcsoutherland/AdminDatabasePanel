using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseFinal
{
    //Inherits Table and gets all column information from SQL server
    public class Theater : Table
    {
        public string type = "Theater";
        public int TheaterId { get; set; }
        public string Location { get; set; }
        public string Name { get; set; }
        public bool IsRemoved { get; set; }

        //Print string
        public string FullInfo
        {
            get 
            { 
                return $"{TheaterId}: {Name} ({Location}) {IsRemoved}"; 
            }
        }

    }
}
