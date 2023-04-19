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
    public partial class SettingsForm : Form
    {
        private Logic l;
        public SettingsForm(Logic l)
        {
            this.l = l; 
            InitializeComponent();
            firstNameText.Text = l.User.First_name;
            lastNameText.Text = l.User.Last_name;
            usernameText.Text = l.User.Username;
            emailText.Text = l.User.Email;
            passText.Text = l.User.Password;
        }

        private void saveChangButton_Click(object sender, EventArgs e)
        {
            if(firstNameLabel.Text == "" || lastNameLabel.Text == "" || usernameLabel.Text == "" || emailLabel.Text == "" || passText.Text == "")
            {
                LogWrite log = new LogWrite("Modifing user failed, blank fields.");
                MessageBox.Show("Some text fields are empty.");
            }
            else
            {
                l.User.First_name = firstNameText.Text;
                l.User.Last_name = lastNameText.Text;
                l.User.Username = usernameText.Text;
                l.User.Email = emailText.Text;
                l.User.Password = passText.Text;
                l.ChangeUserInfo();
                LogWrite log = new LogWrite("User changed informations.");
                MessageBox.Show("Updated successful");


            }
        }
    }
}
