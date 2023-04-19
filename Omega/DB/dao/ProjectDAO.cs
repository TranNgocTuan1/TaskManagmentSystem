using Microsoft.Data.SqlClient;
using Omega.DB.tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omega.DB.dao
{
    public class ProjectDAO : IDAO<Project>
    {
        private static SqlConnection conn = DatabaseConnection.GetInstance();
        private static SqlTransaction transaction = null;

        public ProjectDAO()
        {
            transaction = conn.BeginTransaction();
        }
        /// <summary>
        /// select all projects by team id
        /// </summary>
        /// <param name="id">team id</param>
        /// <returns>projects</returns>
        public List<Project> SelectByTeamId(int id)
        {
            List<Project> projects = new List<Project>();
            try
            {
                using (SqlCommand command = new SqlCommand("SELECT * FROM projects where team_id = @team_id", conn, transaction))
                {
                    command.Parameters.Add(new SqlParameter("@team_id", id));
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        int project_id = reader.GetInt32(0);
                        string name = reader.GetString(1);
                        string description = reader.GetString(2);
                        DateTime deadline = reader.GetDateTime(3);
                        string status = reader.GetString(4);
                        int manager_id = reader.GetInt32(5);
                        int team_id = reader.GetInt32(6);

                        projects.Add(new Project(project_id, name, description, deadline, status, manager_id, team_id));
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
            return projects;
        }
        /// <summary>
        /// method for deleting a project
        /// </summary>
        /// <param name="id">id of project</param>
        public void Delete(int id)
        {
            try
            {
                using (SqlCommand command = new SqlCommand("DELETE FROM projects WHERE project_id = @id", conn, transaction))
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
        /// method for fetching all projects
        /// </summary>
        /// <returns>projects</returns>
        public List<Project> Select()
        {
            List<Project> projects = new List<Project>();
            try
            {
                using (SqlCommand command = new SqlCommand("SELECT * FROM projects", conn, transaction))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        int project_id = reader.GetInt32(0);
                        string name = reader.GetString(1);
                        string description = reader.GetString(2);
                        DateTime deadline = reader.GetDateTime(3);
                        string status = reader.GetString(4);
                        int manager_id = reader.GetInt32(5);
                        int team_id = reader.GetInt32(6);

                        projects.Add(new Project(project_id, name, description, deadline, status, manager_id, team_id));
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
            return projects;
        }
        /// <summary>
        /// method for inserting projects
        /// </summary>
        /// <param name="obj">project</param>
        public void Insert(Project obj)
        {
            try
            {
                string com = "INSERT INTO projects (name, description, deadline, status, manager_id, team_id) " +
                    "VALUES (@name, @description, @deadline, @status, @manager_id, @team_id)";
                using (SqlCommand command = new SqlCommand(com, conn, transaction))
                {
                    command.Parameters.Add(new SqlParameter("@name", obj.Name));
                    command.Parameters.Add(new SqlParameter("@description", obj.Description));
                    command.Parameters.Add(new SqlParameter("@deadline", obj.Deadline));
                    command.Parameters.Add(new SqlParameter("@status", obj.Status));
                    command.Parameters.Add(new SqlParameter("@manager_id", obj.ManagerId));
                    command.Parameters.Add(new SqlParameter("@team_id", obj.TeamId));
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
        /// method for updating a project
        /// </summary>
        /// <param name="obj">project</param>
        public void Update(Project obj)
        {
            try
            {
                string com = "UPDATE projects SET " +
                    "name = @name, description = @description, deadline = @deadline, " +
                    "status = @status, manager_id = @managerId, team_id = @teamId " +
                    "WHERE project_id = @id";
                using (SqlCommand command = new SqlCommand(com, conn, transaction))
                {
                    command.Parameters.Add(new SqlParameter("@name", obj.Name));
                    command.Parameters.Add(new SqlParameter("@description", obj.Description));
                    command.Parameters.Add(new SqlParameter("@deadline", obj.Deadline));
                    command.Parameters.Add(new SqlParameter("@status", obj.Status));
                    command.Parameters.Add(new SqlParameter("@managerId", obj.ManagerId));
                    command.Parameters.Add(new SqlParameter("@teamId", obj.TeamId));
                    command.Parameters.Add(new SqlParameter("@id", obj.ProjectId));
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
        /// method for getting a project by id
        /// </summary>
        /// <param name="id">id of the project</param>
        /// <returns>project</returns>
        public Project GetById(int id)
        {
            Project project = null;
            try
            {
                using (SqlCommand command = new SqlCommand("SELECT * FROM projects WHERE project_id = @id", conn, transaction))
                {
                    command.Parameters.Add(new SqlParameter("@id", id));
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        string name = reader.GetString(1);
                        string description = reader.GetString(2);
                        DateTime deadline = reader.GetDateTime(3);
                        string status = reader.GetString(4);
                        int managerId = reader.GetInt32(5);
                        int teamId = reader.GetInt32(6);
                        project = new Project(id, name, description, deadline, status, managerId, teamId);
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
            return project;
        }
    }
}
