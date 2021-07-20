namespace Room
{
    partial class fin_zvit
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fin_zvit));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.monthCalendar2 = new System.Windows.Forms.MonthCalendar();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sumaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idroomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oplacheniyilinetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataoplatyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datavystavlenogoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zaShoOplataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableFinZvitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roomDATADataSet = new Room.RoomDATADataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label_id_room = new System.Windows.Forms.Label();
            this.tableFinZvitTableAdapter = new Room.RoomDATADataSetTableAdapters.TableFinZvitTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableFinZvitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomDATADataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.AllowDrop = true;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "ВСЕ",
            "Вода ",
            "Світло",
            "Інтернет",
            "ОСББ",
            "Прибирання",
            "Оренда",
            "Подобова оренда"});
            this.comboBox1.Location = new System.Drawing.Point(373, 31);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(221, 33);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.TextChanged += new System.EventHandler(this.comboBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(239, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Рух коштів";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(18, 43);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 2;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(18, 262);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(75, 21);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Період";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // monthCalendar2
            // 
            this.monthCalendar2.Location = new System.Drawing.Point(18, 295);
            this.monthCalendar2.MaxSelectionCount = 1;
            this.monthCalendar2.Name = "monthCalendar2";
            this.monthCalendar2.TabIndex = 4;
            this.monthCalendar2.Visible = false;
            this.monthCalendar2.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar2_DateChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.sumaDataGridViewTextBoxColumn,
            this.idroomDataGridViewTextBoxColumn,
            this.oplacheniyilinetDataGridViewTextBoxColumn,
            this.dataoplatyDataGridViewTextBoxColumn,
            this.datavystavlenogoDataGridViewTextBoxColumn,
            this.zaShoOplataDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tableFinZvitBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(241, 76);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1264, 426);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.RowValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowValidated);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // sumaDataGridViewTextBoxColumn
            // 
            this.sumaDataGridViewTextBoxColumn.DataPropertyName = "suma";
            this.sumaDataGridViewTextBoxColumn.HeaderText = "Сума";
            this.sumaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sumaDataGridViewTextBoxColumn.Name = "sumaDataGridViewTextBoxColumn";
            this.sumaDataGridViewTextBoxColumn.ReadOnly = true;
            this.sumaDataGridViewTextBoxColumn.Width = 125;
            // 
            // idroomDataGridViewTextBoxColumn
            // 
            this.idroomDataGridViewTextBoxColumn.DataPropertyName = "idroom";
            this.idroomDataGridViewTextBoxColumn.HeaderText = "Номер Квартири";
            this.idroomDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idroomDataGridViewTextBoxColumn.Name = "idroomDataGridViewTextBoxColumn";
            this.idroomDataGridViewTextBoxColumn.ReadOnly = true;
            this.idroomDataGridViewTextBoxColumn.Width = 125;
            // 
            // oplacheniyilinetDataGridViewTextBoxColumn
            // 
            this.oplacheniyilinetDataGridViewTextBoxColumn.DataPropertyName = "oplacheniyilinet";
            this.oplacheniyilinetDataGridViewTextBoxColumn.HeaderText = "Оплата";
            this.oplacheniyilinetDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.oplacheniyilinetDataGridViewTextBoxColumn.Name = "oplacheniyilinetDataGridViewTextBoxColumn";
            this.oplacheniyilinetDataGridViewTextBoxColumn.ReadOnly = true;
            this.oplacheniyilinetDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataoplatyDataGridViewTextBoxColumn
            // 
            this.dataoplatyDataGridViewTextBoxColumn.DataPropertyName = "dataoplaty";
            this.dataoplatyDataGridViewTextBoxColumn.HeaderText = "Дата оплати";
            this.dataoplatyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dataoplatyDataGridViewTextBoxColumn.Name = "dataoplatyDataGridViewTextBoxColumn";
            this.dataoplatyDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataoplatyDataGridViewTextBoxColumn.Width = 125;
            // 
            // datavystavlenogoDataGridViewTextBoxColumn
            // 
            this.datavystavlenogoDataGridViewTextBoxColumn.DataPropertyName = "datavystavlenogo";
            this.datavystavlenogoDataGridViewTextBoxColumn.HeaderText = "Дата виставленого рахунку";
            this.datavystavlenogoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.datavystavlenogoDataGridViewTextBoxColumn.Name = "datavystavlenogoDataGridViewTextBoxColumn";
            this.datavystavlenogoDataGridViewTextBoxColumn.ReadOnly = true;
            this.datavystavlenogoDataGridViewTextBoxColumn.Width = 125;
            // 
            // zaShoOplataDataGridViewTextBoxColumn
            // 
            this.zaShoOplataDataGridViewTextBoxColumn.DataPropertyName = "ZaShoOplata";
            this.zaShoOplataDataGridViewTextBoxColumn.HeaderText = "За що оплата";
            this.zaShoOplataDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.zaShoOplataDataGridViewTextBoxColumn.Name = "zaShoOplataDataGridViewTextBoxColumn";
            this.zaShoOplataDataGridViewTextBoxColumn.ReadOnly = true;
            this.zaShoOplataDataGridViewTextBoxColumn.Width = 125;
            // 
            // tableFinZvitBindingSource
            // 
            this.tableFinZvitBindingSource.DataMember = "TableFinZvit";
            this.tableFinZvitBindingSource.DataSource = this.roomDATADataSet;
            // 
            // roomDATADataSet
            // 
            this.roomDATADataSet.DataSetName = "RoomDATADataSet";
            this.roomDATADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(241, 530);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Витрати";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(448, 530);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Не оплачено";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(733, 530);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Оплачено";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(600, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(261, 44);
            this.button1.TabIndex = 10;
            this.button1.Text = "вибрати квартиру";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.TextChanged += new System.EventHandler(this.button1_TextChanged);
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_id_room
            // 
            this.label_id_room.AutoSize = true;
            this.label_id_room.Location = new System.Drawing.Point(284, 17);
            this.label_id_room.Name = "label_id_room";
            this.label_id_room.Size = new System.Drawing.Size(46, 17);
            this.label_id_room.TabIndex = 11;
            this.label_id_room.Text = "label5";
            this.label_id_room.Visible = false;
            this.label_id_room.TextChanged += new System.EventHandler(this.label_id_room_TextChanged);
            // 
            // tableFinZvitTableAdapter
            // 
            this.tableFinZvitTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(867, 27);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(269, 43);
            this.button2.TabIndex = 12;
            this.button2.Text = "По всіх квартирах";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(838, 530);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 24);
            this.label5.TabIndex = 15;
            this.label5.Text = "Оплачено";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(578, 530);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 24);
            this.label6.TabIndex = 14;
            this.label6.Text = "Не оплачено";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(332, 530);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 24);
            this.label7.TabIndex = 13;
            this.label7.Text = "Витрати";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(1229, 27);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(276, 39);
            this.button3.TabIndex = 16;
            this.button3.Text = "ПОКАЗАТИ ВИТРАТИ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // fin_zvit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 570);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label_id_room);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.monthCalendar2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fin_zvit";
            this.Text = "fin_zvit";
            this.Load += new System.EventHandler(this.fin_zvit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableFinZvitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomDATADataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.MonthCalendar monthCalendar2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label_id_room;
        private RoomDATADataSet roomDATADataSet;
        private System.Windows.Forms.BindingSource tableFinZvitBindingSource;
        private RoomDATADataSetTableAdapters.TableFinZvitTableAdapter tableFinZvitTableAdapter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sumaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idroomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oplacheniyilinetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataoplatyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datavystavlenogoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zaShoOplataDataGridViewTextBoxColumn;
    }
}