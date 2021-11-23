using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace DatabaseFinal
{
    public class DataAccess
    {
        public List<Theater> GetAllTheaters()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal()))
            {
                return connection.Query<Theater>("select * from Theaters.Theater T order by T.TheaterId").ToList();
            }
        }
    }
}
