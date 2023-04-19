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
using System.Windows.Forms.DataVisualization.Charting;
namespace Omega
{
    public partial class SingleEmployeeForm : Form
    {
        private Logic l;
        private User u;
        public SingleEmployeeForm(Logic l, User u)
        {
            this.l = l;
            this.u = u;
            InitializeComponent();
            emloyeeNameLabel.Text = u.First_name + " " + u.Last_name;
            var empTasks = new BindingList<Tasks>(l.GetEmployeeTasks(u));
            var source = new BindingSource(empTasks, null);
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.DataSource = source;
            dataGridView1.Columns["TaskId"].Visible = false;
            dataGridView1.Columns["UserId"].Visible = false;
            dataGridView1.Columns["ProjectId"].Visible = false;
            int done = l.GetTaskCounts(u, "completed");
            int notDone = l.GetTaskCounts(u, "not done");
            chart1.Series["task"].Points.AddXY("Not Done", notDone);
            chart1.Series["task"].Points[0].IsValueShownAsLabel = true;
            if (done > 0)
            {
                chart1.Series["task"].Points.AddXY("Completed", done);
                chart1.Series["task"].Points[1].IsValueShownAsLabel = true;
            }
            
            
            
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.ReadOnly = true;
            if (e.RowIndex >= 0)
            {
                
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                Tasks t = new Tasks(
                    int.Parse(row.Cells[0].Value.ToString()), 
                    row.Cells[1].Value.ToString(),
                    row.Cells[2].Value.ToString(),
                    DateTime.Parse(row.Cells[3].Value.ToString()),
                    row.Cells[4].Value.ToString(),
                    int.Parse(row.Cells[5].Value.ToString()),
                    int.Parse(row.Cells[6].Value.ToString())
                    );
                    
                new TaskForm(t, l).Show();

            }
        }
    }
}
