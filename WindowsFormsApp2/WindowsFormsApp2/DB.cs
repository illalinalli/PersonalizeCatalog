using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using static WindowsFormsApp2.Utils;

namespace WindowsFormsApp2
{
    class DB
    {

        //private static readonly IDbConnection Database = new SQLiteConnection(LoadConnectionString());

        //private static string LoadConnectionString(string id = "Default")
        //{
        //    return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        //}

        //public static void LoadUsers()
        //{
        //    using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
        //    {
        //        //var dt = new DataTable();
        //        //var command = new SQLiteCommand("SELECT * FROM Users", (SQLiteConnection)Database);
        //        //var adapter = new SQLiteDataAdapter(command);
        //        //adapter.Fill(dt);

        //    }
        //}

      
        //public static void InsertDB_user(User user)
        //{
        //    using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
        //    {
        //        connection.Execute("INSERT INTO Users (username, login, password) values (@username, @login, @password)", user);
        //    }
        //}

        ////public bool CheckUsers(string login, string password)
        ////{
        ////    var dt = new DataTable();
            
        ////    var command = new SQLiteCommand("SELECT * FROM Users", (SQLiteConnection)Database);
        ////    var adapter = new SQLiteDataAdapter(command);
        ////    adapter.Fill(dt);
        ////    var Users = dt.AsEnumerable().ToList<DataRow>();
            
        ////    return Utils.ContainsValue(Users, login, password);
        ////}
       
    }
}
