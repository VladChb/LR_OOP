namespace lr1_3
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textnum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textfirst = new System.Windows.Forms.TextBox();
            this.textlast = new System.Windows.Forms.TextBox();
            this.textprice = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.записатиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.типToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.аЯToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.яАToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.цінаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.мінМаксToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.максМінToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зберегтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зберегтиУФайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вивестиЗФайлуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вивестиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.додатиЗаписToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститиТаблицюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Type,
            this.Number,
            this.SName,
            this.FDate,
            this.LDate,
            this.Price});
            this.dataGridView1.Location = new System.Drawing.Point(299, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(854, 361);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Type
            // 
            this.Type.HeaderText = "Тип";
            this.Type.MinimumWidth = 6;
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            this.Type.Width = 125;
            // 
            // Number
            // 
            this.Number.HeaderText = "Номер полісу";
            this.Number.MinimumWidth = 6;
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            this.Number.Width = 125;
            // 
            // SName
            // 
            this.SName.HeaderText = "Страхувальник";
            this.SName.MinimumWidth = 6;
            this.SName.Name = "SName";
            this.SName.ReadOnly = true;
            this.SName.Width = 125;
            // 
            // FDate
            // 
            this.FDate.HeaderText = "Дата видачі";
            this.FDate.MinimumWidth = 6;
            this.FDate.Name = "FDate";
            this.FDate.ReadOnly = true;
            this.FDate.Width = 125;
            // 
            // LDate
            // 
            this.LDate.HeaderText = "Дата закінчення";
            this.LDate.MinimumWidth = 6;
            this.LDate.Name = "LDate";
            this.LDate.ReadOnly = true;
            this.LDate.Width = 125;
            // 
            // Price
            // 
            this.Price.HeaderText = "Ціна";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 125;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "житло",
            "авто",
            "життя",
            "техніка"});
            this.comboBox1.Location = new System.Drawing.Point(172, 69);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 2;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Стерненко М.П.",
            "Осипенко О.О.",
            "Порошенко П.О."});
            this.comboBox2.Location = new System.Drawing.Point(172, 161);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 24);
            this.comboBox2.TabIndex = 3;
            // 
            // textnum
            // 
            this.textnum.Location = new System.Drawing.Point(172, 111);
            this.textnum.Name = "textnum";
            this.textnum.Size = new System.Drawing.Size(100, 22);
            this.textnum.TabIndex = 4;
            this.textnum.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(1, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Тип старухавння";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(1, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Номер полісу";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(1, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(165, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "ПІБ страхувальника";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(1, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 19);
            this.label7.TabIndex = 11;
            this.label7.Text = "Дата видачі";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(1, 253);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 19);
            this.label8.TabIndex = 12;
            this.label8.Text = "Дата закінчення";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(2, 307);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 19);
            this.label9.TabIndex = 13;
            this.label9.Text = "Ціна поліса";
            // 
            // textfirst
            // 
            this.textfirst.Location = new System.Drawing.Point(172, 203);
            this.textfirst.Name = "textfirst";
            this.textfirst.Size = new System.Drawing.Size(100, 22);
            this.textfirst.TabIndex = 14;
            this.textfirst.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textlast
            // 
            this.textlast.Location = new System.Drawing.Point(172, 253);
            this.textlast.Name = "textlast";
            this.textlast.Size = new System.Drawing.Size(100, 22);
            this.textlast.TabIndex = 15;
            // 
            // textprice
            // 
            this.textprice.Location = new System.Drawing.Point(172, 304);
            this.textprice.Name = "textprice";
            this.textprice.Size = new System.Drawing.Size(100, 22);
            this.textprice.TabIndex = 16;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.записатиToolStripMenuItem,
            this.зберегтиToolStripMenuItem,
            this.вивестиToolStripMenuItem,
            this.додатиЗаписToolStripMenuItem,
            this.очиститиТаблицюToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1135, 28);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // записатиToolStripMenuItem
            // 
            this.записатиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.типToolStripMenuItem,
            this.цінаToolStripMenuItem});
            this.записатиToolStripMenuItem.Name = "записатиToolStripMenuItem";
            this.записатиToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.записатиToolStripMenuItem.Text = "Сортувати";
            this.записатиToolStripMenuItem.Click += new System.EventHandler(this.записатиToolStripMenuItem_Click);
            // 
            // типToolStripMenuItem
            // 
            this.типToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.аЯToolStripMenuItem,
            this.яАToolStripMenuItem});
            this.типToolStripMenuItem.Name = "типToolStripMenuItem";
            this.типToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.типToolStripMenuItem.Text = "Тип";
            // 
            // аЯToolStripMenuItem
            // 
            this.аЯToolStripMenuItem.Name = "аЯToolStripMenuItem";
            this.аЯToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.аЯToolStripMenuItem.Text = "А-Я";
            this.аЯToolStripMenuItem.Click += new System.EventHandler(this.аЯToolStripMenuItem_Click);
            // 
            // яАToolStripMenuItem
            // 
            this.яАToolStripMenuItem.Name = "яАToolStripMenuItem";
            this.яАToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.яАToolStripMenuItem.Text = "Я-А";
            this.яАToolStripMenuItem.Click += new System.EventHandler(this.яАToolStripMenuItem_Click);
            // 
            // цінаToolStripMenuItem
            // 
            this.цінаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.мінМаксToolStripMenuItem,
            this.максМінToolStripMenuItem});
            this.цінаToolStripMenuItem.Name = "цінаToolStripMenuItem";
            this.цінаToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.цінаToolStripMenuItem.Text = "Ціна";
            // 
            // мінМаксToolStripMenuItem
            // 
            this.мінМаксToolStripMenuItem.Name = "мінМаксToolStripMenuItem";
            this.мінМаксToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.мінМаксToolStripMenuItem.Text = "Мін-Макс";
            this.мінМаксToolStripMenuItem.Click += new System.EventHandler(this.мінМаксToolStripMenuItem_Click);
            // 
            // максМінToolStripMenuItem
            // 
            this.максМінToolStripMenuItem.Name = "максМінToolStripMenuItem";
            this.максМінToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.максМінToolStripMenuItem.Text = "Макс-Мін";
            this.максМінToolStripMenuItem.Click += new System.EventHandler(this.максМінToolStripMenuItem_Click);
            // 
            // зберегтиToolStripMenuItem
            // 
            this.зберегтиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.зберегтиУФайлToolStripMenuItem,
            this.вивестиЗФайлуToolStripMenuItem});
            this.зберегтиToolStripMenuItem.Name = "зберегтиToolStripMenuItem";
            this.зберегтиToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.зберегтиToolStripMenuItem.Text = "Файл";
            this.зберегтиToolStripMenuItem.Click += new System.EventHandler(this.зберегтиToolStripMenuItem_Click);
            // 
            // зберегтиУФайлToolStripMenuItem
            // 
            this.зберегтиУФайлToolStripMenuItem.Name = "зберегтиУФайлToolStripMenuItem";
            this.зберегтиУФайлToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.зберегтиУФайлToolStripMenuItem.Text = "Зберегти у файл";
            this.зберегтиУФайлToolStripMenuItem.Click += new System.EventHandler(this.зберегтиУФайлToolStripMenuItem_Click);
            // 
            // вивестиЗФайлуToolStripMenuItem
            // 
            this.вивестиЗФайлуToolStripMenuItem.Name = "вивестиЗФайлуToolStripMenuItem";
            this.вивестиЗФайлуToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.вивестиЗФайлуToolStripMenuItem.Text = "Вивести з файлу";
            this.вивестиЗФайлуToolStripMenuItem.Click += new System.EventHandler(this.вивестиЗФайлуToolStripMenuItem_Click);
            // 
            // вивестиToolStripMenuItem
            // 
            this.вивестиToolStripMenuItem.Name = "вивестиToolStripMenuItem";
            this.вивестиToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.вивестиToolStripMenuItem.Text = "Вихід";
            this.вивестиToolStripMenuItem.Click += new System.EventHandler(this.вивестиToolStripMenuItem_Click_1);
            // 
            // додатиЗаписToolStripMenuItem
            // 
            this.додатиЗаписToolStripMenuItem.Name = "додатиЗаписToolStripMenuItem";
            this.додатиЗаписToolStripMenuItem.Size = new System.Drawing.Size(117, 24);
            this.додатиЗаписToolStripMenuItem.Text = "Додати запис";
            this.додатиЗаписToolStripMenuItem.Click += new System.EventHandler(this.додатиЗаписToolStripMenuItem_Click);
            // 
            // очиститиТаблицюToolStripMenuItem
            // 
            this.очиститиТаблицюToolStripMenuItem.Name = "очиститиТаблицюToolStripMenuItem";
            this.очиститиТаблицюToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
            this.очиститиТаблицюToolStripMenuItem.Text = "Очистити таблицю";
            this.очиститиТаблицюToolStripMenuItem.Click += new System.EventHandler(this.очиститиТаблицюToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(1135, 600);
            this.Controls.Add(this.textprice);
            this.Controls.Add(this.textlast);
            this.Controls.Add(this.textfirst);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textnum);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textnum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textfirst;
        private System.Windows.Forms.TextBox textlast;
        private System.Windows.Forms.TextBox textprice;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem записатиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem зберегтиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вивестиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem типToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem аЯToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem яАToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem цінаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem мінМаксToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem максМінToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem зберегтиУФайлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вивестиЗФайлуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem додатиЗаписToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn SName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn LDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.ToolStripMenuItem очиститиТаблицюToolStripMenuItem;
    }
}

