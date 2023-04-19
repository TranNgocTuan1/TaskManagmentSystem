using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using Omega.DB.tables;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omega.DB.dao
{
    public class TaskDAO : IDAO<Tasks>
    {
        private static SqlConnection conn = DatabaseConnection.GetInstance();
        private static SqlTransaction transaction = null;

        public TaskDAO()
        {
            transaction = conn.BeginTransaction();
        }
        /// <summary>
        /// method for fetching how many task a user has by their status
        /// </summary>
        /// <param name="obj">user</param>
        /// <param name="stat">status</param>
        /// <returns>number of tasks</returns>
        public int SelectTaskCount(User obj, string stat)
        {
            int number = 0;
            try
            {
                using (SqlCommand command = new SqlCommand("SELECT count(*) FROM tasks where status = @status and user_id = @id", conn, transaction))
                {
                    command.Parameters.Add(new SqlParameter("@id", obj.UserId));
                    command.Parameters.Add(new SqlParameter("@status", stat));
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        number = reader.GetInt32(0);
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
            return number;
        }
        /// <summary>
        /// method for deleting a task
        /// </summary>
        /// <param name="id">id of the task</param>
        public void Delete(int id)
        {
            try
            {
                using (SqlCommand command = new SqlCommand("DELETE FROM tasks WHERE task_id = @id", conn, transaction))
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
        /// fetching tasks by user
        /// </summary>
        /// <param name="obj">user</param>
        /// <param name="stat">status of the task</param>
        /// <returns>tasks</returns>
        public List<Tasks> SelectTasksByUser(User obj, string stat)
        {
            List<Tasks> tasks = new List<Tasks>();
            try
            {
                using (SqlCommand command = new SqlCommand("SELECT * FROM tasks where status = @status and user_id = @id", conn, transaction))
                {
                    command.Parameters.Add(new SqlParameter("@id", obj.UserId));
                    command.Parameters.Add(new SqlParameter("@status", stat));
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        int task_id = reader.GetInt32(0);
                        string name = reader.GetString(1);
                        string description = reader.GetString(2);
                        DateTime deadline = reader.GetDateTime(3);
                        string status = reader.GetString(4);
                        int user_id = reader.GetInt32(5);
                        int project_id = reader.GetInt32(6);
                        tasks.Add(new Tasks(task_id, name, description, deadline, status, user_id, project_id));
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
            return tasks;
        }
        /// <summary>
        /// method for selecting all tasks
        /// </summary>
        /// <returns>tasks</returns>
        public List<Tasks> Select()
        {
            List<Tasks> tasks = new List<Tasks>();
            try
            {
                using (SqlCommand command = new SqlCommand("SELECT * FROM tasks where status = 'not done'", conn, transaction))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        int task_id = reader.GetInt32(0);
                        string name = reader.GetString(1);
                        string description = reader.GetString(2);
                        DateTime deadline = reader.GetDateTime(3);
                        string status = reader.GetString(4);
                        int user_id = reader.GetInt32(5);
                        int project_id = reader.GetInt32(6);
                        tasks.Add(new Tasks(task_id, name, description, deadline, status, user_id, project_id));
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
            return tasks;
        }
        /// <summary>
        /// method for inserting a task
        /// </summary>
        /// <param name="obj">task</param>
        public void Insert(Tasks obj)
        {
            try
            {
                string com = "INSERT INTO tasks (name, description, deadline, status, user_id, project_id) " +
                    "VALUES (@name, @description, @deadline, @status, @user_id, @project_id)";
                using (SqlCommand command = new SqlCommand(com, conn, transaction))
                {
                    command.Parameters.Add(new SqlParameter("@name", obj.Name));
                    command.Parameters.Add(new SqlParameter("@description", obj.Description));
                    command.Parameters.Add(new SqlParameter("@deadline", obj.Deadline));
                    command.Parameters.Add(new SqlParameter("@status", obj.Status));
                    command.Parameters.Add(new SqlParameter("@user_id", obj.UserId));
                    command.Parameters.Add(new SqlParameter("@project_id", obj.ProjectId));
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
        /// method for updating a task
        /// </summary>
        /// <param name="obj">task</param>
        public void Update(Tasks obj)
        {
            try
            {
                string com = "UPDATE tasks SET " +
                    "name = @name, description = @description, deadline = @deadline, " +
                    "status = @status, project_id = @project_id, user_id = @user_id " +
                    "WHERE task_id = @id";
                using (SqlCommand command = new SqlCommand(com, conn, transaction))
                {
                    command.Parameters.Add(new SqlParameter("@name", obj.Name));
                    command.Parameters.Add(new SqlParameter("@description", obj.Description));
                    command.Parameters.Add(new SqlParameter("@deadline", obj.Deadline));
                    command.Parameters.Add(new SqlParameter("@status", obj.Status));
                    command.Parameters.Add(new SqlParameter("@user_id", obj.UserId));
                    command.Parameters.Add(new SqlParameter("@project_id", obj.ProjectId));
                    command.Parameters.Add(new SqlParameter("@id", obj.TaskId));
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
        /// fetch task by id
        /// </summary>
        /// <param name="id">task id</param>
        /// <returns>task</returns>
        public Tasks GetById(int id)
        {
            Tasks task = null;
            try
            {
                using (SqlCommand command = new SqlCommand("SELECT * FROM tasks WHERE task_id = @id", conn, transaction))
                {
                    command.Parameters.Add(new SqlParameter("@id", id));
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        int task_id = reader.GetInt32(0);
                        string name = reader.GetString(1);
                        string description = reader.GetString(2);
                        DateTime deadline = reader.GetDateTime(3);
                        string status = reader.GetString(4);
                        int user_id = reader.GetInt32(5);
                        int project_id = reader.GetInt32(6);

                        task = new Tasks(task_id, name, description, deadline, status, user_id, project_id);
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
            return task;
        }
    }
}
