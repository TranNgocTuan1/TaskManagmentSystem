using Microsoft.Data.SqlClient;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Omega.DB;
using Omega.DB.dao;
using Omega.DB.tables;
using System;
using Omega;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmegaTest
{
    [TestClass()]
    public class LogicTest
    {

        [TestMethod]
        public void LogOutTest()
        {
            Logic l = new Logic();
            l.User = new User();
            Assert.IsNotNull(l.User);
            l.LogOut();
            Assert.IsNull(l.User);
        }


    }
}