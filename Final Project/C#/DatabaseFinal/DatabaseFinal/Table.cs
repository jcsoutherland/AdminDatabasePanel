using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseFinal
{
    public class Table
    {
        //Gets all property names from a table
        public List<string> GetPropertyNames()
        {
            Type type = this.GetType();
            System.Reflection.PropertyInfo[] props = type.GetProperties();
            List<string> str = new List<string>();
            foreach (var prop in props)
            {
                str.Add(prop.Name);
            }
            return str;
        }
        //Gets all property types
        public List<string> GetPropTypes()
        {
            Type type = this.GetType();
            System.Reflection.PropertyInfo[] props = type.GetProperties();
            List<string> str = new List<string>();
            foreach(var prop in props)
            {
                str.Add(prop.PropertyType.ToString());
            }
            return str;
        }
    }
}
