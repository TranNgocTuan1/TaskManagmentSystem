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
    public partial class ProjectContainer : Form
    {
        private Logic l;
        public ProjectContainer(Logic l)
        {
            this.l = l;
            InitializeComponent();
            dataGridView1.Columns.Clear();
            dataGridView1.AllowUserToAddRows = false;
            if (l.User.RoleId == 3)
            {
                addProjectButton.Visible = false;
            }
            
            Refresh();
        }
        
        private void Refresh()
        {
            dataGridView1.Columns.Clear();
            var list = new BindingList<Project>(l.GetProjectsByTeamId());
            var source = new BindingSource(list, null);
            dataGridView1.DataSource = source;
            dataGridView1.Columns["ProjectId"].Visible = false;
            dataGridView1.Columns["ManagerId"].Visible = false;
            dataGridView1.Columns["TeamId"].Visible = false;

            
                DataGridViewButtonColumn butt = new DataGridViewButtonColumn();
                butt.HeaderText = "";
                butt.Text = "Complete";
                butt.UseColumnTextForButtonValue = true;
                dataGridView1.Columns.Insert(0, butt);
            if(l.User.RoleId == 3)
            {
                dataGridView1.Columns[0].Visible = false;
            }
            
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.ReadOnly = true;
            if (e.ColumnIndex == 0)
            {
                if (e.RowIndex >= 0)
                {
                    if(l.User.RoleId != 3)
                    {
                        try
                        {

                            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                            Project t = new Project();
                            t.ProjectId = int.Parse(row.Cells[1].Value.ToString());
                            t.Name = row.Cells[2].Value.ToString();
                            t.Description = row.Cells[3].Value.ToString();
                            t.Deadline = DateTime.Parse(row.Cells[4].Value.ToString());
                            t.Status = "completed";
                            t.ManagerId = int.Parse(row.Cells[6].Value.ToString());
                            t.TeamId = int.Parse(row.Cells[7].Value.ToString());
                            l.UpdateProjectComplete(t);
                            MessageBox.Show("Project completed.");
                            Refresh();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
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
                        Project t = new Project();
                        t.ProjectId = int.Parse(row.Cells[1].Value.ToString());
                        t.Name = row.Cells[2].Value.ToString();
                        t.Description = row.Cells[3].Value.ToString();
                        t.Deadline = DateTime.Parse(row.Cells[4].Value.ToString());
                        t.Status = "completed";
                        t.ManagerId = int.Parse(row.Cells[6].Value.ToString());
                        t.TeamId = int.Parse(row.Cells[7].Value.ToString());
                        new SignleProjectForm(l, t).Show();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Problem with reading the project.");
                    }
                }
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void addProjectButton_Click(object sender, EventArgs e)
        {
            new AddProjectForm(l).Show();
        }
    }
}
