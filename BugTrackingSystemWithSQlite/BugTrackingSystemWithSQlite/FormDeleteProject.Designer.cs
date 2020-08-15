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
            this.lbTitle = new System.Windows.Forms.Label();
            this.cbProjectNameForDelete = new System.Windows.Forms.ComboBox();
            this.bnDeleteProject = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.Location = new System.Drawing.Point(12, 49);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(280, 13);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "Выберите проект, который нужно удалить.";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbProjectNameForDelete
            // 
            this.cbProjectNameForDelete.FormattingEnabled = true;
            this.cbProjectNameForDelete.Location = new System.Drawing.Point(15, 91);
            this.cbProjectNameForDelete.Name = "cbProjectNameForDelete";
            this.cbProjectNameForDelete.Size = new System.Drawing.Size(277, 21);
            this.cbProjectNameForDelete.TabIndex = 1;
            // 
            // bnDeleteProject
            // 
            this.bnDeleteProject.Location = new System.Drawing.Point(113, 146);
            this.bnDeleteProject.Name = "bnDeleteProject";
            this.bnDeleteProject.Size = new System.Drawing.Size(75, 23);
            this.bnDeleteProject.TabIndex = 2;
            this.bnDeleteProject.Text = "Удалить";
            this.bnDeleteProject.UseVisualStyleBackColor = true;
            // 
            // FormDeleteProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 200);
            this.Controls.Add(this.bnDeleteProject);
            this.Controls.Add(this.cbProjectNameForDelete);
            this.Controls.Add(this.lbTitle);
            this.Name = "FormDeleteProject";
            this.Text = "Удаление проекта";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.ComboBox cbProjectNameForDelete;
        private System.Windows.Forms.Button bnDeleteProject;
    }
}