namespace BugTrackingSystemWithSQlite
{
    partial class FormDeleteProject
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
            this.lbTitleProject = new System.Windows.Forms.Label();
            this.cbProjectNameForDelete = new System.Windows.Forms.ComboBox();
            this.bnDeleteProject = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbTitleProject
            // 
            this.lbTitleProject.Location = new System.Drawing.Point(18, 75);
            this.lbTitleProject.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTitleProject.Name = "lbTitleProject";
            this.lbTitleProject.Size = new System.Drawing.Size(420, 20);
            this.lbTitleProject.TabIndex = 0;
            this.lbTitleProject.Text = "Выберите проект, который нужно удалить.";
            this.lbTitleProject.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbProjectNameForDelete
            // 
            this.cbProjectNameForDelete.FormattingEnabled = true;
            this.cbProjectNameForDelete.Location = new System.Drawing.Point(22, 140);
            this.cbProjectNameForDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbProjectNameForDelete.Name = "cbProjectNameForDelete";
            this.cbProjectNameForDelete.Size = new System.Drawing.Size(414, 28);
            this.cbProjectNameForDelete.TabIndex = 1;
            // 
            // bnDeleteProject
            // 
            this.bnDeleteProject.Location = new System.Drawing.Point(170, 225);
            this.bnDeleteProject.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bnDeleteProject.Name = "bnDeleteProject";
            this.bnDeleteProject.Size = new System.Drawing.Size(112, 35);
            this.bnDeleteProject.TabIndex = 2;
            this.bnDeleteProject.Text = "Удалить";
            this.bnDeleteProject.UseVisualStyleBackColor = true;
            this.bnDeleteProject.Click += new System.EventHandler(this.bnDeleteProject_Click);
            // 
            // FormDeleteProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 304);
            this.Controls.Add(this.bnDeleteProject);
            this.Controls.Add(this.cbProjectNameForDelete);
            this.Controls.Add(this.lbTitleProject);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormDeleteProject";
            this.Text = "Удаление проекта";
            this.Load += new System.EventHandler(this.FormDeleteProject_Load_1);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbTitleProject;
        private System.Windows.Forms.ComboBox cbProjectNameForDelete;
        private System.Windows.Forms.Button bnDeleteProject;
    }
}