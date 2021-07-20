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
    public partial class Clients : Form
    {
        public Clients(bool choose_or_list, int id)
        {
            InitializeComponent();
            choose = choose_or_list;
            IDrom = id;
        }
        bool choose;
        public TextBox txt1;
        public TextBox txt2;
        public TextBox txt3;
        public TextBox txt4;
        public Label lab1;
        int IDrom;
        private void Clients_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "roomDATADataSet.TableClients". При необходимости она может быть перемещена или удалена.
            this.tableClientsTableAdapter.Fill(this.roomDATADataSet.TableClients);
            if (choose)
            {
                button4.Visible = true;
            }
            else
            {
                button4.Visible = false;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewClient form = new NewClient(true);
            form.rebotlabel = rebootpage;
            form.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string caption = "Так";
            string message = "Ви впевнені що хочете видалити даного клієнта";
            DialogResult result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                return;
            }
            int a = tableClientsBindingSource.Find("Id", dataGridView1[0, dataGridView1.CurrentCell.RowIndex].Value.ToString());
            tableClientsBindingSource.RemoveAt(a);
            tableClientsTableAdapter.Update(roomDATADataSet);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Список клієнтів пустий");
                return;
            }

            RedClient form3 = new RedClient(Convert.ToInt32( dataGridView1[0, dataGridView1.CurrentCell.RowIndex].Value.ToString()),
                dataGridView1[1, dataGridView1.CurrentCell.RowIndex].Value.ToString(),
                dataGridView1[2, dataGridView1.CurrentCell.RowIndex].Value.ToString(),
                dataGridView1[3, dataGridView1.CurrentCell.RowIndex].Value.ToString(),
                dataGridView1[4, dataGridView1.CurrentCell.RowIndex].Value.ToString(),
                 dataGridView1[5, dataGridView1.CurrentCell.RowIndex].Value.ToString());
            form3.reboot = rebootpage;
            form3.ShowDialog();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            if (dataGridView1[5, dataGridView1.CurrentCell.RowIndex].Value.ToString()!="" && dataGridView1[5, dataGridView1.CurrentCell.RowIndex].Value.ToString() != "NoBooked")
            {

               
                MessageBox.Show("Мешканець вже заселений");
                return;
            }
            lab1.Text= dataGridView1[0, dataGridView1.CurrentCell.RowIndex].Value.ToString();
            //tableClientsTableAdapter.Update(         заселити
            //    dataGridView1[1, dataGridView1.CurrentCell.RowIndex].Value.ToString(),
            //    dataGridView1[2, dataGridView1.CurrentCell.RowIndex].Value.ToString(),
            //    dataGridView1[3, dataGridView1.CurrentCell.RowIndex].Value.ToString(),
            //    dataGridView1[4, dataGridView1.CurrentCell.RowIndex].Value.ToString(),
            //    IDrom.ToString(),
            //    Convert.ToInt32(dataGridView1[0, dataGridView1.CurrentCell.RowIndex].Value.ToString()),
            //     Convert.ToInt32(dataGridView1[0, dataGridView1.CurrentCell.RowIndex].Value.ToString()));
            Close();
           
        }

        private void rebootpage_TextChanged(object sender, EventArgs e)
        {
            this.tableClientsTableAdapter.Fill(this.roomDATADataSet.TableClients);
            if (choose)
            {
                button4.Visible = true;
            }
            else
            {
                button4.Visible = false;
            }
            rebootpage.Text = "rebootpage";
        }
    }
}
