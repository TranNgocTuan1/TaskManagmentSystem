namespace Omega
{
    partial class CommentsForm
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
            this.commentsBox = new System.Windows.Forms.RichTextBox();
            this.newCommentText = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // commentsBox
            // 
            this.commentsBox.Location = new System.Drawing.Point(12, 12);
            this.commentsBox.Name = "commentsBox";
            this.commentsBox.Size = new System.Drawing.Size(776, 247);
            this.commentsBox.TabIndex = 0;
            this.commentsBox.Text = "";
            // 
            // newCommentText
            // 
            this.newCommentText.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.newCommentText.Location = new System.Drawing.Point(12, 278);
            this.newCommentText.Name = "newCommentText";
            this.newCommentText.Size = new System.Drawing.Size(590, 33);
            this.newCommentText.TabIndex = 1;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(608, 278);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(180, 33);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // CommentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.newCommentText);
            this.Controls.Add(this.commentsBox);
            this.Name = "CommentsForm";
            this.Text = "CommentsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextBox commentsBox;
        private TextBox newCommentText;
        private Button addButton;
    }
}