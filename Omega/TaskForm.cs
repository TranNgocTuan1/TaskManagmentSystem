using Omega.DB.tables;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Omega
{
    public partial class TaskForm : Form
    {
        private Logic l;
        private Tasks task;
        private static int formCount = 0;
        private System.Windows.Forms.Timer t;
        public TaskForm(Tasks task, Logic l)
        {
            this.l = l;
            this.task = task;
            InitializeComponent();
            titleLabel.Text = task.Name;
            descriptionLabel.Text = task.Description;
            formCount++;

            if (t == null)
            {
                t = new System.Windows.Forms.Timer();
                t.Interval = 500;
                t.Tick += new EventHandler(t_Tick);
                TimeSpan ts = task.Deadline.Subtract(DateTime.Now);
                deadlineLabel.Text = ts.ToString("d' Days 'h' Hours 'm' Minutes 's' Seconds'") + " left";
                t.Start();
            }
            
        }

        void t_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = task.Deadline.Subtract(DateTime.Now);
            deadlineLabel.Text = ts.ToString("d' Days 'h' Hours 'm' Minutes 's' Seconds'") + " left";
        }


        private void TaskForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            formCount--;

            if (formCount == 0 && t != null)
            {
                t.Stop();
                t.Dispose();
                t = null;
            }
        }

        private void commentsButton_Click(object sender, EventArgs e)
        {
            new CommentsForm(l, task).Show();
        }
    }
}
