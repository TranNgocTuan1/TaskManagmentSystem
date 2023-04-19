using Omega.DB.tables;
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
    public partial class SignleProjectForm : Form
    {
        private Logic l;
        private Project p;
        private static int formCount = 0;
        private System.Windows.Forms.Timer t;
        public SignleProjectForm(Logic l, Project p)
        {
            this.l = l;
            this.p = p;
            InitializeComponent();

            titleLabel.Text = p.Name;
            descriptionLabel.Text = p.Description;
            statusLabel.Text = p.Status;
            formCount++;

            if (t == null)
            {
                t = new System.Windows.Forms.Timer();
                t.Interval = 500;
                t.Tick += new EventHandler(t_Tick);
                TimeSpan ts = p.Deadline.Subtract(DateTime.Now);
                deadlineLabel.Text = ts.ToString("d' Days 'h' Hours 'm' Minutes 's' Seconds'") + " left";
                t.Start();
            }
        }

        void t_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = p.Deadline.Subtract(DateTime.Now);
            deadlineLabel.Text = ts.ToString("d' Days 'h' Hours 'm' Minutes 's' Seconds'") + " left";
        }

        private void SignleProjectForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            formCount--;

            if (formCount == 0 && t != null)
            {
                t.Stop();
                t.Dispose();
                t = null;
            }
        }
    }
}
