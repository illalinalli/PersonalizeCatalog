using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    static class Utils
    {
        public static bool ContainsValue(this List<DataRow> Users, string login, string password)
        {

            if (Users.Any(dataRow => dataRow["login"].Equals(login)) && Users.Any(dataRow => dataRow["password"].Equals(password)))
            {
                return true;
            }
            return false;
        }
    }
}
