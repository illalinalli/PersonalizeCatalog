using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class User
    {
        public int id;
        public string username;
        public string login;
        public string password;
        private Stack<int> getId;
        //public User(string username, string login, string password)
        //{

        //    Username = username;
        //    Login = login;
        //    Password = password;
        //}

        public int Id { get => id; set => id = value; }
        public string Username { get => username; set => username = value; }
        public string Login { get => login; set => login = value; }
        public string Password { get => password; set => password = value; }
        public Stack<int> GetId { get => getId; set => getId = value; }

        internal static object FindFirstValue(string nameIdentifier)
        {
            throw new NotImplementedException();
        }


    }
}
