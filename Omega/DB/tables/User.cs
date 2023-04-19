using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omega.DB.tables
{
    public class User
    {
        private int userId;
        private string first_name;
        private string last_name;
        private string username;
        private string email;
        private string password;
        private int roleId;
        private int teamId;

        public User(int userId, string first_name, string last_name, string username, string email, string password, int roleId, int teamId)
        {
            UserId = userId;
            First_name = first_name;
            Last_name = last_name;
            Username = username;
            Email = email;
            Password = password;
            RoleId = roleId;
            TeamId = teamId;
        }

        public User()
        {
            UserId=0;
            Username = null;
            Email = null;
            Password = null;
            RoleId=0;
            TeamId=0;
        }

        public int UserId { get => userId; set => userId = value; }
        public string Username { get => username; set => username = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public int RoleId { get => roleId; set => roleId = value; }
        public int TeamId { get => teamId; set => teamId = value; }
        public string First_name { get => first_name; set => first_name = value; }
        public string Last_name { get => last_name; set => last_name = value; }
    }
}
