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
    public class CommentsTests
    {
        [TestMethod()]
        public void CommentsTest()
        {
            Comments comment = new Comments();
            Assert.IsNotNull(comment);
            Assert.AreEqual(0, comment.CommentId);
            comment.CommentId = 1;
            comment.Content = "unittest";
            comment.Date = DateTime.Parse("2023-04-01");
            comment.UserId = 2;
            comment.TaskId = 3;
            Assert.AreEqual(1, comment.CommentId);
            Assert.AreEqual("unittest", comment.Content);
            Assert.AreEqual(DateTime.Parse("2023-04-01"), comment.Date);
            Assert.AreEqual(2, comment.UserId);
            Assert.AreEqual(3, comment.TaskId);
        }
    }
}