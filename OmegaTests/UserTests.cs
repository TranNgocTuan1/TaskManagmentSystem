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
    public class UserTests
    {
        [TestMethod()]
        public void UserTest()
        {
            User user = new User();
            Assert.IsNotNull(user);
            user.UserId = 1;
            user.First_name = "unittest";
            user.Last_name = "unittest";
            user.Username = "unittest";
            user.Email = "unittest";
            user.Password = "unittest";
            user.RoleId = 1;
            user.TeamId = 1;
            Assert.AreEqual(1, user.UserId);
            Assert.AreEqual("unittest", user.First_name);
            Assert.AreEqual("unittest", user.Last_name);
            Assert.AreEqual("unittest", user.Username);
            Assert.AreEqual("unittest", user.Email);
            Assert.AreEqual("unittest", user.Password);
            Assert.AreEqual(1, user.RoleId);
            Assert.AreEqual(1, user.TeamId);
        }
    }
}