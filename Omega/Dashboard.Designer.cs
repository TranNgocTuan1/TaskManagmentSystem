namespace Omega
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.employeeButton = new System.Windows.Forms.Button();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.settingsButton = new System.Windows.Forms.Button();
            this.logOut = new System.Windows.Forms.Button();
            this.finishedTasksButton = new System.Windows.Forms.Button();
            this.projectsButton = new System.Windows.Forms.Button();
            this.dashboardButton = new System.Windows.Forms.Button();
            this.formPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.employeeButton);
            this.panel1.Controls.Add(this.welcomeLabel);
            this.panel1.Controls.Add(this.logo);
            this.panel1.Controls.Add(this.settingsButton);
            this.panel1.Controls.Add(this.logOut);
            this.panel1.Controls.Add(this.finishedTasksButton);
            this.panel1.Controls.Add(this.projectsButton);
            this.panel1.Controls.Add(this.dashboardButton);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(187, 674);
            this.panel1.TabIndex = 0;
            // 
            // employeeButton
            // 
            this.employeeButton.Location = new System.Drawing.Point(0, 256);
            this.employeeButton.Name = "employeeButton";
            this.employeeButton.Size = new System.Drawing.Size(187, 23);
            this.employeeButton.TabIndex = 7;
            this.employeeButton.Text = "Employees";
            this.employeeButton.UseVisualStyleBackColor = true;
            this.employeeButton.Click += new System.EventHandler(this.employeeButton_Click);
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Location = new System.Drawing.Point(48, 103);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(57, 15);
            this.welcomeLabel.TabIndex = 6;
            this.welcomeLabel.Text = "Welcome";
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(48, 12);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(82, 88);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.logo.TabIndex = 5;
            this.logo.TabStop = false;
            // 
            // settingsButton
            // 
            this.settingsButton.Location = new System.Drawing.Point(0, 606);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(187, 23);
            this.settingsButton.TabIndex = 4;
            this.settingsButton.Text = "Settings";
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // logOut
            // 
            this.logOut.Location = new System.Drawing.Point(0, 635);
            this.logOut.Name = "logOut";
            this.logOut.Size = new System.Drawing.Size(187, 23);
            this.logOut.TabIndex = 3;
            this.logOut.Text = "Log Out";
            this.logOut.UseVisualStyleBackColor = true;
            this.logOut.Click += new System.EventHandler(this.logOut_Click);
            // 
            // finishedTasksButton
            // 
            this.finishedTasksButton.Location = new System.Drawing.Point(0, 227);
            this.finishedTasksButton.Name = "finishedTasksButton";
            this.finishedTasksButton.Size = new System.Drawing.Size(187, 23);
            this.finishedTasksButton.TabIndex = 2;
            this.finishedTasksButton.Text = "Fineshed Tasks";
            this.finishedTasksButton.UseVisualStyleBackColor = true;
            this.finishedTasksButton.Click += new System.EventHandler(this.finishedTasksButton_Click);
            // 
            // projectsButton
            // 
            this.projectsButton.Location = new System.Drawing.Point(0, 198);
            this.projectsButton.Name = "projectsButton";
            this.projectsButton.Size = new System.Drawing.Size(187, 23);
            this.projectsButton.TabIndex = 1;
            this.projectsButton.Text = "Projects";
            this.projectsButton.UseVisualStyleBackColor = true;
            this.projectsButton.Click += new System.EventHandler(this.projectsButton_Click);
            // 
            // dashboardButton
            // 
            this.dashboardButton.Location = new System.Drawing.Point(0, 169);
            this.dashboardButton.Name = "dashboardButton";
            this.dashboardButton.Size = new System.Drawing.Size(187, 23);
            this.dashboardButton.TabIndex = 0;
            this.dashboardButton.Text = "Dashboard";
            this.dashboardButton.UseVisualStyleBackColor = true;
            this.dashboardButton.Click += new System.EventHandler(this.dashboardButton_Click);
            // 
            // formPanel
            // 
            this.formPanel.Location = new System.Drawing.Point(193, 12);
            this.formPanel.Name = "formPanel";
            this.formPanel.Size = new System.Drawing.Size(832, 568);
            this.formPanel.TabIndex = 1;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 704);
            this.Controls.Add(this.formPanel);
            this.Controls.Add(this.panel1);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Dashboard_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button dashboardButton;
        private Button projectsButton;
        private Panel formPanel;
        private Button finishedTasksButton;
        private Button logOut;
        private Button settingsButton;
        private Label welcomeLabel;
        private PictureBox logo;
        private Button employeeButton;
    }
}