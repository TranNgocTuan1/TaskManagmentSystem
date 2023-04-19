using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omega.DB.tables
{
    public class Comments
    {
        private int commentId;
        private string content;
        private DateTime date;
        private int userId;
        private int taskId;

        public Comments()
        {
            this.CommentId = 0;
            this.Content = "";
            this.date = DateTime.Now;
            this.userId = 0;
            this.taskId = 0;
        }

        public Comments(int commentId, string content, DateTime date, int userId, int taskId)
        {
            CommentId = commentId;
            Content = content;
            Date = date;
            UserId = userId;
            TaskId = taskId;
        }

        public int CommentId { get => commentId; set => commentId = value; }
        public string Content { get => content; set => content = value; }
        public DateTime Date { get => date; set => date = value; }
        public int UserId { get => userId; set => userId = value; }
        public int TaskId { get => taskId; set => taskId = value; }
    }
}
