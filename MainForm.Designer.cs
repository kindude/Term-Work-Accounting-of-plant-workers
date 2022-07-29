
namespace Kursach
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.WorkshopAddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WorkerAddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SalaryAddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.цехToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.работникToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.зарплатаToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.цехToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.работникToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.зарплатаToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.DiagramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(493, 41);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(680, 199);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(107, 316);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(1067, 258);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteCustomSource.AddRange(new string[] {
            "Цех № 1",
            "Цех № 2",
            "Цех № 3",
            "Добавить цех"});
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 100);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(352, 31);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(121, 172);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 50);
            this.button1.TabIndex = 3;
            this.button1.Text = "Удалить текущий цех";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(493, 245);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(169, 44);
            this.button2.TabIndex = 4;
            this.button2.Text = "Добавить работника";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(779, 245);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(147, 44);
            this.button3.TabIndex = 5;
            this.button3.Text = "Редактировать";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Enabled = false;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(1003, 245);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(171, 44);
            this.button4.TabIndex = 6;
            this.button4.Text = "Удалить работника";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Enabled = false;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(285, 578);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(164, 50);
            this.button5.TabIndex = 7;
            this.button5.Text = "Назначить зарплату";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Enabled = false;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(493, 578);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(264, 50);
            this.button6.TabIndex = 8;
            this.button6.Text = "Редактировать параметры зарплаты";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Enabled = false;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Location = new System.Drawing.Point(812, 578);
            this.button7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(173, 50);
            this.button7.TabIndex = 9;
            this.button7.Text = "Удалить зарплату";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 39);
            this.label1.TabIndex = 10;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.DataToolStripMenuItem,
            this.DiagramToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1184, 28);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateToolStripMenuItem,
            this.OpenToolStripMenuItem,
            this.SaveToolStripMenuItem,
            this.SaveAsToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.FileToolStripMenuItem.Text = "Файл";
            // 
            // CreateToolStripMenuItem
            // 
            this.CreateToolStripMenuItem.Name = "CreateToolStripMenuItem";
            this.CreateToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.CreateToolStripMenuItem.Text = "Создать";
            this.CreateToolStripMenuItem.Click += new System.EventHandler(this.создатьToolStripMenuItem_Click);
            // 
            // OpenToolStripMenuItem
            // 
            this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            this.OpenToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.OpenToolStripMenuItem.Text = "Открыть";
            this.OpenToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.Enabled = false;
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.SaveToolStripMenuItem.Text = "Сохранить";
            this.SaveToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // SaveAsToolStripMenuItem
            // 
            this.SaveAsToolStripMenuItem.Enabled = false;
            this.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem";
            this.SaveAsToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.SaveAsToolStripMenuItem.Text = "Сохранить как";
            this.SaveAsToolStripMenuItem.Click += new System.EventHandler(this.сохранитьКакToolStripMenuItem_Click);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.ExitToolStripMenuItem.Text = "Выход";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // DataToolStripMenuItem
            // 
            this.DataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ViewToolStripMenuItem,
            this.AddToolStripMenuItem1,
            this.DeleteToolStripMenuItem,
            this.EditToolStripMenuItem});
            this.DataToolStripMenuItem.Name = "DataToolStripMenuItem";
            this.DataToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.DataToolStripMenuItem.Text = "Запись";
            // 
            // ViewToolStripMenuItem
            // 
            this.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem";
            this.ViewToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.ViewToolStripMenuItem.Text = "Просмотр";
            this.ViewToolStripMenuItem.Click += new System.EventHandler(this.добавитьToolStripMenuItem_Click);
            // 
            // AddToolStripMenuItem1
            // 
            this.AddToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.WorkshopAddToolStripMenuItem,
            this.WorkerAddToolStripMenuItem,
            this.SalaryAddToolStripMenuItem});
            this.AddToolStripMenuItem1.Enabled = false;
            this.AddToolStripMenuItem1.Name = "AddToolStripMenuItem1";
            this.AddToolStripMenuItem1.Size = new System.Drawing.Size(206, 26);
            this.AddToolStripMenuItem1.Text = "Добавить";
            // 
            // WorkshopAddToolStripMenuItem
            // 
            this.WorkshopAddToolStripMenuItem.Name = "WorkshopAddToolStripMenuItem";
            this.WorkshopAddToolStripMenuItem.Size = new System.Drawing.Size(157, 26);
            this.WorkshopAddToolStripMenuItem.Text = "Цех";
            this.WorkshopAddToolStripMenuItem.Click += new System.EventHandler(this.цехToolStripMenuItem_Click_1);
            // 
            // WorkerAddToolStripMenuItem
            // 
            this.WorkerAddToolStripMenuItem.Name = "WorkerAddToolStripMenuItem";
            this.WorkerAddToolStripMenuItem.Size = new System.Drawing.Size(157, 26);
            this.WorkerAddToolStripMenuItem.Text = "Работник";
            // 
            // SalaryAddToolStripMenuItem
            // 
            this.SalaryAddToolStripMenuItem.Name = "SalaryAddToolStripMenuItem";
            this.SalaryAddToolStripMenuItem.Size = new System.Drawing.Size(157, 26);
            this.SalaryAddToolStripMenuItem.Text = "Зарплата";
            // 
            // DeleteToolStripMenuItem
            // 
            this.DeleteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.цехToolStripMenuItem1,
            this.работникToolStripMenuItem1,
            this.зарплатаToolStripMenuItem1});
            this.DeleteToolStripMenuItem.Enabled = false;
            this.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
            this.DeleteToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.DeleteToolStripMenuItem.Text = "Удалить";
            // 
            // цехToolStripMenuItem1
            // 
            this.цехToolStripMenuItem1.Name = "цехToolStripMenuItem1";
            this.цехToolStripMenuItem1.Size = new System.Drawing.Size(157, 26);
            this.цехToolStripMenuItem1.Text = "Цех";
            // 
            // работникToolStripMenuItem1
            // 
            this.работникToolStripMenuItem1.Name = "работникToolStripMenuItem1";
            this.работникToolStripMenuItem1.Size = new System.Drawing.Size(157, 26);
            this.работникToolStripMenuItem1.Text = "Работник";
            // 
            // зарплатаToolStripMenuItem1
            // 
            this.зарплатаToolStripMenuItem1.Name = "зарплатаToolStripMenuItem1";
            this.зарплатаToolStripMenuItem1.Size = new System.Drawing.Size(157, 26);
            this.зарплатаToolStripMenuItem1.Text = "Зарплата";
            // 
            // EditToolStripMenuItem
            // 
            this.EditToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.цехToolStripMenuItem2,
            this.работникToolStripMenuItem2,
            this.зарплатаToolStripMenuItem2});
            this.EditToolStripMenuItem.Enabled = false;
            this.EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            this.EditToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.EditToolStripMenuItem.Text = "Корректировать";
            // 
            // цехToolStripMenuItem2
            // 
            this.цехToolStripMenuItem2.Name = "цехToolStripMenuItem2";
            this.цехToolStripMenuItem2.Size = new System.Drawing.Size(157, 26);
            this.цехToolStripMenuItem2.Text = "Цех ";
            this.цехToolStripMenuItem2.Click += new System.EventHandler(this.цехToolStripMenuItem2_Click_1);
            // 
            // работникToolStripMenuItem2
            // 
            this.работникToolStripMenuItem2.Name = "работникToolStripMenuItem2";
            this.работникToolStripMenuItem2.Size = new System.Drawing.Size(157, 26);
            this.работникToolStripMenuItem2.Text = "Работник";
            // 
            // зарплатаToolStripMenuItem2
            // 
            this.зарплатаToolStripMenuItem2.Name = "зарплатаToolStripMenuItem2";
            this.зарплатаToolStripMenuItem2.Size = new System.Drawing.Size(157, 26);
            this.зарплатаToolStripMenuItem2.Text = "Зарплата";
            // 
            // DiagramToolStripMenuItem
            // 
            this.DiagramToolStripMenuItem.Enabled = false;
            this.DiagramToolStripMenuItem.Name = "DiagramToolStripMenuItem";
            this.DiagramToolStripMenuItem.Size = new System.Drawing.Size(103, 24);
            this.DiagramToolStripMenuItem.Text = "Диаграмма";
            this.DiagramToolStripMenuItem.Click += new System.EventHandler(this.диаграммаToolStripMenuItem_Click_1);
            // 
            // button8
            // 
            this.button8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button8.BackgroundImage")));
            this.button8.Enabled = false;
            this.button8.Location = new System.Drawing.Point(21, 331);
            this.button8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(80, 73);
            this.button8.TabIndex = 12;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button9.BackgroundImage")));
            this.button9.Enabled = false;
            this.button9.Location = new System.Drawing.Point(403, 47);
            this.button9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(85, 69);
            this.button9.TabIndex = 13;
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button10.BackgroundImage")));
            this.button10.Enabled = false;
            this.button10.Location = new System.Drawing.Point(23, 465);
            this.button10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(79, 68);
            this.button10.TabIndex = 14;
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button11.BackgroundImage")));
            this.button11.Enabled = false;
            this.button11.Location = new System.Drawing.Point(403, 172);
            this.button11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(85, 68);
            this.button11.TabIndex = 15;
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1184, 638);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(1202, 685);
            this.MinimumSize = new System.Drawing.Size(1202, 685);
            this.Name = "MainForm";
            this.Text = "Учет работников";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CreateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem DeleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DiagramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem WorkshopAddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem WorkerAddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SalaryAddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem цехToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem работникToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem зарплатаToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem цехToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem работникToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem зарплатаToolStripMenuItem2;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}