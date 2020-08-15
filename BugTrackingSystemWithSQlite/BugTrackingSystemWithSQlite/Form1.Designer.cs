namespace BugTrackingSystemWithSQlite
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
            this.dgvViewer = new System.Windows.Forms.DataGridView();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Project = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bnAddNameProject = new System.Windows.Forms.Button();
            this.tbProjectName = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolSpFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolSpFileCreate = new System.Windows.Forms.ToolStripMenuItem();
            this.toolSpFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.gbProjects = new System.Windows.Forms.GroupBox();
            this.gbUsers = new System.Windows.Forms.GroupBox();
            this.gbTasks = new System.Windows.Forms.GroupBox();
            this.lbProjectName = new System.Windows.Forms.Label();
            this.bnDeleteProject = new System.Windows.Forms.Button();
            this.lbUserName = new System.Windows.Forms.Label();
            this.bnDeleteUser = new System.Windows.Forms.Button();
            this.bnAddNameUser = new System.Windows.Forms.Button();
            this.tbUserName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewer)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.gbProjects.SuspendLayout();
            this.gbUsers.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvViewer
            // 
            this.dgvViewer.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvViewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number,
            this.Project});
            this.dgvViewer.Location = new System.Drawing.Point(11, 339);
            this.dgvViewer.Name = "dgvViewer";
            this.dgvViewer.RowHeadersWidth = 62;
            this.dgvViewer.Size = new System.Drawing.Size(613, 217);
            this.dgvViewer.TabIndex = 4;
            // 
            // Number
            // 
            this.Number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Number.HeaderText = "Номер";
            this.Number.MinimumWidth = 8;
            this.Number.Name = "Number";
            this.Number.Width = 66;
            // 
            // Project
            // 
            this.Project.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Project.HeaderText = "Наименование проекта";
            this.Project.MinimumWidth = 8;
            this.Project.Name = "Project";
            this.Project.Width = 139;
            // 
            // bnAddNameProject
            // 
            this.bnAddNameProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bnAddNameProject.Location = new System.Drawing.Point(6, 117);
            this.bnAddNameProject.Name = "bnAddNameProject";
            this.bnAddNameProject.Size = new System.Drawing.Size(85, 35);
            this.bnAddNameProject.TabIndex = 6;
            this.bnAddNameProject.Text = "Добавить проект";
            this.bnAddNameProject.UseVisualStyleBackColor = true;
            this.bnAddNameProject.Click += new System.EventHandler(this.bnAddNameProject_Click);
            // 
            // tbProjectName
            // 
            this.tbProjectName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbProjectName.Location = new System.Drawing.Point(6, 76);
            this.tbProjectName.Name = "tbProjectName";
            this.tbProjectName.Size = new System.Drawing.Size(188, 20);
            this.tbProjectName.TabIndex = 7;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolSpFile});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(795, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolSpFile
            // 
            this.toolSpFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolSpFileCreate,
            this.toolSpFileOpen});
            this.toolSpFile.Name = "toolSpFile";
            this.toolSpFile.Size = new System.Drawing.Size(48, 22);
            this.toolSpFile.Text = "Файл";
            // 
            // toolSpFileCreate
            // 
            this.toolSpFileCreate.Name = "toolSpFileCreate";
            this.toolSpFileCreate.Size = new System.Drawing.Size(121, 22);
            this.toolSpFileCreate.Text = "Создать";
            this.toolSpFileCreate.Click += new System.EventHandler(this.toolSpFileCreate_Click);
            // 
            // toolSpFileOpen
            // 
            this.toolSpFileOpen.Name = "toolSpFileOpen";
            this.toolSpFileOpen.Size = new System.Drawing.Size(121, 22);
            this.toolSpFileOpen.Text = "Открыть";
            this.toolSpFileOpen.Click += new System.EventHandler(this.toolSpFileOpen_Click);
            // 
            // gbProjects
            // 
            this.gbProjects.Controls.Add(this.bnDeleteProject);
            this.gbProjects.Controls.Add(this.lbProjectName);
            this.gbProjects.Controls.Add(this.bnAddNameProject);
            this.gbProjects.Controls.Add(this.tbProjectName);
            this.gbProjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbProjects.Location = new System.Drawing.Point(12, 45);
            this.gbProjects.Name = "gbProjects";
            this.gbProjects.Size = new System.Drawing.Size(200, 267);
            this.gbProjects.TabIndex = 11;
            this.gbProjects.TabStop = false;
            this.gbProjects.Text = "ПРОЕКТЫ";
            // 
            // gbUsers
            // 
            this.gbUsers.Controls.Add(this.bnDeleteUser);
            this.gbUsers.Controls.Add(this.lbUserName);
            this.gbUsers.Controls.Add(this.bnAddNameUser);
            this.gbUsers.Controls.Add(this.tbUserName);
            this.gbUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbUsers.Location = new System.Drawing.Point(218, 45);
            this.gbUsers.Name = "gbUsers";
            this.gbUsers.Size = new System.Drawing.Size(200, 267);
            this.gbUsers.TabIndex = 12;
            this.gbUsers.TabStop = false;
            this.gbUsers.Text = "ПОЛЬЗОВАТЕЛИ";
            // 
            // gbTasks
            // 
            this.gbTasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbTasks.Location = new System.Drawing.Point(424, 45);
            this.gbTasks.Name = "gbTasks";
            this.gbTasks.Size = new System.Drawing.Size(200, 267);
            this.gbTasks.TabIndex = 13;
            this.gbTasks.TabStop = false;
            this.gbTasks.Text = "ЗАДАЧИ";
            // 
            // lbProjectName
            // 
            this.lbProjectName.AutoSize = true;
            this.lbProjectName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbProjectName.Location = new System.Drawing.Point(7, 45);
            this.lbProjectName.Name = "lbProjectName";
            this.lbProjectName.Size = new System.Drawing.Size(101, 13);
            this.lbProjectName.TabIndex = 8;
            this.lbProjectName.Text = "Название проекта";
            // 
            // bnDeleteProject
            // 
            this.bnDeleteProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bnDeleteProject.Location = new System.Drawing.Point(109, 117);
            this.bnDeleteProject.Name = "bnDeleteProject";
            this.bnDeleteProject.Size = new System.Drawing.Size(85, 35);
            this.bnDeleteProject.TabIndex = 9;
            this.bnDeleteProject.Text = "Удалить проект";
            this.bnDeleteProject.UseVisualStyleBackColor = true;
            this.bnDeleteProject.Click += new System.EventHandler(this.bnDeleteProject_Click);
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbUserName.Location = new System.Drawing.Point(7, 45);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(103, 13);
            this.lbUserName.TabIndex = 0;
            this.lbUserName.Text = "Имя пользователя";
            // 
            // bnDeleteUser
            // 
            this.bnDeleteUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bnDeleteUser.Location = new System.Drawing.Point(107, 117);
            this.bnDeleteUser.Name = "bnDeleteUser";
            this.bnDeleteUser.Size = new System.Drawing.Size(87, 35);
            this.bnDeleteUser.TabIndex = 12;
            this.bnDeleteUser.Text = "Удалить пользователя";
            this.bnDeleteUser.UseVisualStyleBackColor = true;
            // 
            // bnAddNameUser
            // 
            this.bnAddNameUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bnAddNameUser.Location = new System.Drawing.Point(6, 117);
            this.bnAddNameUser.Name = "bnAddNameUser";
            this.bnAddNameUser.Size = new System.Drawing.Size(87, 35);
            this.bnAddNameUser.TabIndex = 10;
            this.bnAddNameUser.Text = "Добавить пользователя";
            this.bnAddNameUser.UseVisualStyleBackColor = true;
            // 
            // tbUserName
            // 
            this.tbUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbUserName.Location = new System.Drawing.Point(6, 76);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(188, 20);
            this.tbUserName.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 574);
            this.Controls.Add(this.gbTasks);
            this.Controls.Add(this.gbUsers);
            this.Controls.Add(this.gbProjects);
            this.Controls.Add(this.dgvViewer);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Система отслеживания задач/ошибок";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewer)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbProjects.ResumeLayout(false);
            this.gbProjects.PerformLayout();
            this.gbUsers.ResumeLayout(false);
            this.gbUsers.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvViewer;
        private System.Windows.Forms.Button bnAddNameProject;
        private System.Windows.Forms.TextBox tbProjectName;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolSpFile;
        private System.Windows.Forms.ToolStripMenuItem toolSpFileCreate;
        private System.Windows.Forms.ToolStripMenuItem toolSpFileOpen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Project;
        private System.Windows.Forms.GroupBox gbProjects;
        private System.Windows.Forms.Button bnDeleteProject;
        private System.Windows.Forms.Label lbProjectName;
        private System.Windows.Forms.GroupBox gbUsers;
        private System.Windows.Forms.GroupBox gbTasks;
        private System.Windows.Forms.Button bnDeleteUser;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.Button bnAddNameUser;
        private System.Windows.Forms.TextBox tbUserName;
    }
}

