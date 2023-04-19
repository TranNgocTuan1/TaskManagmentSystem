using Omega.DB.tables;
using Omega.Logger;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Omega
{
    public partial class CommentsForm : Form
    {
        private Logic l;
        private Tasks t;
        public CommentsForm(Logic l, Tasks t)
        {
            this.l = l;
            this.t = t;
            InitializeComponent();
            RefreshComments();
        }

        private void RefreshComments()
        {
            var comments = l.GetCommentsByTask(t);
            foreach (var comment in comments)
            {
                commentsBox.AppendText(comment.Content + "      | " + comment.Date + "\r\n");
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if(newCommentText.Text == "")
            {
                MessageBox.Show("Content of new comment is blank");
            }
            else
            {
                try
                {
                    Comments com = new Comments(0, newCommentText.Text, DateTime.Now, l.User.UserId, t.TaskId);
                    l.AddComment(com);
                    MessageBox.Show("Comments added successfuly");
                    LogWrite log = new LogWrite("Comment added.");
                    newCommentText.Text = "";
                }catch (Exception ex)
                {
                    LogWrite log = new LogWrite("Comment failed to add.");
                    MessageBox.Show("Error in adding a comment");
                }
            }
        }
    }
}
