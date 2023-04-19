using Omega.Logger;

namespace Omega
{
    public partial class Form1 : Form
    {
        private Logic l;
        public Form1()
        {
            InitializeComponent();
            l = new Logic();
        }

        private void usernameLabel_Click(object sender, EventArgs e)
        {
            usernameText.Focus();
        }

        private void passwordLabel_Click(object sender, EventArgs e)
        {
            passwordText.Focus();
        }

        private void showPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (showPassword.Checked)
            {
                passwordText.PasswordChar = '\0';
            }
            else
            {
                passwordText.PasswordChar = '•';
            }
        }

        private void login_Click(object sender, EventArgs e)
        {
            if(usernameText.Text == "" && passwordText.Text == "")
            {
                LogWrite log = new LogWrite("Log in unsuccessful.");
                MessageBox.Show("Username and password fields are empty", "Login failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(l.LoginUser(usernameText.Text, passwordText.Text))
            {
                LogWrite log = new LogWrite(usernameText.Text + " logged in.");
                usernameText.Text = "";
                passwordText.Text = "";
                new Dashboard(l).Show();
                this.Hide();
            }
            else
            {
                LogWrite log = new LogWrite("Log in unsuccessful.");
                MessageBox.Show("Wrong username or password.", "Login failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}