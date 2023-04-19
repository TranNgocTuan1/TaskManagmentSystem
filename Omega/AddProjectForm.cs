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
    public partial class AddProjectForm : Form
    {
        private Logic l;
        public AddProjectForm(Logic l)
        {
            this.l = l;
            InitializeComponent();
        }

        private void addTaskButton_Click(object sender, EventArgs e)
        {
            if (projectNameText.Text == "")
            {
                MessageBox.Show("No title for task.");
            }
            else
            {
                try
                {
                    Project pro = new Project();
                    pro.ManagerId = l.User.UserId;
                    pro.TeamId = l.User.TeamId;
                    pro.Name = projectNameText.Text;
                    pro.Description = descriptionText.Text;
                    pro.Deadline = deadlineTime.Value;
                    l.AddProject(pro);
                    MessageBox.Show("Task Adeed successfuly");
                    LogWrite log = new LogWrite("Project added.");
                    this.Hide();
                }
                catch (Exception ex)
                {
                    LogWrite log = new LogWrite("Project failed to add.");
                    MessageBox.Show("Something went wrong with adding a Project.");
                }

            }
        }
    }
}
