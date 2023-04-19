namespace Omega
{
    partial class TaskForm
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.deadlineLabel = new System.Windows.Forms.Label();
            this.commentsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(72, 58);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(36, 15);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "None";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(72, 98);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(36, 15);
            this.descriptionLabel.TabIndex = 1;
            this.descriptionLabel.Text = "None";
            // 
            // deadlineLabel
            // 
            this.deadlineLabel.AutoSize = true;
            this.deadlineLabel.Location = new System.Drawing.Point(72, 147);
            this.deadlineLabel.Name = "deadlineLabel";
            this.deadlineLabel.Size = new System.Drawing.Size(36, 15);
            this.deadlineLabel.TabIndex = 2;
            this.deadlineLabel.Text = "None";
            // 
            // commentsButton
            // 
            this.commentsButton.Location = new System.Drawing.Point(72, 186);
            this.commentsButton.Name = "commentsButton";
            this.commentsButton.Size = new System.Drawing.Size(75, 23);
            this.commentsButton.TabIndex = 3;
            this.commentsButton.Text = "Comments";
            this.commentsButton.UseVisualStyleBackColor = true;
            this.commentsButton.Click += new System.EventHandler(this.commentsButton_Click);
            // 
            // TaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 604);
            this.Controls.Add(this.commentsButton);
            this.Controls.Add(this.deadlineLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.titleLabel);
            this.Name = "TaskForm";
            this.Text = "TaskForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TaskForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label titleLabel;
        private Label descriptionLabel;
        private Label deadlineLabel;
        private Button commentsButton;
    }
}