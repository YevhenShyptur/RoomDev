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
    public partial class Room_list : Form
    {
        public Room_list()
        {
            InitializeComponent();
           

            // construct the sortable BindingListView for Persons:
           
        }
       
        private void Room_list_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "roomDATADataSet.TablePribiranya". При необходимости она может быть перемещена или удалена.
            this.tablePribiranyaTableAdapter.Fill(this.roomDATADataSet.TablePribiranya);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "roomDATADataSet.TableClients". При необходимости она может быть перемещена или удалена.
            this.tableClientsTableAdapter.Fill(this.roomDATADataSet.TableClients);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "roomDATADataSet.Table". При необходимости она может быть перемещена или удалена.
            this.tableTableAdapter.Fill(this.roomDATADataSet.Table);
            button2.BackColor = Color.Yellow;
            button3.BackColor = Color.Red;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1[3, i].Value.ToString() == "ПУСТА")
                { dataGridView1[3, i].Style.BackColor = System.Drawing.Color.Red; }
                else { dataGridView1[3, i].Style.BackColor = System.Drawing.Color.Green; }
                
            }
           

        }
            

        private void button3_Click(object sender, EventArgs e)
        {
            string caption = "Так";
            string message = "Ви впевнені що хочете видалити дану квартиру";
            DialogResult result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                return;
            }
            int a = tableBindingSource.Find("Id", dataGridView1[0, dataGridView1.CurrentCell.RowIndex].Value.ToString());
            tableBindingSource.RemoveAt(a);
            tableTableAdapter.Update(roomDATADataSet);
            //int b = bindingSource1.Find("Idroom", dataGridView1[0, dataGridView1.CurrentCell.RowIndex].Value.ToString());
            //bindingSource1.RemoveAt(b);
            //tablePribiranyaTableAdapter.Update(roomDATADataSet);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool a = true;
            //Form form2 = new New_Room();
            New_Room form3 = new New_Room(a);
            form3.reb = REBOOTPAGE;
            form3.ShowDialog();
           // form2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Список квартир пустий");
                return;
            }
            
            //RedRoom form3 = new RedRoom(dataGridView1[0, dataGridView1.CurrentCell.RowIndex].Value.ToString(), dataGridView1[1, dataGridView1.CurrentCell.RowIndex].Value.ToString(), dataGridView1[2, dataGridView1.CurrentCell.RowIndex].Value.ToString());
            //form3.redlabel = REBOOTPAGE;
            //form3.ShowDialog();
        

        }

        private void tableBindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void REBOOTPAGE_TextChanged(object sender, EventArgs e)
        {
            this.tableClientsTableAdapter.Fill(this.roomDATADataSet.TableClients);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "roomDATADataSet.Table". При необходимости она может быть перемещена или удалена.
            this.tableTableAdapter.Fill(this.roomDATADataSet.Table);
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1[3, i].Value.ToString() == "ПУСТА")
                { dataGridView1[3, i].Style.BackColor = System.Drawing.Color.Red; }
                else { dataGridView1[3, i].Style.BackColor = System.Drawing.Color.Green; }

            }
            REBOOTPAGE.Text = "";
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Список квартир пустий");
                return;
            }

            //RedRoom form3 = new RedRoom(dataGridView1[0, dataGridView1.CurrentCell.RowIndex].Value.ToString(), dataGridView1[1, dataGridView1.CurrentCell.RowIndex].Value.ToString(), dataGridView1[2, dataGridView1.CurrentCell.RowIndex].Value.ToString());
            //form3.redlabel = REBOOTPAGE;
            //form3.ShowDialog();
        }

        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1[3, i].Value.ToString() == "ПУСТА")
                { dataGridView1[3, i].Style.BackColor = System.Drawing.Color.Red; }
                else { dataGridView1[3, i].Style.BackColor = System.Drawing.Color.Green; }

            }
        }
    }
}
