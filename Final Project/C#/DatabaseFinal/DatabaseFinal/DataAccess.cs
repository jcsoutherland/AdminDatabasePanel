using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace DatabaseFinal
{
    //All access methods for data in the SQL server using Dapper
    public class DataAccess
    {
        //Asks the SQL database for the contents of the given table
        public List<T> GetTableContents<T>(string name)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal()))
            {
                return (List<T>)Convert.ChangeType(connection.Query<T>($"select * from Theaters.{name} where Theaters.{name}.IsRemoved = 0").ToList(), typeof(List<T>));
            }
        }

        //Asks SQL database for results given the users "Where" statements.
        public List<T> GetWhere<T>(string name, string column, string w)
        {
            //AllInfo column
            if(column == "*")
            {
                return GetTableContents<T>(name);
            }
            //Soft delete column
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

        //Sends custom query to SQL database and returns the result
        public List<T> GetCustomQuery<T>(string query)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal()))
            {
                return (List<T>)Convert.ChangeType(connection.Query<T>(query).ToList(), typeof(List<T>));
            }
        }
        
        //Requests to delete a row in a given table in the SQL database
        public void DeleteRow(string name, string cmd)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal()))
            {
                connection.Query($"Update Theaters.{name} SET [IsRemoved]=1 Where {cmd}");
            }
        }

        //Requests to recover a deleted row in a given table in the SQL database
        public void RecoverRow(string name, string cmd)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal()))
            {
                connection.Query($"Update Theaters.{name} SET [IsRemoved]=0 Where {cmd}");
            }
        }
        
        //Sends insert statement given by user to SQL database
        public void InsertIntoTable(string name, string cmd, string columns)
        {
            //All columns
            if(columns == "")
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal()))
                {
                    connection.Query($"Insert Into Theaters.{name} Values({cmd});");
                }
            }
            //Some columns
            else
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal()))
                {
                    connection.Query($"Insert Into Theaters.{name}({columns}) Values({cmd})");
                }
            }
        }

        //Sends update statement given by user to SQL database
        public void UpdateTable(string name, string cmd, string columns)
        {
            //All columns
            if(cmd == "")
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal()))
                {
                    connection.Query($"Update Theaters.{name} Set {columns}");
                }
            }
            //Some columns
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
