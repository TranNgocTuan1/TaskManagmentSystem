using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omega.DB.tables
{
    public class Team
    {
        private int teamId;
        private string name;

        public Team()
        {
            this.TeamId = 0;
            this.Name = "";
        }
        public Team(int teamId, string name)
        {
            TeamId = teamId;
            Name = name;
        }

        public int TeamId { get => teamId; set => teamId = value; }
        public string Name { get => name; set => name = value; }
    }
}
