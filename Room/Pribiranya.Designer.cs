namespace Room
{
    partial class Pribiranya
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pribiranya));
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.numberroomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tablePribiranyaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roomDATADataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roomDATADataSet = new Room.RoomDATADataSet();
            this.tablePribiranyaTableAdapter = new Room.RoomDATADataSetTableAdapters.TablePribiranyaTableAdapter();
            this.label_reb = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePribiranyaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomDATADataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomDATADataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(4, 87);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 119);
            this.button1.TabIndex = 0;
            this.button1.Text = "Додати прибирання";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numberroomDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn,
            this.comentDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tablePribiranyaBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(193, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(994, 656);
            this.dataGridView1.TabIndex = 1;
            // 
            // numberroomDataGridViewTextBoxColumn
            // 
            this.numberroomDataGridViewTextBoxColumn.DataPropertyName = "numberroom";
            this.numberroomDataGridViewTextBoxColumn.HeaderText = "Номер квартири";
            this.numberroomDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numberroomDataGridViewTextBoxColumn.Name = "numberroomDataGridViewTextBoxColumn";
            this.numberroomDataGridViewTextBoxColumn.ReadOnly = true;
            this.numberroomDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "Дата відвідання";
            this.dataDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            this.dataDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataDataGridViewTextBoxColumn.Width = 125;
            // 
            // comentDataGridViewTextBoxColumn
            // 
            this.comentDataGridViewTextBoxColumn.DataPropertyName = "coment";
            this.comentDataGridViewTextBoxColumn.HeaderText = "Коментар";
            this.comentDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.comentDataGridViewTextBoxColumn.Name = "comentDataGridViewTextBoxColumn";
            this.comentDataGridViewTextBoxColumn.ReadOnly = true;
            this.comentDataGridViewTextBoxColumn.Width = 125;
            // 
            // tablePribiranyaBindingSource
            // 
            this.tablePribiranyaBindingSource.DataMember = "TablePribiranya";
            this.tablePribiranyaBindingSource.DataSource = this.roomDATADataSetBindingSource;
            // 
            // roomDATADataSetBindingSource
            // 
            this.roomDATADataSetBindingSource.DataSource = this.roomDATADataSet;
            this.roomDATADataSetBindingSource.Position = 0;
            // 
            // roomDATADataSet
            // 
            this.roomDATADataSet.DataSetName = "RoomDATADataSet";
            this.roomDATADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tablePribiranyaTableAdapter
            // 
            this.tablePribiranyaTableAdapter.ClearBeforeFill = true;
            // 
            // label_reb
            // 
            this.label_reb.AutoSize = true;
            this.label_reb.Location = new System.Drawing.Point(75, 209);
            this.label_reb.Name = "label_reb";
            this.label_reb.Size = new System.Drawing.Size(46, 17);
            this.label_reb.TabIndex = 2;
            this.label_reb.Text = "label1";
            this.label_reb.Visible = false;
            this.label_reb.TextChanged += new System.EventHandler(this.label_reb_TextChanged);
            // 
            // Pribiranya
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 809);
            this.Controls.Add(this.label_reb);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Pribiranya";
            this.Text = "Дата відвідування прибирання";
            this.Load += new System.EventHandler(this.Pribiranya_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePribiranyaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomDATADataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomDATADataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource roomDATADataSetBindingSource;
        private RoomDATADataSet roomDATADataSet;
        private System.Windows.Forms.BindingSource tablePribiranyaBindingSource;
        private RoomDATADataSetTableAdapters.TablePribiranyaTableAdapter tablePribiranyaTableAdapter;
        private System.Windows.Forms.Label label_reb;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberroomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn comentDataGridViewTextBoxColumn;
    }
}