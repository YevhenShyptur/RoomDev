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
    public partial class RedClient : Form
    {
        public RedClient(int id,string name,string number,string passport, string comment, string idroom1)
        {
            InitializeComponent();
            oldname = textBox1.Text = name;
            textBox2.Text = number;
            textBox3.Text = passport;
            textBox4.Text = comment;
            ID = id;
            idroom = idroom1;
        }
        int ID;
        string oldname;
        string idroom;
        public Label reboot;
        private void RedClient_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "roomDATADataSet1.Pokaznik". При необходимости она может быть перемещена или удалена.
            this.pokaznikTableAdapter.Fill(this.roomDATADataSet1.Pokaznik);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "roomDATADataSet1.Table". При необходимости она может быть перемещена или удалена.
            this.tableTableAdapter.Fill(this.roomDATADataSet1.Table);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "roomDATADataSet1.TableClients". При необходимости она может быть перемещена или удалена.
            this.tableClientsTableAdapter.Fill(this.roomDATADataSet1.TableClients);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "roomDATADataSet1.Table". При необходимости она может быть перемещена или удалена.
            this.tableTableAdapter.Fill(this.roomDATADataSet1.Table);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "roomDATADataSet1.TableClients". При необходимости она может быть перемещена или удалена.
            this.tableClientsTableAdapter.Fill(this.roomDATADataSet1.TableClients);
            button1.BackColor = Color.Green;
            button2.BackColor = Color.Red;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                int a = bindingSource1.Find("Name", textBox1.Text);
                if (a != -1 & textBox1.Text != oldname)
                {
                    MessageBox.Show("Даний клієнт вже існує в базі");
                    return;
                }
                else
                {
                   // tableTableAdapter.Update("", "", 1);
                    tableClientsTableAdapter.Update(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text,idroom,ID);
                    reboot.Text = "reboot";

                    Close();
                }

            }
            else
            {
                MessageBox.Show("Номер квартири незаповнений");
                return;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
