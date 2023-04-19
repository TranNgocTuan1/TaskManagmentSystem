using Microsoft.VisualStudio.TestTools.UnitTesting;
using Omega.DB.tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmegaTests
{
    [TestClass()]
    public class TeamTests
    {
        [TestMethod()]
        public void TeamTest()
        {
            Team team = new Team();
            Assert.IsNotNull(team);
            team.TeamId = 1;
            team.Name = "unittest";
            Assert.AreEqual(1, team.TeamId);
            Assert.AreEqual("unittest", team.Name);
        }
    }
}