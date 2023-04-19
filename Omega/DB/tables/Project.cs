using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omega.DB.tables
{
    public class Project
    {
        private int projectId;
        private string name;
        private string description;
        private DateTime deadline;
        private string status;
        private int managerId;
        private int teamId;

        public Project()
        {
            this.ProjectId = 0;
            this.Name = "";
            this.Description = "";
            this.Deadline = DateTime.Now;
            this.Status = "not done";
            this.ManagerId = 0;
            this.TeamId = 0;
        }

        public Project(int projectId, string name, string description, DateTime deadline, string status, int managerId, int teamId)
        {
            ProjectId = projectId;
            Name = name;
            Description = description;
            Deadline = deadline;
            Status = status;
            ManagerId = managerId;
            TeamId = teamId;
        }

        public int ProjectId { get => projectId; set => projectId = value; }
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public DateTime Deadline { get => deadline; set => deadline = value; }
        public string Status { get => status; set => status = value; }
        public int ManagerId { get => managerId; set => managerId = value; }
        public int TeamId { get => teamId; set => teamId = value; }
    }
}
