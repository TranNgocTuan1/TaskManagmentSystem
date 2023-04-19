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
    public partial class AddTaskForm : Form
    {
        private Logic l;
        public AddTaskForm(Logic l)
        {
            this.l = l;
            InitializeComponent();
            List<User> users = null;
            List<Project> projects = null;
            try
            {
                users = l.GetUsersByTeamId();
                projects = l.GetProjectsByTeamId();
            }catch(Exception ex)
            {
                MessageBox.Show("Erorr reading from the database.");
            }
            

            empoyeBox.DataSource = users;
            empoyeBox.DisplayMember = "Username";
            empoyeBox.ValueMember = "UserId";
            taskNameText.PlaceholderText = "Title";
            projectBox.DataSource = projects;
            projectBox.DisplayMember = "Name";
            projectBox.ValueMember = "ProjectId";


        }

        private void addTaskButton_Click(object sender, EventArgs e)
        {
            if(taskNameText.Text == "")
            {
                MessageBox.Show("No title for task.");
            }
            else
            {
                try
                {

                    Tasks task = new Tasks();
                    task.Name = taskNameText.Text;
                    task.Description = descriptionText.Text;
                    task.Deadline = deadlineTime.Value;
                    task.UserId = int.Parse(empoyeBox.SelectedValue.ToString());
                    task.ProjectId = int.Parse(projectBox.SelectedValue.ToString());

                    l.AddTask(task);
                    MessageBox.Show("Task Adeed successfuly");
                    LogWrite log = new LogWrite("Task Addedd.");
                    this.Hide();
                }
                catch (Exception ex)
                {
                    LogWrite log = new LogWrite("Task failed to add.");
                    MessageBox.Show("Something went wrong with adding a task.");
                }
                
            }


        }
    }
}
