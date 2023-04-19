using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omega.DB.tables
{
    public class Role
    {
        private int roleId;
        private string name;

        public Role()
        {
            this.RoleId = 0;
            this.Name = "";
        }

        public Role(int roleId, string name)
        {
            RoleId = roleId;
            Name = name;
        }

        public int RoleId { get => roleId; set => roleId = value; }
        public string Name { get => name; set => name = value; }
    }
}
