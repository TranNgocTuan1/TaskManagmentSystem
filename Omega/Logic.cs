using Omega.DB;
using Omega.DB.dao;
using Omega.DB.tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omega
{
    public class Logic
    {
        private User user;


        public User User { get => user; set => user = value; }

        public Logic()
        {
            User = user;
        }

        /// <summary>
        /// method for changing user info
        /// </summary>
        public void ChangeUserInfo()
        {
            UserDAO userDAO = new UserDAO();
            userDAO.Update(this.user);
        }
        /// <summary>
        /// method for getting all comment from dao
        /// </summary>
        /// <param name="t">task</param>
        /// <returns>tasks</returns>
        public List<Comments> GetCommentsByTask(Tasks t)
        {
            CommentsDAO commentsDAO = new CommentsDAO();
            return commentsDAO.SelectByTask(t.TaskId);
        }
        /// <summary>
        /// method for login and save user info
        /// </summary>
        /// <param name="user">username</param>
        /// <param name="pass">password</param>
        /// <returns>true if loged in successful</returns>
        public bool LoginUser(string user, string pass)
        {
            UserDAO dao = new UserDAO();
            this.User = dao.CheckLogin(user, pass);
            if(this.user.UserId > 0){
                return true;
            }
            return false;
        }
        /// <summary>
        /// method for getting tasks that are not done
        /// </summary>
        /// <returns>tasks</returns>
        public List<Tasks> GetTasks()
        {
            TaskDAO taskDAO = new TaskDAO();
            return taskDAO.SelectTasksByUser(this.user, "not done");
        }
        /// <summary>
        /// get task by user not loged in
        /// </summary>
        /// <param name="u">diff user</param>
        /// <returns>tasks</returns>
        public List<Tasks> GetEmployeeTasks(User u)
        {
            TaskDAO taskDAO = new TaskDAO();
            return taskDAO.SelectTasksByUser(u, "not done");
        }
        /// <summary>
        /// method for getting projects by team id
        /// </summary>
        /// <returns>projects</returns>
        public List<Project> GetProjectsByTeamId()
        {
            ProjectDAO projectDAO = new ProjectDAO();
            return projectDAO.SelectByTeamId(this.user.TeamId);
        }
        /// <summary>
        /// method for updating a task to completed
        /// </summary>
        /// <param name="t"></param>
        public void UpdateTaskComplete(Tasks t)
        {
            TaskDAO tasksDAO = new TaskDAO();
            tasksDAO.Update(t);
        }
        /// <summary>
        /// melthod for getting completed tasks
        /// </summary>
        /// <returns>tasks</returns>
        public List<Tasks> GetFinishedTasks()
        {
            TaskDAO taskDAO = new TaskDAO();
            return taskDAO.SelectTasksByUser(this.user, "completed");
        }
        /// <summary>
        /// method for closing connection to db
        /// </summary>
        public void DbDisconnect()
        {
            DatabaseConnection.CloseConnection();
        }
        /// <summary>
        /// method for loging out
        /// </summary>
        public void LogOut()
        {
            this.user = null;
        }
        /// <summary>
        /// get all users
        /// </summary>
        /// <returns>users</returns>
        public List<User> GetUsers()
        {
            UserDAO userDAO = new UserDAO();
            return userDAO.Select();
        }
        /// <summary>
        /// method for inserting a task
        /// </summary>
        /// <param name="obj">task</param>
        public void AddTask(Tasks obj)
        {
            TaskDAO tDAO = new TaskDAO();
            tDAO.Insert(obj);
        }
        /// <summary>
        /// method for getting all user in team
        /// </summary>
        /// <returns></returns>
        public List<User> GetUsersByTeamId()
        {
            UserDAO usersDAO = new UserDAO();
            return usersDAO.SelectByTeamId(this.user.TeamId);
        }
        /// <summary>
        /// method for adding comments
        /// </summary>
        /// <param name="com"></param>
        public void AddComment(Comments com)
        {
            CommentsDAO commentsDAO = new CommentsDAO();
            commentsDAO.Insert(com);
        }
        /// <summary>
        /// method for getting task counts
        /// </summary>
        /// <param name="u">user</param>
        /// <param name="status">status</param>
        /// <returns>number of tasks</returns>
        public int GetTaskCounts(User u, string status)
        {
            TaskDAO taskDAO=new TaskDAO();
            return taskDAO.SelectTaskCount(u, status);
        }
        /// <summary>
        /// method for adding a project
        /// </summary>
        /// <param name="p">project</param>
        public void AddProject(Project p)
        {
            ProjectDAO projectDAO = new ProjectDAO();
            projectDAO.Insert(p);
        }
        /// <summary>
        /// update a project to completed
        /// </summary>
        /// <param name="p">project</param>
        public void UpdateProjectComplete(Project p)
        {
            ProjectDAO projectDAO=new ProjectDAO();
            projectDAO.Update(p);
        }
        
    }
}


