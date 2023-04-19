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
    public partial class FinishedTasksContainer : Form
    {
        private Logic l;
        public FinishedTasksContainer(Logic l)
        {
            this.l = l;
            InitializeComponent();

            dataGridView1.Columns.Clear();
            dataGridView1.AllowUserToAddRows = false;
            Refresh();
        }

        private void Refresh()
        {
            dataGridView1.Columns.Clear();
            var list = new BindingList<Tasks>(l.GetFinishedTasks());
            var source = new BindingSource(list, null);
            dataGridView1.DataSource = source;
            dataGridView1.Columns["TaskId"].Visible = false;
            dataGridView1.Columns["UserId"].Visible = false;
            dataGridView1.Columns["ProjectId"].Visible = false;


            DataGridViewButtonColumn butt = new DataGridViewButtonColumn();
            butt.HeaderText = "";
            butt.Text = "Uncomplete";
            butt.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Insert(0, butt);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.ReadOnly = true;
            if (e.ColumnIndex == 0)
            {
                if (e.RowIndex >= 0)
                {
                    try
                    {
                        DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                        Tasks t = new Tasks(int.Parse(row.Cells[1].Value.ToString()), row.Cells[2].Value.ToString(),
                            row.Cells[3].Value.ToString(), DateTime.Parse(row.Cells[4].Value.ToString()), "not done",
                            int.Parse(row.Cells[6].Value.ToString()), int.Parse(row.Cells[7].Value.ToString()));
                        l.UpdateTaskComplete(t);
                        MessageBox.Show("Task completion reverted.");
                        Refresh();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }

            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            Refresh();
        }
    }
}
