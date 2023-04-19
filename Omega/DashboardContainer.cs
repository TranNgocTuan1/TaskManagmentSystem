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
    public partial class DashboardContainer : Form
    {
        private Logic l;
        public DashboardContainer(Logic l)
        {
            this.l = l;
            InitializeComponent();
            dataGridView1.Columns.Clear();
            dataGridView1.AllowUserToAddRows = false;
            Refresh();
            if(l.User.RoleId == 3)
            {
                addTaskButton.Hide();
            }
            
        }

        private void Refresh()
        {
            dataGridView1.Columns.Clear();
            var list = new BindingList<Tasks>(l.GetTasks());
            var source = new BindingSource(list, null);
            dataGridView1.DataSource = source;
            dataGridView1.Columns["TaskId"].Visible = false;
            dataGridView1.Columns["UserId"].Visible = false;
            dataGridView1.Columns["ProjectId"].Visible = false;


            DataGridViewButtonColumn butt = new DataGridViewButtonColumn();
            butt.HeaderText = "";
            butt.Text = "Complete";
            butt.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Insert(0,butt);
        }

        private void DashboardContainer_Load(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.ReadOnly = true;
            if (e.ColumnIndex == 0)
            {
                if(e.RowIndex >= 0)
                {
                    try
                    {
                        DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                        Tasks t = new Tasks(
                            int.Parse(row.Cells[1].Value.ToString()), 
                            row.Cells[2].Value.ToString(),
                            row.Cells[3].Value.ToString(), 
                            DateTime.Parse(row.Cells[4].Value.ToString()), 
                            "completed",
                            int.Parse(row.Cells[6].Value.ToString()), 
                            int.Parse(row.Cells[7].Value.ToString()));
                        l.UpdateTaskComplete(t);
                        MessageBox.Show("Task completed.");
                        Refresh();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    
                }

            }
            else
            {
                if (e.RowIndex >= 0)
                {
                    try
                    {
                        DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                        Tasks task = new Tasks();
                        task.TaskId = int.Parse(row.Cells[1].Value.ToString());
                        task.Name = row.Cells[2].Value.ToString();
                        task.Description = row.Cells[3].Value.ToString();
                        task.Deadline = DateTime.Parse(row.Cells[4].Value.ToString());
                        task.Status = "completed";
                        task.UserId = int.Parse(row.Cells[6].Value.ToString());
                        task.ProjectId = int.Parse(row.Cells[7].Value.ToString());
                        new TaskForm(task, l).Show();
                    }catch (Exception ex)
                    {
                        MessageBox.Show("Problem with reading the task.");
                    }
                    

                }
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void addTaskButton_Click(object sender, EventArgs e)
        {
            new AddTaskForm(l).Show();
        }
    }
}
