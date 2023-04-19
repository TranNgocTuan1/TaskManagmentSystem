namespace Omega
{
    partial class AddTaskForm
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
            this.taskNameText = new System.Windows.Forms.TextBox();
            this.descriptionText = new System.Windows.Forms.RichTextBox();
            this.deadlineTime = new System.Windows.Forms.DateTimePicker();
            this.empoyeBox = new System.Windows.Forms.ComboBox();
            this.projectBox = new System.Windows.Forms.ComboBox();
            this.addTaskButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.projectLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // taskNameText
            // 
            this.taskNameText.Location = new System.Drawing.Point(122, 73);
            this.taskNameText.Name = "taskNameText";
            this.taskNameText.Size = new System.Drawing.Size(364, 23);
            this.taskNameText.TabIndex = 0;
            // 
            // descriptionText
            // 
            this.descriptionText.Location = new System.Drawing.Point(122, 117);
            this.descriptionText.Name = "descriptionText";
            this.descriptionText.Size = new System.Drawing.Size(364, 96);
            this.descriptionText.TabIndex = 1;
            this.descriptionText.Text = "";
            // 
            // deadlineTime
            // 
            this.deadlineTime.Location = new System.Drawing.Point(122, 235);
            this.deadlineTime.Name = "deadlineTime";
            this.deadlineTime.Size = new System.Drawing.Size(364, 23);
            this.deadlineTime.TabIndex = 2;
            // 
            // empoyeBox
            // 
            this.empoyeBox.FormattingEnabled = true;
            this.empoyeBox.Location = new System.Drawing.Point(122, 30);
            this.empoyeBox.Name = "empoyeBox";
            this.empoyeBox.Size = new System.Drawing.Size(364, 23);
            this.empoyeBox.TabIndex = 3;
            // 
            // projectBox
            // 
            this.projectBox.FormattingEnabled = true;
            this.projectBox.Location = new System.Drawing.Point(122, 286);
            this.projectBox.Name = "projectBox";
            this.projectBox.Size = new System.Drawing.Size(364, 23);
            this.projectBox.TabIndex = 4;
            // 
            // addTaskButton
            // 
            this.addTaskButton.Location = new System.Drawing.Point(12, 391);
            this.addTaskButton.Name = "addTaskButton";
            this.addTaskButton.Size = new System.Drawing.Size(474, 23);
            this.addTaskButton.TabIndex = 5;
            this.addTaskButton.Text = "Add";
            this.addTaskButton.UseVisualStyleBackColor = true;
            this.addTaskButton.Click += new System.EventHandler(this.addTaskButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "User";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Title";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Uzivatel";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Deadline";
            // 
            // projectLabel
            // 
            this.projectLabel.AutoSize = true;
            this.projectLabel.Location = new System.Drawing.Point(12, 294);
            this.projectLabel.Name = "projectLabel";
            this.projectLabel.Size = new System.Drawing.Size(44, 15);
            this.projectLabel.TabIndex = 10;
            this.projectLabel.Text = "Project";
            // 
            // AddTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 477);
            this.Controls.Add(this.projectLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addTaskButton);
            this.Controls.Add(this.projectBox);
            this.Controls.Add(this.empoyeBox);
            this.Controls.Add(this.deadlineTime);
            this.Controls.Add(this.descriptionText);
            this.Controls.Add(this.taskNameText);
            this.Name = "AddTaskForm";
            this.Text = "AddTaskForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox taskNameText;
        private RichTextBox descriptionText;
        private DateTimePicker deadlineTime;
        private ComboBox empoyeBox;
        private ComboBox projectBox;
        private Button addTaskButton;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label projectLabel;
    }
}