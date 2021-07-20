using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Room
{
    public partial class RoomListChoose : Form
    {
        public RoomListChoose()
        {
            InitializeComponent();
        }

        private void RoomListChoose_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "roomDATADataSet.Table". При необходимости она может быть перемещена или удалена.
            this.tableTableAdapter.Fill(this.roomDATADataSet.Table);
            button1.BackColor = Color.Green;
            button2.BackColor = Color.Red;

        }
        public Label labelID;
        public Button butNameRoom;
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count!=0)
            {
                labelID.Text = dataGridView1[0, dataGridView1.CurrentCell.RowIndex].Value.ToString();
                butNameRoom.Text = dataGridView1[1, dataGridView1.CurrentCell.RowIndex].Value.ToString();
                Close();
            }
            else
            {
                MessageBox.Show("Список пустий");
            }
        }
    }
}
