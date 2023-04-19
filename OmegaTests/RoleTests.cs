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
    public class RoleTests
    {
        [TestMethod()]
        public void RoleTest()
        {
            Role role = new Role();
            Assert.IsNotNull(role);
            role.RoleId = 1;
            role.Name = "unittest";
            Assert.AreEqual(1, role.RoleId);
            Assert.AreEqual("unittest", role.Name);
        }
    }
}