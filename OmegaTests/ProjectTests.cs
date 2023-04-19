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
    public class ProjectTests
    {
        [TestMethod()]
        public void ProjectTest()
        {
            Project project = new Project();
            Assert.IsNotNull(project);
            Assert.AreEqual(0, project.ProjectId);
            project.ProjectId = 1;
            project.Name = "unittest";
            project.Description = "unittest";
            project.Deadline = DateTime.Parse("2022-03-01");
            project.Status = "completed";
            project.ManagerId = 3;
            project.TeamId = 4;
            Assert.AreEqual(1, project.ProjectId);
            Assert.AreEqual("unittest", project.Name);
            Assert.AreEqual("unittest", project.Description);
            Assert.AreEqual(DateTime.Parse("2022-03-01"), project.Deadline);
            Assert.AreEqual("completed", project.Status);
            Assert.AreEqual(3, project.ManagerId);
            Assert.AreEqual(4, project.TeamId);

        }
    }
}