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
            this.bnAddNameProject = new System.Windows.Forms.Button();
            this.tbProjectName = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolSpFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolSpFileCreate = new System.Windows.Forms.ToolStripMenuItem();
            this.toolSpFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.gbProjects = new System.Windows.Forms.GroupBox();
            this.bnDeleteProject = new System.Windows.Forms.Button();
            this.lbProjectName = new System.Windows.Forms.Label();
            this.gbUsers = new System.Windows.Forms.GroupBox();
            this.bnDeleteUser = new System.Windows.Forms.Button();
            this.lbUserName = new System.Windows.Forms.Label();
            this.bnAddNameUser = new System.Windows.Forms.Button();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.gbTasks = new System.Windows.Forms.GroupBox();
            this.bnShowProjects = new System.Windows.Forms.Button();
            this.bnShowUsers = new System.Windows.Forms.Button();
            this.bnShowTasksInProject = new System.Windows.Forms.Button();
            this.bnShowTasksOnUser = new System.Windows.Forms.Button();
            this.idProject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Project = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.User = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewer)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.gbProjects.SuspendLayout();
            this.gbUsers.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvViewer
            // 
            this.dgvViewer.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvViewer.ColumnHeadersHeight = 25;
            this.dgvViewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvViewer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProject,
            this.Project,
            this.idUser,
            this.User});
            this.dgvViewer.Location = new System.Drawing.Point(16, 522);
            this.dgvViewer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvViewer.Name = "dgvViewer";
            this.dgvViewer.RowHeadersWidth = 62;
            this.dgvViewer.Size = new System.Drawing.Size(920, 334);
            this.dgvViewer.TabIndex = 4;
            // 
            // bnAddNameProject
            // 
            this.bnAddNameProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bnAddNameProject.Location = new System.Drawing.Point(9, 180);
            this.bnAddNameProject.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bnAddNameProject.Name = "bnAddNameProject";
            this.bnAddNameProject.Size = new System.Drawing.Size(128, 54);
            this.bnAddNameProject.TabIndex = 6;
            this.bnAddNameProject.Text = "Добавить проект";
            this.bnAddNameProject.UseVisualStyleBackColor = true;
            this.bnAddNameProject.Click += new System.EventHandler(this.bnAddNameProject_Click);
            // 
            // tbProjectName
            // 
            this.tbProjectName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbProjectName.Location = new System.Drawing.Point(9, 117);
            this.tbProjectName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbProjectName.Name = "tbProjectName";
            this.tbProjectName.Size = new System.Drawing.Size(280, 26);
            this.tbProjectName.TabIndex = 7;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolSpFile});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1192, 33);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolSpFile
            // 
            this.toolSpFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolSpFileCreate,
            this.toolSpFileOpen});
            this.toolSpFile.Name = "toolSpFile";
            this.toolSpFile.Size = new System.Drawing.Size(69, 29);
            this.toolSpFile.Text = "Файл";
            // 
            // toolSpFileCreate
            // 
            this.toolSpFileCreate.Name = "toolSpFileCreate";
            this.toolSpFileCreate.Size = new System.Drawing.Size(184, 34);
            this.toolSpFileCreate.Text = "Создать";
            this.toolSpFileCreate.Click += new System.EventHandler(this.toolSpFileCreate_Click);
            // 
            // toolSpFileOpen
            // 
            this.toolSpFileOpen.Name = "toolSpFileOpen";
            this.toolSpFileOpen.Size = new System.Drawing.Size(184, 34);
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
            this.gbProjects.Location = new System.Drawing.Point(18, 69);
            this.gbProjects.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbProjects.Name = "gbProjects";
            this.gbProjects.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbProjects.Size = new System.Drawing.Size(300, 411);
            this.gbProjects.TabIndex = 11;
            this.gbProjects.TabStop = false;
            this.gbProjects.Text = "ПРОЕКТЫ";
            // 
            // bnDeleteProject
            // 
            this.bnDeleteProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bnDeleteProject.Location = new System.Drawing.Point(164, 180);
            this.bnDeleteProject.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bnDeleteProject.Name = "bnDeleteProject";
            this.bnDeleteProject.Size = new System.Drawing.Size(128, 54);
            this.bnDeleteProject.TabIndex = 9;
            this.bnDeleteProject.Text = "Удалить проект";
            this.bnDeleteProject.UseVisualStyleBackColor = true;
            this.bnDeleteProject.Click += new System.EventHandler(this.bnDeleteProject_Click);
            // 
            // lbProjectName
            // 
            this.lbProjectName.AutoSize = true;
            this.lbProjectName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbProjectName.Location = new System.Drawing.Point(10, 69);
            this.lbProjectName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbProjectName.Name = "lbProjectName";
            this.lbProjectName.Size = new System.Drawing.Size(165, 20);
            this.lbProjectName.TabIndex = 8;
            this.lbProjectName.Text = "Название проекта";
            // 
            // gbUsers
            // 
            this.gbUsers.Controls.Add(this.bnDeleteUser);
            this.gbUsers.Controls.Add(this.lbUserName);
            this.gbUsers.Controls.Add(this.bnAddNameUser);
            this.gbUsers.Controls.Add(this.tbUserName);
            this.gbUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbUsers.Location = new System.Drawing.Point(327, 69);
            this.gbUsers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbUsers.Name = "gbUsers";
            this.gbUsers.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbUsers.Size = new System.Drawing.Size(300, 411);
            this.gbUsers.TabIndex = 12;
            this.gbUsers.TabStop = false;
            this.gbUsers.Text = "ПОЛЬЗОВАТЕЛИ";
            // 
            // bnDeleteUser
            // 
            this.bnDeleteUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bnDeleteUser.Location = new System.Drawing.Point(155, 180);
            this.bnDeleteUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bnDeleteUser.Name = "bnDeleteUser";
            this.bnDeleteUser.Size = new System.Drawing.Size(140, 54);
            this.bnDeleteUser.TabIndex = 12;
            this.bnDeleteUser.Text = "Удалить пользователя";
            this.bnDeleteUser.UseVisualStyleBackColor = true;
            this.bnDeleteUser.Click += new System.EventHandler(this.bnDeleteUser_Click);
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbUserName.Location = new System.Drawing.Point(10, 69);
            this.lbUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(166, 20);
            this.lbUserName.TabIndex = 0;
            this.lbUserName.Text = "Имя пользователя";
            // 
            // bnAddNameUser
            // 
            this.bnAddNameUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bnAddNameUser.Location = new System.Drawing.Point(5, 180);
            this.bnAddNameUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bnAddNameUser.Name = "bnAddNameUser";
            this.bnAddNameUser.Size = new System.Drawing.Size(143, 54);
            this.bnAddNameUser.TabIndex = 10;
            this.bnAddNameUser.Text = "Добавить пользователя";
            this.bnAddNameUser.UseVisualStyleBackColor = true;
            this.bnAddNameUser.Click += new System.EventHandler(this.bnAddNameUser_Click);
            // 
            // tbUserName
            // 
            this.tbUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbUserName.Location = new System.Drawing.Point(9, 117);
            this.tbUserName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(280, 26);
            this.tbUserName.TabIndex = 11;
            // 
            // gbTasks
            // 
            this.gbTasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbTasks.Location = new System.Drawing.Point(636, 69);
            this.gbTasks.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbTasks.Name = "gbTasks";
            this.gbTasks.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbTasks.Size = new System.Drawing.Size(300, 411);
            this.gbTasks.TabIndex = 13;
            this.gbTasks.TabStop = false;
            this.gbTasks.Text = "ЗАДАЧИ";
            // 
            // bnShowProjects
            // 
            this.bnShowProjects.Location = new System.Drawing.Point(975, 522);
            this.bnShowProjects.Name = "bnShowProjects";
            this.bnShowProjects.Size = new System.Drawing.Size(205, 65);
            this.bnShowProjects.TabIndex = 14;
            this.bnShowProjects.Text = "Показать список проектов";
            this.bnShowProjects.UseVisualStyleBackColor = true;
            this.bnShowProjects.Click += new System.EventHandler(this.bnShowProjects_Click);
            // 
            // bnShowUsers
            // 
            this.bnShowUsers.Location = new System.Drawing.Point(975, 593);
            this.bnShowUsers.Name = "bnShowUsers";
            this.bnShowUsers.Size = new System.Drawing.Size(205, 65);
            this.bnShowUsers.TabIndex = 15;
            this.bnShowUsers.Text = "Показать список пользователей";
            this.bnShowUsers.UseVisualStyleBackColor = true;
            this.bnShowUsers.Click += new System.EventHandler(this.bnShowUsers_Click);
            // 
            // bnShowTasksInProject
            // 
            this.bnShowTasksInProject.Location = new System.Drawing.Point(975, 664);
            this.bnShowTasksInProject.Name = "bnShowTasksInProject";
            this.bnShowTasksInProject.Size = new System.Drawing.Size(205, 65);
            this.bnShowTasksInProject.TabIndex = 16;
            this.bnShowTasksInProject.Text = "Показать список задач в проекте";
            this.bnShowTasksInProject.UseVisualStyleBackColor = true;
            this.bnShowTasksInProject.Click += new System.EventHandler(this.bnShowTasksInProject_Click);
            // 
            // bnShowTasksOnUser
            // 
            this.bnShowTasksOnUser.Location = new System.Drawing.Point(975, 735);
            this.bnShowTasksOnUser.Name = "bnShowTasksOnUser";
            this.bnShowTasksOnUser.Size = new System.Drawing.Size(205, 65);
            this.bnShowTasksOnUser.TabIndex = 17;
            this.bnShowTasksOnUser.Text = "Показать список задач на исполнителе";
            this.bnShowTasksOnUser.UseVisualStyleBackColor = true;
            this.bnShowTasksOnUser.Click += new System.EventHandler(this.bnShowTasksOnUser_Click);
            // 
            // idProject
            // 
            this.idProject.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.idProject.HeaderText = "Номер";
            this.idProject.MinimumWidth = 8;
            this.idProject.Name = "idProject";
            this.idProject.Visible = false;
            this.idProject.Width = 95;
            // 
            // Project
            // 
            this.Project.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Project.HeaderText = "Наименование проекта";
            this.Project.MinimumWidth = 8;
            this.Project.Name = "Project";
            this.Project.Visible = false;
            this.Project.Width = 224;
            // 
            // idUser
            // 
            this.idUser.HeaderText = "Номер";
            this.idUser.MinimumWidth = 8;
            this.idUser.Name = "idUser";
            this.idUser.Visible = false;
            this.idUser.Width = 150;
            // 
            // User
            // 
            this.User.HeaderText = "Имя пользователя";
            this.User.MinimumWidth = 8;
            this.User.Name = "User";
            this.User.Visible = false;
            this.User.Width = 150;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 883);
            this.Controls.Add(this.bnShowTasksOnUser);
            this.Controls.Add(this.bnShowTasksInProject);
            this.Controls.Add(this.bnShowUsers);
            this.Controls.Add(this.bnShowProjects);
            this.Controls.Add(this.gbTasks);
            this.Controls.Add(this.gbUsers);
            this.Controls.Add(this.gbProjects);
            this.Controls.Add(this.dgvViewer);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
        private System.Windows.Forms.GroupBox gbProjects;
        private System.Windows.Forms.Button bnDeleteProject;
        private System.Windows.Forms.Label lbProjectName;
        private System.Windows.Forms.GroupBox gbUsers;
        private System.Windows.Forms.GroupBox gbTasks;
        private System.Windows.Forms.Button bnDeleteUser;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.Button bnAddNameUser;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.Button bnShowProjects;
        private System.Windows.Forms.Button bnShowUsers;
        private System.Windows.Forms.Button bnShowTasksInProject;
        private System.Windows.Forms.Button bnShowTasksOnUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProject;
        private System.Windows.Forms.DataGridViewTextBoxColumn Project;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn User;
    }
}

