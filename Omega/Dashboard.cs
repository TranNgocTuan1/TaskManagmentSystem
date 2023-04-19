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
    public partial class Dashboard : Form
    {

        private Logic l;
        public Dashboard(Logic l)
        {
            this.l = l;
            InitializeComponent();
            if(l.User.RoleId == 3)
            {
                employeeButton.Hide();
            }
            welcomeLabel.Text = "Welcome " + l.User.First_name;
            this.formPanel.Controls.Clear();
            DashboardContainer cont = new DashboardContainer(l) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            cont.FormBorderStyle = FormBorderStyle.None;
            this.formPanel.Controls.Add(cont);
            cont.Show();
        }

        private void dashboardButton_Click(object sender, EventArgs e)
        {
            this.formPanel.Controls.Clear();
            DashboardContainer cont = new DashboardContainer(l) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            cont.FormBorderStyle = FormBorderStyle.None;
            this.formPanel.Controls.Add(cont);
            cont.Show();
        }

        private void projectsButton_Click(object sender, EventArgs e)
        {
            this.formPanel.Controls.Clear();
            ProjectContainer cont = new ProjectContainer(l) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            cont.FormBorderStyle = FormBorderStyle.None;
            this.formPanel.Controls.Add(cont);
            cont.Show();
        }

        private void finishedTasksButton_Click(object sender, EventArgs e)
        {
            this.formPanel.Controls.Clear();
            FinishedTasksContainer cont = new FinishedTasksContainer(l) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            cont.FormBorderStyle = FormBorderStyle.None;
            this.formPanel.Controls.Add(cont);
            cont.Show();
        }

        private void logOut_Click(object sender, EventArgs e)
        {
            l.LogOut();
            new Form1().Show();
            this.Hide();
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            this.formPanel.Controls.Clear();
            SettingsForm cont = new SettingsForm(l) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            cont.FormBorderStyle = FormBorderStyle.None;
            this.formPanel.Controls.Add(cont);
            cont.Show();
        }

        private void employeeButton_Click(object sender, EventArgs e)
        {
            this.formPanel.Controls.Clear();
            EmployeeForm cont = new EmployeeForm(l) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            cont.FormBorderStyle = FormBorderStyle.None;
            this.formPanel.Controls.Add(cont);
            cont.Show();
        }

        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            l.LogOut();
            l.DbDisconnect();
            Application.Exit();
        }
    }
}
