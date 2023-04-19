using Microsoft.Data.SqlClient;
using Omega.DB.tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omega.DB.dao
{
    public class RoleDAO : IDAO<Role>
    {
        private static SqlConnection conn = DatabaseConnection.GetInstance();
        private static SqlTransaction transaction = null;

        public RoleDAO()
        {
            transaction = conn.BeginTransaction();
        }
        /// <summary>
        /// method for deleting a role
        /// </summary>
        /// <param name="id"></param>
        public void Delete(int id)
        {
            try
            {
                using (SqlCommand command = new SqlCommand("DELETE FROM roles WHERE id = @id", conn, transaction))
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
        /// method for fetching all roles
        /// </summary>
        /// <returns></returns>
        public List<Role> Select()
        {
            List<Role> roles = new List<Role>();
            try
            {
                using (SqlCommand command = new SqlCommand("SELECT * FROM roles", conn, transaction))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string name = reader.GetString(1);

                        roles.Add(new Role(id, name));
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
            return roles;
        }
        /// <summary>
        /// method for inserting role
        /// </summary>
        /// <param name="obj">role</param>
        public void Insert(Role obj)
        {
            try
            {
                using (SqlCommand command = new SqlCommand("INSERT INTO roles (name) VALUES(@name)", conn, transaction))
                {
                    command.Parameters.Add(new SqlParameter("@name", obj.Name));
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
        /// method for updating roles
        /// </summary>
        /// <param name="obj">role</param>
        public void Update(Role obj)
        {
            try
            {
                using (SqlCommand command = new SqlCommand("UPDATE roles SET name = @name WHERE id = @id", conn, transaction))
                {
                    command.Parameters.Add(new SqlParameter("@name", obj.Name));
                    command.Parameters.Add(new SqlParameter("@id", obj.RoleId));
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
        /// method for getting a role by id
        /// </summary>
        /// <param name="id">id of the role</param>
        /// <returns>role</returns>
        public Role GetById(int id)
        {
            try
            {
                using (SqlCommand command = new SqlCommand("SELECT * FROM roles WHERE id = @id", conn, transaction))
                {
                    command.Parameters.Add(new SqlParameter("@id", id));
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        int role_id = reader.GetInt32(0);
                        string name = reader.GetString(1);

                        return new Role(role_id, name);
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
            return null;
        }
    }
}
