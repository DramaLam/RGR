namespace RGR
{
    partial class ManagerForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.автомобилиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокВсехАвтомобилейToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьНовыйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.клиентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокКлиентовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заявкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.listView3 = new System.Windows.Forms.ListView();
            this.label5 = new System.Windows.Forms.Label();
            this.columnHeader9 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader10 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader11 = new System.Windows.Forms.ColumnHeader();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.Location = new System.Drawing.Point(12, 59);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(328, 493);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "№";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "ФИО";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Дата регистрации";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.автомобилиToolStripMenuItem,
            this.клиентыToolStripMenuItem,
            this.заявкиToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1054, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // автомобилиToolStripMenuItem
            // 
            this.автомобилиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.списокВсехАвтомобилейToolStripMenuItem,
            this.добавитьНовыйToolStripMenuItem});
            this.автомобилиToolStripMenuItem.Name = "автомобилиToolStripMenuItem";
            this.автомобилиToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.автомобилиToolStripMenuItem.Text = "Автомобили";
            // 
            // списокВсехАвтомобилейToolStripMenuItem
            // 
            this.списокВсехАвтомобилейToolStripMenuItem.Name = "списокВсехАвтомобилейToolStripMenuItem";
            this.списокВсехАвтомобилейToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.списокВсехАвтомобилейToolStripMenuItem.Text = "Список всех автомобилей";
            this.списокВсехАвтомобилейToolStripMenuItem.Click += new System.EventHandler(this.списокВсехАвтомобилейToolStripMenuItem_Click);
            // 
            // добавитьНовыйToolStripMenuItem
            // 
            this.добавитьНовыйToolStripMenuItem.Name = "добавитьНовыйToolStripMenuItem";
            this.добавитьНовыйToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.добавитьНовыйToolStripMenuItem.Text = "Добавить новый";
            this.добавитьНовыйToolStripMenuItem.Click += new System.EventHandler(this.добавитьНовыйToolStripMenuItem_Click);
            // 
            // клиентыToolStripMenuItem
            // 
            this.клиентыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.списокКлиентовToolStripMenuItem});
            this.клиентыToolStripMenuItem.Name = "клиентыToolStripMenuItem";
            this.клиентыToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.клиентыToolStripMenuItem.Text = "Клиенты";
            // 
            // списокКлиентовToolStripMenuItem
            // 
            this.списокКлиентовToolStripMenuItem.Name = "списокКлиентовToolStripMenuItem";
            this.списокКлиентовToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.списокКлиентовToolStripMenuItem.Text = "Список клиентов";
            this.списокКлиентовToolStripMenuItem.Click += new System.EventHandler(this.списокКлиентовToolStripMenuItem_Click);
            // 
            // заявкиToolStripMenuItem
            // 
            this.заявкиToolStripMenuItem.Name = "заявкиToolStripMenuItem";
            this.заявкиToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.заявкиToolStripMenuItem.Text = "Заявки";
            this.заявкиToolStripMenuItem.Click += new System.EventHandler(this.заявкиToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(23, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Зарегистрированные клиенты за этот год";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.listView2.Location = new System.Drawing.Point(363, 59);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(680, 250);
            this.listView2.TabIndex = 4;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "№ автомобиля";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Модель";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Марка";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "ФИО клиента";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Счет за ремонт";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(582, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(288, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Данные о поврежденных автомобилях";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Location = new System.Drawing.Point(75, 561);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 31);
            this.button1.TabIndex = 6;
            this.button1.Text = "Обновить все данные";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(525, 569);
            this.textBox1.MaxLength = 4;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(69, 23);
            this.textBox1.TabIndex = 7;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(451, 567);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "Доход за ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(600, 567);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "год составил:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(710, 569);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(148, 23);
            this.textBox2.TabIndex = 10;
            // 
            // listView3
            // 
            this.listView3.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11});
            this.listView3.Location = new System.Drawing.Point(364, 351);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(679, 201);
            this.listView3.TabIndex = 11;
            this.listView3.UseCompatibleStateImageBehavior = false;
            this.listView3.View = System.Windows.Forms.View.Details;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(564, 327);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(340, 21);
            this.label5.TabIndex = 12;
            this.label5.Text = "Информация об использовании автомобилей";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Модель автомобиля";
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Количество прокатов";
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Доход с прокатов";
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1054, 604);
            this.ControlBox = false;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listView3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem автомобилиToolStripMenuItem;
        private ToolStripMenuItem списокВсехАвтомобилейToolStripMenuItem;
        private ToolStripMenuItem добавитьНовыйToolStripMenuItem;
        private ToolStripMenuItem клиентыToolStripMenuItem;
        private ToolStripMenuItem списокКлиентовToolStripMenuItem;
        private ToolStripMenuItem заявкиToolStripMenuItem;
        private ToolStripMenuItem выходToolStripMenuItem;
        private Label label1;
        private ListView listView2;
        private Label label2;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private Button button1;
        private TextBox textBox1;
        private Label label3;
        private Label label4;
        private TextBox textBox2;
        private ListView listView3;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader11;
        private Label label5;
    }
}