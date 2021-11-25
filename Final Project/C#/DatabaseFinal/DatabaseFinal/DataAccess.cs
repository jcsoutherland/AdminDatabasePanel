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
                return (List<T>)Convert.ChangeType(connection.Query<T>($"select * from Theaters.{name} where Theaters.{name}.IsRemoved = 0").ToList(), typeof(List<T>));
            }
        }

        public List<T> GetWhere<T>(string name, string column, string w)
        {
            if(column == "*")
            {
                return GetTableContents<T>(name);
            }
            if(column == "IsRemoved")
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal()))
                {
                    return (List<T>)Convert.ChangeType(connection.Query<T>($"select * from Theaters.{name} T where T.{column} {w}").ToList(), typeof(List<T>));
                }
            }
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal()))
            {
                return (List<T>)Convert.ChangeType(connection.Query<T>($"select * from Theaters.{name} T where T.{column} {w} and T.IsRemoved = 0").ToList(), typeof(List<T>));
            }
        }

        public List<T> GetCustomQuery<T>(string query)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal()))
            {
                return (List<T>)Convert.ChangeType(connection.Query<T>(query).ToList(), typeof(List<T>));
            }
        }

        public void DeleteRow(string name, string cmd)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal()))
            {
                connection.Query($"Update Theaters.{name} SET [IsRemoved]=1 {cmd}");
            }
        }
        public void RecoverRow(string name, string cmd)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal()))
            {
                connection.Query($"Update Theaters.{name} SET [IsRemoved]=0 {cmd}");
            }
        }

        public void InsertIntoTable(string name, string cmd, string columns)
        {
            if(columns == "")
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal()))
                {
                    connection.Query($"Insert Into Theaters.{name} Values({cmd});");
                }
            }
            else
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal()))
                {
                    connection.Query($"Insert Into Theaters.{name}({columns}) Values({cmd})");
                }
            }
        }

        public void UpdateTable(string name, string cmd, string columns)
        {
            if(cmd == "")
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal()))
                {
                    connection.Query($"Update Theaters.{name} Set {columns}");
                }
            }
            else
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal()))
                {
                    connection.Query($"Update Theaters.{name} Set {columns} {cmd}");
                }
            }
        }
    }
}
