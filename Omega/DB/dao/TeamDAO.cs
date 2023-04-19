using Microsoft.Data.SqlClient;
using Omega.DB.tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omega.DB.dao
{
    public class TeamDAO : IDAO<Team>
    {
        private static SqlConnection conn = DatabaseConnection.GetInstance();
        private static SqlTransaction transaction = null;

        public TeamDAO()
        {
            transaction = conn.BeginTransaction();
        }
        /// <summary>
        /// method for deleting a team
        /// </summary>
        /// <param name="id">team id</param>
        public void Delete(int id)
        {
            try
            {
                using (SqlCommand command = new SqlCommand("DELETE FROM teams WHERE id = @id", conn, transaction))
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
        /// method for selecting all teams
        /// </summary>
        /// <returns>teams</returns>
        public List<Team> Select()
        {
            List<Team> teams = new List<Team>();
            try
            {
                using (SqlCommand command = new SqlCommand("SELECT * FROM teams", conn, transaction))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        int team_id = reader.GetInt32(0);
                        string name = reader.GetString(1);
                        teams.Add(new Team(team_id, name));
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
            return teams;
        }
        /// <summary>
        /// method for inserting a new team
        /// </summary>
        /// <param name="obj">team</param>
        public void Insert(Team obj)
        {
            try
            {
                using (SqlCommand command = new SqlCommand("INSERT INTO teams (name) VALUES (@name)", conn, transaction))
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
        /// method for updating a team
        /// </summary>
        /// <param name="obj">team</param>
        public void Update(Team obj)
        {
            try
            {
                using (SqlCommand command = new SqlCommand("UPDATE teams SET name = @name WHERE id = @id", conn, transaction))
                {
                    command.Parameters.Add(new SqlParameter("@name", obj.Name));
                    command.Parameters.Add(new SqlParameter("@id", obj.TeamId));
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
        /// get team by id
        /// </summary>
        /// <param name="id">team id</param>
        /// <returns>team</returns>
        public Team GetById(int id)
        {
            Team team = null;
            try
            {
                using (SqlCommand command = new SqlCommand("SELECT * FROM teams WHERE id = @id", conn, transaction))
                {
                    command.Parameters.Add(new SqlParameter("@id", id));
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        int team_id = reader.GetInt32(0);
                        string name = reader.GetString(1);
                        team = new Team(team_id, name);
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
            return team;
        }
    }
}
