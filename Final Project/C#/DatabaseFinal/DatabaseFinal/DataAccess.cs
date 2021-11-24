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
        public List<T> GetTableContents<T>(string name)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal()))
            {
                return (List<T>)Convert.ChangeType(connection.Query<T>($"select * from Theaters.{name}").ToList(), typeof(List<T>));
            }
        }

        public List<T> GetWhere<T>(string name, string column, string w)
        {
            if(column == "*")
            {
                return GetTableContents<T>(name);
            }
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal()))
            {
                return (List<T>)Convert.ChangeType(connection.Query<T>($"select * from Theaters.{name} T where T.{column} {w}").ToList(), typeof(List<T>));
            }
        }

        public List<T> GetCustomQuery<T>(string query)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal()))
            {
                return (List<T>)Convert.ChangeType(connection.Query<T>(query).ToList(), typeof(List<T>));
            }
        }
    }
}
