namespace Omega
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.passLabel = new System.Windows.Forms.Label();
            this.firstNameText = new System.Windows.Forms.TextBox();
            this.lastNameText = new System.Windows.Forms.TextBox();
            this.usernameText = new System.Windows.Forms.TextBox();
            this.emailText = new System.Windows.Forms.TextBox();
            this.passText = new System.Windows.Forms.TextBox();
            this.saveChangButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(12, 45);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(64, 15);
            this.firstNameLabel.TabIndex = 0;
            this.firstNameLabel.Text = "First Name";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(12, 84);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(63, 15);
            this.lastNameLabel.TabIndex = 1;
            this.lastNameLabel.Text = "Last Name";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(12, 123);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(60, 15);
            this.usernameLabel.TabIndex = 2;
            this.usernameLabel.Text = "Username";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(12, 157);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(36, 15);
            this.emailLabel.TabIndex = 3;
            this.emailLabel.Text = "Email";
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.Location = new System.Drawing.Point(12, 191);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(57, 15);
            this.passLabel.TabIndex = 4;
            this.passLabel.Text = "Password";
            // 
            // firstNameText
            // 
            this.firstNameText.Location = new System.Drawing.Point(106, 37);
            this.firstNameText.Name = "firstNameText";
            this.firstNameText.Size = new System.Drawing.Size(100, 23);
            this.firstNameText.TabIndex = 5;
            // 
            // lastNameText
            // 
            this.lastNameText.Location = new System.Drawing.Point(106, 76);
            this.lastNameText.Name = "lastNameText";
            this.lastNameText.Size = new System.Drawing.Size(100, 23);
            this.lastNameText.TabIndex = 6;
            // 
            // usernameText
            // 
            this.usernameText.Location = new System.Drawing.Point(106, 115);
            this.usernameText.Name = "usernameText";
            this.usernameText.Size = new System.Drawing.Size(100, 23);
            this.usernameText.TabIndex = 7;
            // 
            // emailText
            // 
            this.emailText.Location = new System.Drawing.Point(106, 149);
            this.emailText.Name = "emailText";
            this.emailText.Size = new System.Drawing.Size(100, 23);
            this.emailText.TabIndex = 8;
            // 
            // passText
            // 
            this.passText.Location = new System.Drawing.Point(106, 183);
            this.passText.Name = "passText";
            this.passText.Size = new System.Drawing.Size(100, 23);
            this.passText.TabIndex = 9;
            // 
            // saveChangButton
            // 
            this.saveChangButton.Location = new System.Drawing.Point(12, 237);
            this.saveChangButton.Name = "saveChangButton";
            this.saveChangButton.Size = new System.Drawing.Size(194, 23);
            this.saveChangButton.TabIndex = 10;
            this.saveChangButton.Text = "Save Changes";
            this.saveChangButton.UseVisualStyleBackColor = true;
            this.saveChangButton.Click += new System.EventHandler(this.saveChangButton_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.saveChangButton);
            this.Controls.Add(this.passText);
            this.Controls.Add(this.emailText);
            this.Controls.Add(this.usernameText);
            this.Controls.Add(this.lastNameText);
            this.Controls.Add(this.firstNameText);
            this.Controls.Add(this.passLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label firstNameLabel;
        private Label lastNameLabel;
        private Label usernameLabel;
        private Label emailLabel;
        private Label passLabel;
        private TextBox firstNameText;
        private TextBox lastNameText;
        private TextBox usernameText;
        private TextBox emailText;
        private TextBox passText;
        private Button saveChangButton;
    }
}