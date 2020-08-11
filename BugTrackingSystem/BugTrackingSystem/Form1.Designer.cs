namespace BugTrackingSystem
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
            this.cbProjectForTask = new System.Windows.Forms.ComboBox();
            this.cbProjectForUser = new System.Windows.Forms.ComboBox();
            this.bnAddProject = new System.Windows.Forms.Button();
            this.bnDeleteProject = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.lbProject = new System.Windows.Forms.Label();
            this.lbTask = new System.Windows.Forms.Label();
            this.lbUser = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.bnGetUsers = new System.Windows.Forms.Button();
            this.bnGetProjects = new System.Windows.Forms.Button();
            this.bnGetTasksInProject = new System.Windows.Forms.Button();
            this.bnGetTasksForUser = new System.Windows.Forms.Button();
            this.tbList = new System.Windows.Forms.TextBox();
            this.tbProjectName = new System.Windows.Forms.TextBox();
            this.tbTaskName = new System.Windows.Forms.TextBox();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.cbTaskForUser = new System.Windows.Forms.ComboBox();
            this.bnClear = new System.Windows.Forms.Button();
            this.cbProjectName = new System.Windows.Forms.ComboBox();
            this.cbProjectsForButton = new System.Windows.Forms.ComboBox();
            this.cbUsersForButton = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cbProjectForTask
            // 
            this.cbProjectForTask.FormattingEnabled = true;
            this.cbProjectForTask.Location = new System.Drawing.Point(257, 126);
            this.cbProjectForTask.Name = "cbProjectForTask";
            this.cbProjectForTask.Size = new System.Drawing.Size(167, 21);
            this.cbProjectForTask.TabIndex = 0;
            // 
            // cbProjectForUser
            // 
            this.cbProjectForUser.FormattingEnabled = true;
            this.cbProjectForUser.Location = new System.Drawing.Point(459, 127);
            this.cbProjectForUser.Name = "cbProjectForUser";
            this.cbProjectForUser.Size = new System.Drawing.Size(167, 21);
            this.cbProjectForUser.TabIndex = 1;
            // 
            // bnAddProject
            // 
            this.bnAddProject.Location = new System.Drawing.Point(55, 75);
            this.bnAddProject.Name = "bnAddProject";
            this.bnAddProject.Size = new System.Drawing.Size(75, 23);
            this.bnAddProject.TabIndex = 2;
            this.bnAddProject.Text = "Добавить";
            this.bnAddProject.UseVisualStyleBackColor = true;
            this.bnAddProject.Click += new System.EventHandler(this.button1_Click);
            // 
            // bnDeleteProject
            // 
            this.bnDeleteProject.Location = new System.Drawing.Point(147, 75);
            this.bnDeleteProject.Name = "bnDeleteProject";
            this.bnDeleteProject.Size = new System.Drawing.Size(75, 23);
            this.bnDeleteProject.TabIndex = 3;
            this.bnDeleteProject.Text = "Удалить";
            this.bnDeleteProject.UseVisualStyleBackColor = true;
            this.bnDeleteProject.Click += new System.EventHandler(this.bnDeleteProject_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(349, 75);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(257, 75);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "Добавить";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // lbProject
            // 
            this.lbProject.AutoSize = true;
            this.lbProject.Location = new System.Drawing.Point(52, 27);
            this.lbProject.Name = "lbProject";
            this.lbProject.Size = new System.Drawing.Size(52, 13);
            this.lbProject.TabIndex = 6;
            this.lbProject.Text = "Проекты";
            // 
            // lbTask
            // 
            this.lbTask.AutoSize = true;
            this.lbTask.Location = new System.Drawing.Point(254, 27);
            this.lbTask.Name = "lbTask";
            this.lbTask.Size = new System.Drawing.Size(43, 13);
            this.lbTask.TabIndex = 7;
            this.lbTask.Text = "Задачи";
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.Location = new System.Drawing.Point(456, 27);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(80, 13);
            this.lbUser.TabIndex = 8;
            this.lbUser.Text = "Пользователи";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(551, 75);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 10;
            this.button5.Text = "Удалить";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(459, 75);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 9;
            this.button6.Text = "Добавить";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // bnGetUsers
            // 
            this.bnGetUsers.Location = new System.Drawing.Point(55, 447);
            this.bnGetUsers.Name = "bnGetUsers";
            this.bnGetUsers.Size = new System.Drawing.Size(185, 23);
            this.bnGetUsers.TabIndex = 11;
            this.bnGetUsers.Text = "Список пользователей";
            this.bnGetUsers.UseVisualStyleBackColor = true;
            // 
            // bnGetProjects
            // 
            this.bnGetProjects.Location = new System.Drawing.Point(55, 476);
            this.bnGetProjects.Name = "bnGetProjects";
            this.bnGetProjects.Size = new System.Drawing.Size(185, 23);
            this.bnGetProjects.TabIndex = 12;
            this.bnGetProjects.Text = "Список проектов";
            this.bnGetProjects.UseVisualStyleBackColor = true;
            this.bnGetProjects.Click += new System.EventHandler(this.button8_Click);
            // 
            // bnGetTasksInProject
            // 
            this.bnGetTasksInProject.Location = new System.Drawing.Point(55, 505);
            this.bnGetTasksInProject.Name = "bnGetTasksInProject";
            this.bnGetTasksInProject.Size = new System.Drawing.Size(185, 23);
            this.bnGetTasksInProject.TabIndex = 13;
            this.bnGetTasksInProject.Text = "Список задач в проекте";
            this.bnGetTasksInProject.UseVisualStyleBackColor = true;
            // 
            // bnGetTasksForUser
            // 
            this.bnGetTasksForUser.Location = new System.Drawing.Point(55, 534);
            this.bnGetTasksForUser.Name = "bnGetTasksForUser";
            this.bnGetTasksForUser.Size = new System.Drawing.Size(185, 23);
            this.bnGetTasksForUser.TabIndex = 14;
            this.bnGetTasksForUser.Text = "Список задач для исполнителя";
            this.bnGetTasksForUser.UseVisualStyleBackColor = true;
            // 
            // tbList
            // 
            this.tbList.Location = new System.Drawing.Point(55, 235);
            this.tbList.Multiline = true;
            this.tbList.Name = "tbList";
            this.tbList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbList.Size = new System.Drawing.Size(379, 196);
            this.tbList.TabIndex = 15;
            // 
            // tbProjectName
            // 
            this.tbProjectName.Location = new System.Drawing.Point(55, 127);
            this.tbProjectName.Name = "tbProjectName";
            this.tbProjectName.Size = new System.Drawing.Size(100, 20);
            this.tbProjectName.TabIndex = 16;
            // 
            // tbTaskName
            // 
            this.tbTaskName.Location = new System.Drawing.Point(257, 162);
            this.tbTaskName.Name = "tbTaskName";
            this.tbTaskName.Size = new System.Drawing.Size(100, 20);
            this.tbTaskName.TabIndex = 17;
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(459, 198);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(100, 20);
            this.tbUserName.TabIndex = 18;
            // 
            // cbTaskForUser
            // 
            this.cbTaskForUser.FormattingEnabled = true;
            this.cbTaskForUser.Location = new System.Drawing.Point(459, 161);
            this.cbTaskForUser.Name = "cbTaskForUser";
            this.cbTaskForUser.Size = new System.Drawing.Size(167, 21);
            this.cbTaskForUser.TabIndex = 19;
            // 
            // bnClear
            // 
            this.bnClear.Location = new System.Drawing.Point(257, 447);
            this.bnClear.Name = "bnClear";
            this.bnClear.Size = new System.Drawing.Size(75, 23);
            this.bnClear.TabIndex = 20;
            this.bnClear.Text = "Очистить";
            this.bnClear.UseVisualStyleBackColor = true;
            // 
            // cbProjectName
            // 
            this.cbProjectName.FormattingEnabled = true;
            this.cbProjectName.Location = new System.Drawing.Point(55, 162);
            this.cbProjectName.Name = "cbProjectName";
            this.cbProjectName.Size = new System.Drawing.Size(167, 21);
            this.cbProjectName.TabIndex = 21;
            // 
            // cbProjectsForButton
            // 
            this.cbProjectsForButton.FormattingEnabled = true;
            this.cbProjectsForButton.Location = new System.Drawing.Point(257, 507);
            this.cbProjectsForButton.Name = "cbProjectsForButton";
            this.cbProjectsForButton.Size = new System.Drawing.Size(121, 21);
            this.cbProjectsForButton.TabIndex = 22;
            // 
            // cbUsersForButton
            // 
            this.cbUsersForButton.FormattingEnabled = true;
            this.cbUsersForButton.Location = new System.Drawing.Point(257, 536);
            this.cbUsersForButton.Name = "cbUsersForButton";
            this.cbUsersForButton.Size = new System.Drawing.Size(121, 21);
            this.cbUsersForButton.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 613);
            this.Controls.Add(this.cbUsersForButton);
            this.Controls.Add(this.cbProjectsForButton);
            this.Controls.Add(this.cbProjectName);
            this.Controls.Add(this.bnClear);
            this.Controls.Add(this.cbTaskForUser);
            this.Controls.Add(this.tbUserName);
            this.Controls.Add(this.tbTaskName);
            this.Controls.Add(this.tbProjectName);
            this.Controls.Add(this.tbList);
            this.Controls.Add(this.bnGetTasksForUser);
            this.Controls.Add(this.bnGetTasksInProject);
            this.Controls.Add(this.bnGetProjects);
            this.Controls.Add(this.bnGetUsers);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.lbUser);
            this.Controls.Add(this.lbTask);
            this.Controls.Add(this.lbProject);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.bnDeleteProject);
            this.Controls.Add(this.bnAddProject);
            this.Controls.Add(this.cbProjectForUser);
            this.Controls.Add(this.cbProjectForTask);
            this.Name = "Form1";
            this.Text = "Bug Tracking System";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbProjectForTask;
        private System.Windows.Forms.ComboBox cbProjectForUser;
        private System.Windows.Forms.Button bnAddProject;
        private System.Windows.Forms.Button bnDeleteProject;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label lbProject;
        private System.Windows.Forms.Label lbTask;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button bnGetUsers;
        private System.Windows.Forms.Button bnGetProjects;
        private System.Windows.Forms.Button bnGetTasksInProject;
        private System.Windows.Forms.Button bnGetTasksForUser;
        private System.Windows.Forms.TextBox tbList;
        private System.Windows.Forms.TextBox tbProjectName;
        private System.Windows.Forms.TextBox tbTaskName;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.ComboBox cbTaskForUser;
        private System.Windows.Forms.Button bnClear;
        private System.Windows.Forms.ComboBox cbProjectName;
        private System.Windows.Forms.ComboBox cbProjectsForButton;
        private System.Windows.Forms.ComboBox cbUsersForButton;
    }
}

