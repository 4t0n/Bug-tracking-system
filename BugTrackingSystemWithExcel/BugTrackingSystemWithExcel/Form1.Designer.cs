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
            this.bnDeleteProject = new System.Windows.Forms.Button();
            this.bnAddProject = new System.Windows.Forms.Button();
            this.cbProjectSelect = new System.Windows.Forms.ComboBox();
            this.tbProjectName = new System.Windows.Forms.TextBox();
            this.gbTask = new System.Windows.Forms.GroupBox();
            this.cbTaskSelect = new System.Windows.Forms.ComboBox();
            this.bnDeleteTask = new System.Windows.Forms.Button();
            this.bnAddTask = new System.Windows.Forms.Button();
            this.tbTaskDescription = new System.Windows.Forms.TextBox();
            this.cbTaskUser = new System.Windows.Forms.ComboBox();
            this.tbTaskPriority = new System.Windows.Forms.TextBox();
            this.tbTaskType = new System.Windows.Forms.TextBox();
            this.tbTaskTheme = new System.Windows.Forms.TextBox();
            this.cbTaskProject = new System.Windows.Forms.ComboBox();
            this.lbTaskDescription = new System.Windows.Forms.Label();
            this.lbTaskUser = new System.Windows.Forms.Label();
            this.lbTaskPriority = new System.Windows.Forms.Label();
            this.lbTaskType = new System.Windows.Forms.Label();
            this.lbTaskTheme = new System.Windows.Forms.Label();
            this.lbTaskProjec = new System.Windows.Forms.Label();
            this.gbUser = new System.Windows.Forms.GroupBox();
            this.bnDeleteUser = new System.Windows.Forms.Button();
            this.bnAddUser = new System.Windows.Forms.Button();
            this.cbUserSelect = new System.Windows.Forms.ComboBox();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.tbList = new System.Windows.Forms.TextBox();
            this.bnCreateFile = new System.Windows.Forms.Button();
            this.bnOpenFile = new System.Windows.Forms.Button();
            this.bnGetUsers = new System.Windows.Forms.Button();
            this.bnGetProjects = new System.Windows.Forms.Button();
            this.bnGetTasksInProject = new System.Windows.Forms.Button();
            this.bnGetTaskOfUser = new System.Windows.Forms.Button();
            this.cbTasksInProject = new System.Windows.Forms.ComboBox();
            this.cbTaskOfUsers = new System.Windows.Forms.ComboBox();
            this.gbProject.SuspendLayout();
            this.gbTask.SuspendLayout();
            this.gbUser.SuspendLayout();
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
            // cbProjectSelect
            // 
            this.cbProjectSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProjectSelect.FormattingEnabled = true;
            this.cbProjectSelect.Location = new System.Drawing.Point(7, 84);
            this.cbProjectSelect.Name = "cbProjectSelect";
            this.cbProjectSelect.Size = new System.Drawing.Size(121, 21);
            this.cbProjectSelect.TabIndex = 1;
            // 
            // tbProjectName
            // 
            this.tbProjectName.Location = new System.Drawing.Point(7, 37);
            this.tbProjectName.Name = "tbProjectName";
            this.tbProjectName.Size = new System.Drawing.Size(100, 20);
            this.tbProjectName.TabIndex = 0;
            // 
            // gbTask
            // 
            this.gbTask.Controls.Add(this.cbTaskSelect);
            this.gbTask.Controls.Add(this.bnDeleteTask);
            this.gbTask.Controls.Add(this.bnAddTask);
            this.gbTask.Controls.Add(this.tbTaskDescription);
            this.gbTask.Controls.Add(this.cbTaskUser);
            this.gbTask.Controls.Add(this.tbTaskPriority);
            this.gbTask.Controls.Add(this.tbTaskType);
            this.gbTask.Controls.Add(this.tbTaskTheme);
            this.gbTask.Controls.Add(this.cbTaskProject);
            this.gbTask.Controls.Add(this.lbTaskDescription);
            this.gbTask.Controls.Add(this.lbTaskUser);
            this.gbTask.Controls.Add(this.lbTaskPriority);
            this.gbTask.Controls.Add(this.lbTaskType);
            this.gbTask.Controls.Add(this.lbTaskTheme);
            this.gbTask.Controls.Add(this.lbTaskProjec);
            this.gbTask.Location = new System.Drawing.Point(309, 42);
            this.gbTask.Name = "gbTask";
            this.gbTask.Size = new System.Drawing.Size(229, 460);
            this.gbTask.TabIndex = 4;
            this.gbTask.TabStop = false;
            this.gbTask.Text = "Задача";
            // 
            // cbTaskSelect
            // 
            this.cbTaskSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTaskSelect.FormattingEnabled = true;
            this.cbTaskSelect.Location = new System.Drawing.Point(102, 421);
            this.cbTaskSelect.Name = "cbTaskSelect";
            this.cbTaskSelect.Size = new System.Drawing.Size(121, 21);
            this.cbTaskSelect.TabIndex = 14;
            // 
            // bnDeleteTask
            // 
            this.bnDeleteTask.Location = new System.Drawing.Point(10, 421);
            this.bnDeleteTask.Name = "bnDeleteTask";
            this.bnDeleteTask.Size = new System.Drawing.Size(75, 23);
            this.bnDeleteTask.TabIndex = 13;
            this.bnDeleteTask.Text = "Удалить";
            this.bnDeleteTask.UseVisualStyleBackColor = true;
            this.bnDeleteTask.Click += new System.EventHandler(this.bnDeleteTask_Click);
            // 
            // bnAddTask
            // 
            this.bnAddTask.Location = new System.Drawing.Point(10, 369);
            this.bnAddTask.Name = "bnAddTask";
            this.bnAddTask.Size = new System.Drawing.Size(75, 23);
            this.bnAddTask.TabIndex = 12;
            this.bnAddTask.Text = "Добавить";
            this.bnAddTask.UseVisualStyleBackColor = true;
            this.bnAddTask.Click += new System.EventHandler(this.bnAddTask_Click);
            // 
            // tbTaskDescription
            // 
            this.tbTaskDescription.Location = new System.Drawing.Point(10, 322);
            this.tbTaskDescription.Name = "tbTaskDescription";
            this.tbTaskDescription.Size = new System.Drawing.Size(100, 20);
            this.tbTaskDescription.TabIndex = 11;
            // 
            // cbTaskUser
            // 
            this.cbTaskUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTaskUser.FormattingEnabled = true;
            this.cbTaskUser.Location = new System.Drawing.Point(10, 267);
            this.cbTaskUser.Name = "cbTaskUser";
            this.cbTaskUser.Size = new System.Drawing.Size(121, 21);
            this.cbTaskUser.TabIndex = 10;
            // 
            // tbTaskPriority
            // 
            this.tbTaskPriority.Location = new System.Drawing.Point(10, 215);
            this.tbTaskPriority.Name = "tbTaskPriority";
            this.tbTaskPriority.Size = new System.Drawing.Size(100, 20);
            this.tbTaskPriority.TabIndex = 9;
            // 
            // tbTaskType
            // 
            this.tbTaskType.Location = new System.Drawing.Point(10, 171);
            this.tbTaskType.Name = "tbTaskType";
            this.tbTaskType.Size = new System.Drawing.Size(100, 20);
            this.tbTaskType.TabIndex = 8;
            // 
            // tbTaskTheme
            // 
            this.tbTaskTheme.Location = new System.Drawing.Point(10, 122);
            this.tbTaskTheme.Name = "tbTaskTheme";
            this.tbTaskTheme.Size = new System.Drawing.Size(100, 20);
            this.tbTaskTheme.TabIndex = 7;
            // 
            // cbTaskProject
            // 
            this.cbTaskProject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTaskProject.FormattingEnabled = true;
            this.cbTaskProject.Location = new System.Drawing.Point(10, 75);
            this.cbTaskProject.Name = "cbTaskProject";
            this.cbTaskProject.Size = new System.Drawing.Size(121, 21);
            this.cbTaskProject.TabIndex = 6;
            // 
            // lbTaskDescription
            // 
            this.lbTaskDescription.AutoSize = true;
            this.lbTaskDescription.Location = new System.Drawing.Point(7, 305);
            this.lbTaskDescription.Name = "lbTaskDescription";
            this.lbTaskDescription.Size = new System.Drawing.Size(57, 13);
            this.lbTaskDescription.TabIndex = 5;
            this.lbTaskDescription.Text = "Описание";
            // 
            // lbTaskUser
            // 
            this.lbTaskUser.AutoSize = true;
            this.lbTaskUser.Location = new System.Drawing.Point(7, 250);
            this.lbTaskUser.Name = "lbTaskUser";
            this.lbTaskUser.Size = new System.Drawing.Size(74, 13);
            this.lbTaskUser.TabIndex = 4;
            this.lbTaskUser.Text = "Исполнитель";
            // 
            // lbTaskPriority
            // 
            this.lbTaskPriority.AutoSize = true;
            this.lbTaskPriority.Location = new System.Drawing.Point(7, 198);
            this.lbTaskPriority.Name = "lbTaskPriority";
            this.lbTaskPriority.Size = new System.Drawing.Size(61, 13);
            this.lbTaskPriority.TabIndex = 3;
            this.lbTaskPriority.Text = "Приоритет";
            // 
            // lbTaskType
            // 
            this.lbTaskType.AutoSize = true;
            this.lbTaskType.Location = new System.Drawing.Point(7, 154);
            this.lbTaskType.Name = "lbTaskType";
            this.lbTaskType.Size = new System.Drawing.Size(26, 13);
            this.lbTaskType.TabIndex = 2;
            this.lbTaskType.Text = "Тип";
            // 
            // lbTaskTheme
            // 
            this.lbTaskTheme.AutoSize = true;
            this.lbTaskTheme.Location = new System.Drawing.Point(6, 105);
            this.lbTaskTheme.Name = "lbTaskTheme";
            this.lbTaskTheme.Size = new System.Drawing.Size(34, 13);
            this.lbTaskTheme.TabIndex = 1;
            this.lbTaskTheme.Text = "Тема";
            // 
            // lbTaskProjec
            // 
            this.lbTaskProjec.AutoSize = true;
            this.lbTaskProjec.Location = new System.Drawing.Point(7, 49);
            this.lbTaskProjec.Name = "lbTaskProjec";
            this.lbTaskProjec.Size = new System.Drawing.Size(44, 13);
            this.lbTaskProjec.TabIndex = 0;
            this.lbTaskProjec.Text = "Проект";
            // 
            // gbUser
            // 
            this.gbUser.Controls.Add(this.bnDeleteUser);
            this.gbUser.Controls.Add(this.bnAddUser);
            this.gbUser.Controls.Add(this.cbUserSelect);
            this.gbUser.Controls.Add(this.tbUserName);
            this.gbUser.Location = new System.Drawing.Point(562, 42);
            this.gbUser.Name = "gbUser";
            this.gbUser.Size = new System.Drawing.Size(211, 228);
            this.gbUser.TabIndex = 4;
            this.gbUser.TabStop = false;
            this.gbUser.Text = "Пользователь";
            // 
            // bnDeleteUser
            // 
            this.bnDeleteUser.Location = new System.Drawing.Point(119, 145);
            this.bnDeleteUser.Name = "bnDeleteUser";
            this.bnDeleteUser.Size = new System.Drawing.Size(75, 23);
            this.bnDeleteUser.TabIndex = 3;
            this.bnDeleteUser.Text = "Удалить";
            this.bnDeleteUser.UseVisualStyleBackColor = true;
            this.bnDeleteUser.Click += new System.EventHandler(this.bnDeleteUser_Click);
            // 
            // bnAddUser
            // 
            this.bnAddUser.Location = new System.Drawing.Point(20, 145);
            this.bnAddUser.Name = "bnAddUser";
            this.bnAddUser.Size = new System.Drawing.Size(75, 23);
            this.bnAddUser.TabIndex = 2;
            this.bnAddUser.Text = "Добавить";
            this.bnAddUser.UseVisualStyleBackColor = true;
            this.bnAddUser.Click += new System.EventHandler(this.bnAddUser_Click);
            // 
            // cbUserSelect
            // 
            this.cbUserSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUserSelect.FormattingEnabled = true;
            this.cbUserSelect.Location = new System.Drawing.Point(20, 84);
            this.cbUserSelect.Name = "cbUserSelect";
            this.cbUserSelect.Size = new System.Drawing.Size(121, 21);
            this.cbUserSelect.TabIndex = 1;
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(20, 37);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(100, 20);
            this.tbUserName.TabIndex = 0;
            // 
            // tbList
            // 
            this.tbList.Location = new System.Drawing.Point(828, 42);
            this.tbList.Multiline = true;
            this.tbList.Name = "tbList";
            this.tbList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbList.Size = new System.Drawing.Size(389, 201);
            this.tbList.TabIndex = 5;
            // 
            // bnCreateFile
            // 
            this.bnCreateFile.Location = new System.Drawing.Point(544, 347);
            this.bnCreateFile.Name = "bnCreateFile";
            this.bnCreateFile.Size = new System.Drawing.Size(131, 23);
            this.bnCreateFile.TabIndex = 6;
            this.bnCreateFile.Text = "Создать новый файл";
            this.bnCreateFile.UseVisualStyleBackColor = true;
            this.bnCreateFile.Click += new System.EventHandler(this.bnCreateFile_Click);
            // 
            // bnOpenFile
            // 
            this.bnOpenFile.Location = new System.Drawing.Point(698, 345);
            this.bnOpenFile.Name = "bnOpenFile";
            this.bnOpenFile.Size = new System.Drawing.Size(75, 23);
            this.bnOpenFile.TabIndex = 7;
            this.bnOpenFile.Text = "Открыть";
            this.bnOpenFile.UseVisualStyleBackColor = true;
            this.bnOpenFile.Click += new System.EventHandler(this.bnOpenFile_Click);
            // 
            // bnGetUsers
            // 
            this.bnGetUsers.Location = new System.Drawing.Point(828, 281);
            this.bnGetUsers.Name = "bnGetUsers";
            this.bnGetUsers.Size = new System.Drawing.Size(169, 23);
            this.bnGetUsers.TabIndex = 8;
            this.bnGetUsers.Text = "Список пользователей";
            this.bnGetUsers.UseVisualStyleBackColor = true;
            this.bnGetUsers.Click += new System.EventHandler(this.bnGetUsers_Click);
            // 
            // bnGetProjects
            // 
            this.bnGetProjects.Location = new System.Drawing.Point(828, 337);
            this.bnGetProjects.Name = "bnGetProjects";
            this.bnGetProjects.Size = new System.Drawing.Size(169, 23);
            this.bnGetProjects.TabIndex = 9;
            this.bnGetProjects.Text = "Список проектов";
            this.bnGetProjects.UseVisualStyleBackColor = true;
            this.bnGetProjects.Click += new System.EventHandler(this.bnGetProjects_Click);
            // 
            // bnGetTasksInProject
            // 
            this.bnGetTasksInProject.Location = new System.Drawing.Point(828, 391);
            this.bnGetTasksInProject.Name = "bnGetTasksInProject";
            this.bnGetTasksInProject.Size = new System.Drawing.Size(169, 23);
            this.bnGetTasksInProject.TabIndex = 10;
            this.bnGetTasksInProject.Text = "Список задач в проекте";
            this.bnGetTasksInProject.UseVisualStyleBackColor = true;
            // 
            // bnGetTaskOfUser
            // 
            this.bnGetTaskOfUser.Location = new System.Drawing.Point(828, 447);
            this.bnGetTaskOfUser.Name = "bnGetTaskOfUser";
            this.bnGetTaskOfUser.Size = new System.Drawing.Size(169, 23);
            this.bnGetTaskOfUser.TabIndex = 11;
            this.bnGetTaskOfUser.Text = "Список задач на исполнителе";
            this.bnGetTaskOfUser.UseVisualStyleBackColor = true;
            // 
            // cbTasksInProject
            // 
            this.cbTasksInProject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTasksInProject.FormattingEnabled = true;
            this.cbTasksInProject.Location = new System.Drawing.Point(1041, 391);
            this.cbTasksInProject.Name = "cbTasksInProject";
            this.cbTasksInProject.Size = new System.Drawing.Size(121, 21);
            this.cbTasksInProject.TabIndex = 12;
            // 
            // cbTaskOfUsers
            // 
            this.cbTaskOfUsers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTaskOfUsers.FormattingEnabled = true;
            this.cbTaskOfUsers.Location = new System.Drawing.Point(1041, 447);
            this.cbTaskOfUsers.Name = "cbTaskOfUsers";
            this.cbTaskOfUsers.Size = new System.Drawing.Size(121, 21);
            this.cbTaskOfUsers.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1296, 616);
            this.Controls.Add(this.cbTaskOfUsers);
            this.Controls.Add(this.cbTasksInProject);
            this.Controls.Add(this.bnGetTaskOfUser);
            this.Controls.Add(this.bnGetTasksInProject);
            this.Controls.Add(this.bnGetProjects);
            this.Controls.Add(this.bnGetUsers);
            this.Controls.Add(this.bnOpenFile);
            this.Controls.Add(this.bnCreateFile);
            this.Controls.Add(this.tbList);
            this.Controls.Add(this.gbUser);
            this.Controls.Add(this.gbTask);
            this.Controls.Add(this.gbProject);
            this.Name = "Form1";
            this.Text = "Bug Tracking System";
            this.gbProject.ResumeLayout(false);
            this.gbProject.PerformLayout();
            this.gbTask.ResumeLayout(false);
            this.gbTask.PerformLayout();
            this.gbUser.ResumeLayout(false);
            this.gbUser.PerformLayout();
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
        private System.Windows.Forms.TextBox tbList;
        private System.Windows.Forms.Button bnCreateFile;
        private System.Windows.Forms.Button bnOpenFile;
        private System.Windows.Forms.Button bnDeleteUser;
        private System.Windows.Forms.Button bnAddUser;
        private System.Windows.Forms.ComboBox cbUserSelect;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.TextBox tbTaskDescription;
        private System.Windows.Forms.ComboBox cbTaskUser;
        private System.Windows.Forms.TextBox tbTaskPriority;
        private System.Windows.Forms.TextBox tbTaskType;
        private System.Windows.Forms.TextBox tbTaskTheme;
        private System.Windows.Forms.ComboBox cbTaskProject;
        private System.Windows.Forms.Label lbTaskDescription;
        private System.Windows.Forms.Label lbTaskUser;
        private System.Windows.Forms.Label lbTaskPriority;
        private System.Windows.Forms.Label lbTaskType;
        private System.Windows.Forms.Label lbTaskTheme;
        private System.Windows.Forms.Label lbTaskProjec;
        private System.Windows.Forms.ComboBox cbTaskSelect;
        private System.Windows.Forms.Button bnDeleteTask;
        private System.Windows.Forms.Button bnAddTask;
        private System.Windows.Forms.Button bnGetUsers;
        private System.Windows.Forms.Button bnGetProjects;
        private System.Windows.Forms.Button bnGetTasksInProject;
        private System.Windows.Forms.Button bnGetTaskOfUser;
        private System.Windows.Forms.ComboBox cbTasksInProject;
        private System.Windows.Forms.ComboBox cbTaskOfUsers;
    }
}

