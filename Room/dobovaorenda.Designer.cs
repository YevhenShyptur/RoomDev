namespace Room
{
    partial class dobovaorenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dobovaorenda));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label_id_room = new System.Windows.Forms.Label();
            this.label_id_client = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.roomDATADataSet = new Room.RoomDATADataSet();
            this.tableClientsTableAdapter = new Room.RoomDATADataSetTableAdapters.TableClientsTableAdapter();
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tableTableAdapter = new Room.RoomDATADataSetTableAdapters.TableTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tableFinZvitTableAdapter1 = new Room.RoomDATADataSetTableAdapters.TableFinZvitTableAdapter();
            this.bindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.tableOplataTableAdapter = new Room.RoomDATADataSetTableAdapters.TableOplataTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomDATADataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(33, 437);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(390, 80);
            this.button1.TabIndex = 0;
            this.button1.Text = "Здати в оренду";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(33, 76);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(390, 44);
            this.button2.TabIndex = 1;
            this.button2.Text = "вибрати клієнта";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(33, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(390, 44);
            this.button3.TabIndex = 2;
            this.button3.Text = "вибрати квартиру";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(145, 178);
            this.monthCalendar1.MaxSelectionCount = 15;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 3;
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // label_id_room
            // 
            this.label_id_room.AutoSize = true;
            this.label_id_room.Location = new System.Drawing.Point(40, 520);
            this.label_id_room.Name = "label_id_room";
            this.label_id_room.Size = new System.Drawing.Size(46, 17);
            this.label_id_room.TabIndex = 4;
            this.label_id_room.Text = "label1";
            this.label_id_room.Visible = false;
            // 
            // label_id_client
            // 
            this.label_id_client.AutoSize = true;
            this.label_id_client.Location = new System.Drawing.Point(201, 522);
            this.label_id_client.Name = "label_id_client";
            this.label_id_client.Size = new System.Drawing.Size(46, 17);
            this.label_id_client.TabIndex = 5;
            this.label_id_client.Text = "label1";
            this.label_id_client.Visible = false;
            this.label_id_client.TextChanged += new System.EventHandler(this.label_id_client_TextChanged);
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "TableClients";
            this.bindingSource1.DataSource = this.roomDATADataSet;
            // 
            // roomDATADataSet
            // 
            this.roomDATADataSet.DataSetName = "RoomDATADataSet";
            this.roomDATADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableClientsTableAdapter
            // 
            this.tableClientsTableAdapter.ClearBeforeFill = true;
            // 
            // bindingSource2
            // 
            this.bindingSource2.DataMember = "Table";
            this.bindingSource2.DataSource = this.roomDATADataSet;
            // 
            // tableTableAdapter
            // 
            this.tableTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(40, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "ЦІНА ЗА ДОБУ";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(256, 144);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(153, 30);
            this.textBox1.TabIndex = 7;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(173, 408);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "СУМА";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(272, 408);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 29);
            this.label3.TabIndex = 9;
            this.label3.Text = "0";
            // 
            // tableFinZvitTableAdapter1
            // 
            this.tableFinZvitTableAdapter1.ClearBeforeFill = true;
            // 
            // bindingSource3
            // 
            this.bindingSource3.DataMember = "TableOplata";
            this.bindingSource3.DataSource = this.roomDATADataSet;
            // 
            // tableOplataTableAdapter
            // 
            this.tableOplataTableAdapter.ClearBeforeFill = true;
            // 
            // dobovaorenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 580);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_id_client);
            this.Controls.Add(this.label_id_room);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "dobovaorenda";
            this.Text = "Подобова оренда";
            this.Load += new System.EventHandler(this.dobovaorenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomDATADataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label_id_room;
        private System.Windows.Forms.Label label_id_client;
        private System.Windows.Forms.BindingSource bindingSource1;
        private RoomDATADataSet roomDATADataSet;
        private RoomDATADataSetTableAdapters.TableClientsTableAdapter tableClientsTableAdapter;
        private System.Windows.Forms.BindingSource bindingSource2;
        private RoomDATADataSetTableAdapters.TableTableAdapter tableTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private RoomDATADataSetTableAdapters.TableFinZvitTableAdapter tableFinZvitTableAdapter1;
        private System.Windows.Forms.BindingSource bindingSource3;
        private RoomDATADataSetTableAdapters.TableOplataTableAdapter tableOplataTableAdapter;
    }
}