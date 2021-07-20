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
    public partial class NewClient : Form
    {
        public NewClient(bool reborno1)
        {
            InitializeComponent();
            reborno = reborno1;
        }
        bool reborno;
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text!="")
            {
                tableClientsTableAdapter.Insert(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, "NoBooked");
                if (reborno)
                {
                    rebotlabel.Text = "reboot";
                }
               
                Close();
            }
            else
            {
                MessageBox.Show("Поле ПІБ не заповнено");
                return;
            }
           
        }
        public Label rebotlabel;
        private void NewClient_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "roomDATADataSet1.TableClients". При необходимости она может быть перемещена или удалена.
            this.tableClientsTableAdapter.Fill(this.roomDATADataSet1.TableClients);
            button2.BackColor = Color.Red;
            button1.BackColor = Color.Green;

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }
    }
}
