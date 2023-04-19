using Microsoft.Data.SqlClient;
using Omega.DB.tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omega.DB.dao
{
    public class UserDAO : IDAO<User>
    {
        private static SqlConnection conn = DatabaseConnection.GetInstance();
        private static SqlTransaction transaction = null;

        public UserDAO()
        {
            transaction = conn.BeginTransaction();
        }
        /// <summary>
        /// fetch all users by team id
        /// </summary>
        /// <param name="id">team id</param>
        /// <returns>users</returns>
        public List<User> SelectByTeamId(int id)
        {
            List<User> users = new List<User>();
            try
            {
                using (SqlCommand command = new SqlCommand("select * from users where team_id = @team_id", conn, transaction))
                {
                    command.Parameters.Add(new SqlParameter("@team_id", id));
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        int userId = reader.GetInt32(0);
                        string first_name = reader.GetString(1);
                        string last_name = reader.GetString(2);
                        string username = reader.GetString(3);
                        string email = reader.GetString(4);
                        string password = reader.GetString(5);
                        int roleId = reader.GetInt32(6);
                        int teamId = reader.GetInt32(7);

                        users.Add(new User(userId, first_name, last_name, username, email, password, roleId, teamId));
                    }
                    reader.Close();
                }
                transaction.Commit();
            }
            catch (SqlException e)
            {
                transaction.Rollback();
                throw e;
            }
            return users;
        }
        /// <summary>
        /// method for loging in
        /// </summary>
        /// <param name="user">username</param>
        /// <param name="pass">password</param>
        /// <returns>user</returns>
        public User CheckLogin(string user, string pass)
        {
            User u = new User();
            try
            {
                using (SqlCommand command = new SqlCommand("SELECT * from users WHERE password = @pass and (username = @user or email = @user)", conn, transaction))
                {
                    command.Parameters.Add(new SqlParameter("@user", user));
                    command.Parameters.Add(new SqlParameter("@pass", pass));
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        int userId = reader.GetInt32(0);
                        string first_name = reader.GetString(1);
                        string last_name = reader.GetString(2);
                        string username = reader.GetString(3);
                        string email = reader.GetString(4);
                        string password = reader.GetString(5);
                        int roleId = reader.GetInt32(6);
                        int teamId = reader.GetInt32(7);

                        u = new User(userId, first_name, last_name, username, email, password, roleId, teamId);
                    }
                    reader.Close();
                }
                transaction.Commit();
            }
            catch (SqlException e)
            {
                transaction.Rollback();
                throw e;
            }
            return u;
        }
        /// <summary>
        /// method for deleting a user
        /// </summary>
        /// <param name="id">user id</param>
        public void Delete(int id)
        {
            try
            {
                using (SqlCommand command = new SqlCommand("DELETE FROM users WHERE id = @id", conn, transaction))
                {
                    command.Parameters.Add(new SqlParameter("@id", id));
                    command.ExecuteNonQuery();
                }
                transaction.Commit();
            }
            catch (SqlException e)
            {
                transaction.Rollback();
                throw e;
            }
        }
        /// <summary>
        /// method for fetching all users
        /// </summary>
        /// <returns>users</returns>
        public List<User> Select()
        {
            List<User> users = new List<User>();
            try
            {
                using (SqlCommand command = new SqlCommand("SELECT * FROM users", conn, transaction))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        int userId = reader.GetInt32(0);
                        string first_name = reader.GetString(1);
                        string last_name = reader.GetString(2);
                        string username = reader.GetString(3);
                        string email = reader.GetString(4);
                        string password = reader.GetString(5);
                        int roleId = reader.GetInt32(6);
                        int teamId = reader.GetInt32(7);

                        users.Add(new User(userId, first_name, last_name, username, email, password, roleId, teamId));
                    }
                    reader.Close();
                }
                transaction.Commit();
            }
            catch (SqlException e)
            {
                transaction.Rollback();
                throw e;
            }
            return users;
        }
        /// <summary>
        /// method for inserting a new user
        /// </summary>
        /// <param name="obj">user</param>
        public void Insert(User obj)
        {
            try
            {
                using (SqlCommand command = new SqlCommand("INSERT INTO users (fist_name, last_name, username, email, password, role_id, team_id) VALUES(@first_name, @last_name, @username, @password, @role_id, @team_id)", conn, transaction))
                {
                    command.Parameters.Add(new SqlParameter("@username", obj.Username));
                    command.Parameters.Add(new SqlParameter("@password", obj.Password));
                    command.ExecuteNonQuery();
                }
                transaction.Commit();
            }
            catch (SqlException e)
            {
                transaction.Rollback();
                throw e;
            }
        }
        /// <summary>
        /// method for updating a user
        /// </summary>
        /// <param name="obj"></param>
        public void Update(User obj)
        {
            try
            {
                using (SqlCommand command = new SqlCommand("UPDATE users SET first_name = @first_name, last_name = @last_name, email = @email, username = @username, password = @password WHERE user_id = @id", conn, transaction))
                {
                    command.Parameters.Add(new SqlParameter("@first_name", obj.First_name));
                    command.Parameters.Add(new SqlParameter("@last_name", obj.Last_name));
                    command.Parameters.Add(new SqlParameter("@username", obj.Username));
                    command.Parameters.Add(new SqlParameter("@email", obj.Email));
                    command.Parameters.Add(new SqlParameter("@password", obj.Password));
                    command.Parameters.Add(new SqlParameter("@id", obj.UserId));
                    command.ExecuteNonQuery();
                }
                transaction.Commit();
            }
            catch (SqlException e)
            {
                transaction.Rollback();
                throw e;
            }
        }
        /// <summary>
        /// method for fetching user by id
        /// </summary>
        /// <param name="id">user id</param>
        /// <returns>user</returns>
        public User GetById(int id)
        {
            User user = null;
            try
            {
                using (SqlCommand command = new SqlCommand("SELECT * FROM users WHERE id = @id", conn, transaction))
                {
                    command.Parameters.Add(new SqlParameter("@id", id));
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        int userId = reader.GetInt32(0);
                        string first_name = reader.GetString(1);
                        string last_name = reader.GetString(2);
                        string username = reader.GetString(3);
                        string email = reader.GetString(4);
                        string password = reader.GetString(5);
                        int roleId = reader.GetInt32(6);
                        int teamId = reader.GetInt32(7);

                        user = new User(userId, first_name, last_name, username, email, password, roleId, teamId);
                    }
                    reader.Close();
                }
                transaction.Commit();
            }
            catch (SqlException e)
            {
                transaction.Rollback();
                throw e;
            }
            return user;
        }
    }
}