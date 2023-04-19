using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omega.DB.tables
{
    public class Tasks
    {
        private int taskId;
        private string name;
        private string description;
        private DateTime deadline;
        private string status;
        private int userId;
        private int projectId;

        public Tasks()
        {
            this.TaskId = 0;
            this.Name = "";
            this.Description = "";
            this.Deadline = DateTime.Now;
            this.Status = "not done";
            this.UserId = 0;
            this.ProjectId = 0;
        }

        public Tasks(int taskId, string name, string description, DateTime deadline, string status, int userId, int projectId)
        {
            TaskId = taskId;
            Name = name;
            Description = description;
            Deadline = deadline;
            Status = status;
            UserId = userId;
            ProjectId = projectId;
        }

        public int TaskId { get => taskId; set => taskId = value; }
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public DateTime Deadline { get => deadline; set => deadline = value; }
        public string Status { get => status; set => status = value; }
        public int UserId { get => userId; set => userId = value; }
        public int ProjectId { get => projectId; set => projectId = value; }
    }
}
