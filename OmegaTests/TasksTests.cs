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
    public class TasksTests
    {
        [TestMethod()]
        public void TasksTest()
        {
            Tasks tasks = new Tasks();
            Assert.IsNotNull(tasks);
            tasks.TaskId = 1;
            tasks.Name = "unittest";
            tasks.Description = "unittest";
            tasks.Deadline = DateTime.Parse("2022-05-22");
            tasks.Status = "not done";
            tasks.UserId = 2;
            tasks.ProjectId = 1;
            Assert.AreEqual(1, tasks.TaskId);
            Assert.AreEqual("unittest", tasks.Name);
            Assert.AreEqual("unittest", tasks.Description);
            Assert.AreEqual(DateTime.Parse("2022-05-22"), tasks.Deadline);
            Assert.AreEqual("not done", tasks.Status);
            Assert.AreEqual(2, tasks.UserId);
            Assert.AreEqual(1, tasks.ProjectId);
        }
    }
}