namespace BugTrackingSystemWithExcel
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbProject = new System.Windows.Forms.GroupBox();
            this.gbTask = new System.Windows.Forms.GroupBox();
            this.gbUser = new System.Windows.Forms.GroupBox();
            this.tbProjectName = new System.Windows.Forms.TextBox();
            this.cbProjectSelect = new System.Windows.Forms.ComboBox();
            this.bnAddProject = new System.Windows.Forms.Button();
            this.bnDeleteProject = new System.Windows.Forms.Button();
            this.tbProjectList = new System.Windows.Forms.TextBox();
            this.bnCreateFile = new System.Windows.Forms.Button();
            this.bnOpenFile = new System.Windows.Forms.Button();
            this.gbProject.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbProject
            // 
            this.gbProject.Controls.Add(this.bnDeleteProject);
            this.gbProject.Controls.Add(this.bnAddProject);
            this.gbProject.Controls.Add(this.cbProjectSelect);
            this.gbProject.Controls.Add(this.tbProjectName);
            this.gbProject.Location = new System.Drawing.Point(54, 42);
            this.gbProject.Name = "gbProject";
            this.gbProject.Size = new System.Drawing.Size(200, 228);
            this.gbProject.TabIndex = 3;
            this.gbProject.TabStop = false;
            this.gbProject.Text = "Проект";
            // 
            // gbTask
            // 
            this.gbTask.Location = new System.Drawing.Point(309, 42);
            this.gbTask.Name = "gbTask";
            this.gbTask.Size = new System.Drawing.Size(200, 228);
            this.gbTask.TabIndex = 4;
            this.gbTask.TabStop = false;
            this.gbTask.Text = "Задача";
            // 
            // gbUser
            // 
            this.gbUser.Location = new System.Drawing.Point(562, 42);
            this.gbUser.Name = "gbUser";
            this.gbUser.Size = new System.Drawing.Size(200, 228);
            this.gbUser.TabIndex = 4;
            this.gbUser.TabStop = false;
            this.gbUser.Text = "Пользователь";
            // 
            // tbProjectName
            // 
            this.tbProjectName.Location = new System.Drawing.Point(7, 37);
            this.tbProjectName.Name = "tbProjectName";
            this.tbProjectName.Size = new System.Drawing.Size(100, 20);
            this.tbProjectName.TabIndex = 0;
            // 
            // cbProjectSelect
            // 
            this.cbProjectSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProjectSelect.FormattingEnabled = true;
            this.cbProjectSelect.Location = new System.Drawing.Point(7, 84);
            this.cbProjectSelect.Name = "cbProjectSelect";
            this.cbProjectSelect.Size = new System.Drawing.Size(121, 21);
            this.cbProjectSelect.TabIndex = 1;
            // 
            // bnAddProject
            // 
            this.bnAddProject.Location = new System.Drawing.Point(7, 145);
            this.bnAddProject.Name = "bnAddProject";
            this.bnAddProject.Size = new System.Drawing.Size(75, 23);
            this.bnAddProject.TabIndex = 2;
            this.bnAddProject.Text = "Добавить";
            this.bnAddProject.UseVisualStyleBackColor = true;
            this.bnAddProject.Click += new System.EventHandler(this.bnAddProject_Click);
            // 
            // bnDeleteProject
            // 
            this.bnDeleteProject.Location = new System.Drawing.Point(101, 145);
            this.bnDeleteProject.Name = "bnDeleteProject";
            this.bnDeleteProject.Size = new System.Drawing.Size(75, 23);
            this.bnDeleteProject.TabIndex = 3;
            this.bnDeleteProject.Text = "Удалить";
            this.bnDeleteProject.UseVisualStyleBackColor = true;
            this.bnDeleteProject.Click += new System.EventHandler(this.bnDeleteProject_Click);
            // 
            // tbProjectList
            // 
            this.tbProjectList.Location = new System.Drawing.Point(54, 347);
            this.tbProjectList.Multiline = true;
            this.tbProjectList.Name = "tbProjectList";
            this.tbProjectList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbProjectList.Size = new System.Drawing.Size(200, 201);
            this.tbProjectList.TabIndex = 5;
            // 
            // bnCreateFile
            // 
            this.bnCreateFile.Location = new System.Drawing.Point(309, 347);
            this.bnCreateFile.Name = "bnCreateFile";
            this.bnCreateFile.Size = new System.Drawing.Size(131, 23);
            this.bnCreateFile.TabIndex = 6;
            this.bnCreateFile.Text = "Создать новый файл";
            this.bnCreateFile.UseVisualStyleBackColor = true;
            this.bnCreateFile.Click += new System.EventHandler(this.bnCreateFile_Click);
            // 
            // bnOpenFile
            // 
            this.bnOpenFile.Location = new System.Drawing.Point(467, 345);
            this.bnOpenFile.Name = "bnOpenFile";
            this.bnOpenFile.Size = new System.Drawing.Size(75, 23);
            this.bnOpenFile.TabIndex = 7;
            this.bnOpenFile.Text = "Открыть";
            this.bnOpenFile.UseVisualStyleBackColor = true;
            this.bnOpenFile.Click += new System.EventHandler(this.bnOpenFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 616);
            this.Controls.Add(this.bnOpenFile);
            this.Controls.Add(this.bnCreateFile);
            this.Controls.Add(this.tbProjectList);
            this.Controls.Add(this.gbUser);
            this.Controls.Add(this.gbTask);
            this.Controls.Add(this.gbProject);
            this.Name = "Form1";
            this.Text = "Bug Tracking System";
            this.gbProject.ResumeLayout(false);
            this.gbProject.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbProject;
        private System.Windows.Forms.Button bnDeleteProject;
        private System.Windows.Forms.Button bnAddProject;
        private System.Windows.Forms.ComboBox cbProjectSelect;
        private System.Windows.Forms.TextBox tbProjectName;
        private System.Windows.Forms.GroupBox gbTask;
        private System.Windows.Forms.GroupBox gbUser;
        private System.Windows.Forms.TextBox tbProjectList;
        private System.Windows.Forms.Button bnCreateFile;
        private System.Windows.Forms.Button bnOpenFile;
    }
}

