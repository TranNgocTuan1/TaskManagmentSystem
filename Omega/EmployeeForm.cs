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
    public partial class EmployeeForm : Form
    {
        private Logic l;
        public EmployeeForm(Logic l)
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
            var list = new BindingList<User>(l.GetUsersByTeamId());
            var source = new BindingSource(list, null);
            dataGridView1.DataSource = source;
            dataGridView1.Columns["UserId"].Visible = false;
            dataGridView1.Columns["TeamId"].Visible = false;
            dataGridView1.Columns["RoleId"].Visible = false;
            dataGridView1.Columns["Password"].Visible = false;

        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dataGridView1.ReadOnly = true;
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                User user = new User();
                user.UserId = int.Parse(row.Cells[0].Value.ToString());
                user.First_name = row.Cells[1].Value.ToString();
                user.Last_name = row.Cells[6].Value.ToString();
                user.Username = row.Cells[7].Value.ToString();
                user.Email = row.Cells[3].Value.ToString();
                user.RoleId = int.Parse(row.Cells[4].Value.ToString());
                user.TeamId = int.Parse(row.Cells[5].Value.ToString());
                new SingleEmployeeForm(l, user).Show();

            }
        }
    }
}
