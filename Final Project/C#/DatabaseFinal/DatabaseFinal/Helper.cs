using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseFinal
{
    public static class Helper
    {
        public static string CnnVal()
        {
            //not sure how to make a connection string for any local server yet
            return @"Data Source=DESKTOP-PBCL2JN\MSSQLLOCALDB;Initial Catalog=MovieTheaters;Trusted_Connection=true;";
        }
    }
}
