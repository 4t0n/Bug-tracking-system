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
            this.bnCreateDB = new System.Windows.Forms.Button();
            this.dgvViewer = new System.Windows.Forms.DataGridView();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Project = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bnReadAll = new System.Windows.Forms.Button();
            this.bnAddData = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolSpFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolSpFileCreate = new System.Windows.Forms.ToolStripMenuItem();
            this.toolSpFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewer)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bnCreateDB
            // 
            this.bnCreateDB.Location = new System.Drawing.Point(100, 52);
            this.bnCreateDB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bnCreateDB.Name = "bnCreateDB";
            this.bnCreateDB.Size = new System.Drawing.Size(158, 35);
            this.bnCreateDB.TabIndex = 2;
            this.bnCreateDB.Text = "Создать файл";
            this.bnCreateDB.UseVisualStyleBackColor = true;
            this.bnCreateDB.Click += new System.EventHandler(this.bnCreateDB_Click);
            // 
            // dgvViewer
            // 
            this.dgvViewer.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvViewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number,
            this.Project});
            this.dgvViewer.Location = new System.Drawing.Point(13, 172);
            this.dgvViewer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvViewer.Name = "dgvViewer";
            this.dgvViewer.RowHeadersWidth = 62;
            this.dgvViewer.Size = new System.Drawing.Size(871, 306);
            this.dgvViewer.TabIndex = 4;
            // 
            // Number
            // 
            this.Number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Number.HeaderText = "Номер";
            this.Number.MinimumWidth = 8;
            this.Number.Name = "Number";
            this.Number.Width = 95;
            // 
            // Project
            // 
            this.Project.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Project.HeaderText = "Наименование проекта";
            this.Project.MinimumWidth = 8;
            this.Project.Name = "Project";
            this.Project.Width = 205;
            // 
            // bnReadAll
            // 
            this.bnReadAll.Location = new System.Drawing.Point(534, 54);
            this.bnReadAll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bnReadAll.Name = "bnReadAll";
            this.bnReadAll.Size = new System.Drawing.Size(138, 35);
            this.bnReadAll.TabIndex = 5;
            this.bnReadAll.Text = "Прочитать всё";
            this.bnReadAll.UseVisualStyleBackColor = true;
            this.bnReadAll.Click += new System.EventHandler(this.bnReadAll_Click);
            // 
            // bnAddData
            // 
            this.bnAddData.Location = new System.Drawing.Point(724, 54);
            this.bnAddData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bnAddData.Name = "bnAddData";
            this.bnAddData.Size = new System.Drawing.Size(164, 35);
            this.bnAddData.TabIndex = 6;
            this.bnAddData.Text = "Добавить данные";
            this.bnAddData.UseVisualStyleBackColor = true;
            this.bnAddData.Click += new System.EventHandler(this.bnAddData_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(724, 126);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(148, 26);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(900, 126);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(148, 26);
            this.textBox2.TabIndex = 8;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolSpFile});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1206, 33);
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
            this.toolSpFileCreate.Size = new System.Drawing.Size(270, 34);
            this.toolSpFileCreate.Text = "Создать";
            this.toolSpFileCreate.Click += new System.EventHandler(this.toolSpFileCreate_Click);
            // 
            // toolSpFileOpen
            // 
            this.toolSpFileOpen.Name = "toolSpFileOpen";
            this.toolSpFileOpen.Size = new System.Drawing.Size(270, 34);
            this.toolSpFileOpen.Text = "Открыть";
            this.toolSpFileOpen.Click += new System.EventHandler(this.toolSpFileOpen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 874);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.bnAddData);
            this.Controls.Add(this.bnReadAll);
            this.Controls.Add(this.dgvViewer);
            this.Controls.Add(this.bnCreateDB);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Система отслеживания задач/ошибок";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewer)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bnCreateDB;
        private System.Windows.Forms.DataGridView dgvViewer;
        private System.Windows.Forms.Button bnReadAll;
        private System.Windows.Forms.Button bnAddData;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolSpFile;
        private System.Windows.Forms.ToolStripMenuItem toolSpFileCreate;
        private System.Windows.Forms.ToolStripMenuItem toolSpFileOpen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Project;
    }
}

