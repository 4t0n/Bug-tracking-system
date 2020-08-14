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
            this.lbForlbStatus = new System.Windows.Forms.Label();
            this.lbConnectStatus = new System.Windows.Forms.Label();
            this.bnCreateDB = new System.Windows.Forms.Button();
            this.bnConnectFile = new System.Windows.Forms.Button();
            this.dgvViewer = new System.Windows.Forms.DataGridView();
            this.bnReadAll = new System.Windows.Forms.Button();
            this.bnAddData = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Project = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewer)).BeginInit();
            this.SuspendLayout();
            // 
            // lbForlbStatus
            // 
            this.lbForlbStatus.AutoSize = true;
            this.lbForlbStatus.Location = new System.Drawing.Point(25, 408);
            this.lbForlbStatus.Name = "lbForlbStatus";
            this.lbForlbStatus.Size = new System.Drawing.Size(44, 13);
            this.lbForlbStatus.TabIndex = 0;
            this.lbForlbStatus.Text = "Статус:";
            // 
            // lbConnectStatus
            // 
            this.lbConnectStatus.AutoSize = true;
            this.lbConnectStatus.Location = new System.Drawing.Point(86, 408);
            this.lbConnectStatus.Name = "lbConnectStatus";
            this.lbConnectStatus.Size = new System.Drawing.Size(0, 13);
            this.lbConnectStatus.TabIndex = 1;
            // 
            // bnCreateDB
            // 
            this.bnCreateDB.Location = new System.Drawing.Point(39, 35);
            this.bnCreateDB.Name = "bnCreateDB";
            this.bnCreateDB.Size = new System.Drawing.Size(105, 23);
            this.bnCreateDB.TabIndex = 2;
            this.bnCreateDB.Text = "Создать файл";
            this.bnCreateDB.UseVisualStyleBackColor = true;
            this.bnCreateDB.Click += new System.EventHandler(this.bnCreateDB_Click);
            // 
            // bnConnectFile
            // 
            this.bnConnectFile.Location = new System.Drawing.Point(183, 34);
            this.bnConnectFile.Name = "bnConnectFile";
            this.bnConnectFile.Size = new System.Drawing.Size(132, 23);
            this.bnConnectFile.TabIndex = 3;
            this.bnConnectFile.Text = "Подключиться к файлу";
            this.bnConnectFile.UseVisualStyleBackColor = true;
            this.bnConnectFile.Click += new System.EventHandler(this.bnConnectFile_Click);
            // 
            // dgvViewer
            // 
            this.dgvViewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number,
            this.Project});
            this.dgvViewer.Location = new System.Drawing.Point(39, 124);
            this.dgvViewer.Name = "dgvViewer";
            this.dgvViewer.Size = new System.Drawing.Size(649, 258);
            this.dgvViewer.TabIndex = 4;
            // 
            // bnReadAll
            // 
            this.bnReadAll.Location = new System.Drawing.Point(356, 35);
            this.bnReadAll.Name = "bnReadAll";
            this.bnReadAll.Size = new System.Drawing.Size(92, 23);
            this.bnReadAll.TabIndex = 5;
            this.bnReadAll.Text = "Прочитать всё";
            this.bnReadAll.UseVisualStyleBackColor = true;
            this.bnReadAll.Click += new System.EventHandler(this.bnReadAll_Click);
            // 
            // bnAddData
            // 
            this.bnAddData.Location = new System.Drawing.Point(483, 35);
            this.bnAddData.Name = "bnAddData";
            this.bnAddData.Size = new System.Drawing.Size(109, 23);
            this.bnAddData.TabIndex = 6;
            this.bnAddData.Text = "Добавить данные";
            this.bnAddData.UseVisualStyleBackColor = true;
            this.bnAddData.Click += new System.EventHandler(this.bnAddData_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(483, 82);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(600, 82);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 8;
            // 
            // Number
            // 
            this.Number.HeaderText = "Номер";
            this.Number.Name = "Number";
            // 
            // Project
            // 
            this.Project.HeaderText = "Наименование проекта";
            this.Project.Name = "Project";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(356, 523);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 674);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.bnAddData);
            this.Controls.Add(this.bnReadAll);
            this.Controls.Add(this.dgvViewer);
            this.Controls.Add(this.bnConnectFile);
            this.Controls.Add(this.bnCreateDB);
            this.Controls.Add(this.lbConnectStatus);
            this.Controls.Add(this.lbForlbStatus);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbForlbStatus;
        private System.Windows.Forms.Label lbConnectStatus;
        private System.Windows.Forms.Button bnCreateDB;
        private System.Windows.Forms.Button bnConnectFile;
        private System.Windows.Forms.DataGridView dgvViewer;
        private System.Windows.Forms.Button bnReadAll;
        private System.Windows.Forms.Button bnAddData;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Project;
        private System.Windows.Forms.Button button1;
    }
}

