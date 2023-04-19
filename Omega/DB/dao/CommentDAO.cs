using Microsoft.Data.SqlClient;
using Omega.DB.tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omega.DB.dao
{
    public class CommentsDAO : IDAO<Comments>
    {
        private static SqlConnection conn = DatabaseConnection.GetInstance();
        private static SqlTransaction transaction = null;

        public CommentsDAO()
        {
            transaction = conn.BeginTransaction();
        }
        /// <summary>
        /// method for fetching comments by task id
        /// </summary>
        /// <param name="taskId">id of the task</param>
        /// <returns>comments</returns>
        public List<Comments> SelectByTask(int taskId)
        {
            List<Comments> comments = new List<Comments>();
            try
            {
                using (SqlCommand command = new SqlCommand("SELECT * FROM comments where task_id = @task_id", conn, transaction))
                {
                    command.Parameters.Add(new SqlParameter("@task_id", taskId));
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        int comment_id = reader.GetInt32(0);
                        string content = reader.GetString(1);
                        DateTime date = reader.GetDateTime(2);
                        int task_id = reader.GetInt32(3);
                        int user_id = reader.GetInt32(4);
                        comments.Add(new Comments(comment_id, content, date, task_id, user_id));
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
            return comments;
        }
        /// <summary>
        /// method for deleting a comment by id
        /// </summary>
        /// <param name="id">id of the comment</param>
        public void Delete(int id)
        {
            try
            {
                using (SqlCommand command = new SqlCommand("DELETE FROM comments WHERE id = @id", conn, transaction))
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
        /// method for selecting all the comments
        /// </summary>
        /// <returns>all comments</returns>
        public List<Comments> Select()
        {
            List<Comments> comments = new List<Comments>();
            try
            {
                using (SqlCommand command = new SqlCommand("SELECT * FROM comments", conn, transaction))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        int comment_id = reader.GetInt32(0);
                        string content = reader.GetString(1);
                        DateTime date = reader.GetDateTime(2);
                        int task_id = reader.GetInt32(3);
                        int user_id = reader.GetInt32(4);
                        comments.Add(new Comments(comment_id, content, date, task_id, user_id));
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
            return comments;
        }
        /// <summary>
        /// method for inserting comment
        /// </summary>
        /// <param name="obj">comment</param>
        public void Insert(Comments obj)
        {
            try
            {
                using (SqlCommand command = new SqlCommand("INSERT INTO comments (content, date, user_id, task_id) VALUES (@content, @date, @user_id, @task_id)", conn, transaction))
                {
                    command.Parameters.Add(new SqlParameter("@content", obj.Content));
                    command.Parameters.Add(new SqlParameter("@date", obj.Date));
                    command.Parameters.Add(new SqlParameter("@user_id", obj.UserId));
                    command.Parameters.Add(new SqlParameter("@task_id", obj.TaskId));
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
        /// method for updating a comment
        /// </summary>
        /// <param name="obj">comment</param>
        public void Update(Comments obj)
        {
            try
            {
                string com = "UPDATE comments SET " +
                    "content = @content, date = @date, user_id = @user_id, task_id = @task_id " +
                    "WHERE id = @id";
                using (SqlCommand command = new SqlCommand(com, conn, transaction))
                {
                    command.Parameters.Add(new SqlParameter("@content", obj.Content));
                    command.Parameters.Add(new SqlParameter("@user_id", obj.UserId));
                    command.Parameters.Add(new SqlParameter("@task_id", obj.TaskId));
                    command.Parameters.Add(new SqlParameter("@date", obj.Date));
                    command.Parameters.Add(new SqlParameter("@id", obj.CommentId));
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
        /// method for fetching a comment by id
        /// </summary>
        /// <param name="id">id of comment</param>
        /// <returns>comment</returns>
        public Comments GetById(int id)
        {
            Comments comment = null;
            try
            {
                using (SqlCommand command = new SqlCommand("SELECT * FROM comments WHERE comment_id = @id", conn, transaction))
                {
                    command.Parameters.Add(new SqlParameter("@id", id));
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        int comment_id = reader.GetInt32(0);
                        string content = reader.GetString(1);
                        DateTime date = reader.GetDateTime(2);
                        int task_id = reader.GetInt32(3);
                        int user_id = reader.GetInt32(4);
                        
                        comment = new Comments(comment_id, content, date, task_id, user_id);
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
            return comment;
        }
    }
}
