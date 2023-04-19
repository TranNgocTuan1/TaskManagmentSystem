namespace Omega
{
    partial class AddProjectForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addTaskButton = new System.Windows.Forms.Button();
            this.deadlineTime = new System.Windows.Forms.DateTimePicker();
            this.descriptionText = new System.Windows.Forms.RichTextBox();
            this.projectNameText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 15);
            this.label4.TabIndex = 20;
            this.label4.Text = "Deadline";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 19;
            this.label3.Text = "Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "Name";
            // 
            // addTaskButton
            // 
            this.addTaskButton.Location = new System.Drawing.Point(13, 377);
            this.addTaskButton.Name = "addTaskButton";
            this.addTaskButton.Size = new System.Drawing.Size(474, 23);
            this.addTaskButton.TabIndex = 16;
            this.addTaskButton.Text = "Add";
            this.addTaskButton.UseVisualStyleBackColor = true;
            this.addTaskButton.Click += new System.EventHandler(this.addTaskButton_Click);
            // 
            // deadlineTime
            // 
            this.deadlineTime.Location = new System.Drawing.Point(123, 221);
            this.deadlineTime.Name = "deadlineTime";
            this.deadlineTime.Size = new System.Drawing.Size(364, 23);
            this.deadlineTime.TabIndex = 13;
            // 
            // descriptionText
            // 
            this.descriptionText.Location = new System.Drawing.Point(123, 103);
            this.descriptionText.Name = "descriptionText";
            this.descriptionText.Size = new System.Drawing.Size(364, 96);
            this.descriptionText.TabIndex = 12;
            this.descriptionText.Text = "";
            // 
            // projectNameText
            // 
            this.projectNameText.Location = new System.Drawing.Point(123, 59);
            this.projectNameText.Name = "projectNameText";
            this.projectNameText.Size = new System.Drawing.Size(364, 23);
            this.projectNameText.TabIndex = 11;
            // 
            // AddProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 436);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addTaskButton);
            this.Controls.Add(this.deadlineTime);
            this.Controls.Add(this.descriptionText);
            this.Controls.Add(this.projectNameText);
            this.Name = "AddProjectForm";
            this.Text = "AddProjectForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label4;
        private Label label3;
        private Label label2;
        private Button addTaskButton;
        private DateTimePicker deadlineTime;
        private RichTextBox descriptionText;
        private TextBox projectNameText;
    }
}