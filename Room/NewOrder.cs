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
    public partial class NewOrder : Form
    {
        public NewOrder()
        {
            InitializeComponent();
        }

        private void NewOrder_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "roomDATADataSet.TableFinZvit". При необходимости она может быть перемещена или удалена.
            this.tableFinZvitTableAdapter.Fill(this.roomDATADataSet.TableFinZvit);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "roomDATADataSet.TableOplata". При необходимости она может быть перемещена или удалена.

            // TODO: данная строка кода позволяет загрузить данные в таблицу "roomDATADataSet.TableOplata". При необходимости она может быть перемещена или удалена.
            this.tableOplataTableAdapter.Fill(this.roomDATADataSet.TableOplata);

              
            button2.BackColor = Color.Green;
            button1.BackColor = Color.Yellow;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            RoomListChoose form = new RoomListChoose();
            form.labelID = label_id_room;
            form.butNameRoom = button3;
            form.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        DateTime datemonth=DateTime.Today;
        
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (button3.Text== "ВИБЕРІТЬ КВАРТИРУ")
            {
                MessageBox.Show("Виберіть квартиру");
                return;
            }
            if (comboBox1.Text=="")
            {
                MessageBox.Show("Виберіть за що оплата");
                return;

            }
            
            if (textBox1.Text=="")
            {
                MessageBox.Show("Введіть суму квитанції");
                return;

            }
            tableOplataTableAdapter.Insert(textBox1.Text, label_id_room.Text, "Не оплачений",comboBox1.Text, datemonth);
           
           
            tableFinZvitTableAdapter.Insert(textBox1.Text,
                label_id_room.Text, 
                "Не оплачений", 
                null,
                monthCalendar1.SelectionRange.Start, 
                comboBox1.Text);

            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button3.Text == "ВИБЕРІТЬ КВАРТИРУ")
            {
                MessageBox.Show("Виберіть квартиру");
                return;
            }
            if (comboBox1.Text == "")
            {
                MessageBox.Show("Виберіть за що оплата");
                return;

            }
            
            if (textBox1.Text == "")
            {
                MessageBox.Show("Введіть суму квитанції");
                return;

            }
            tableOplataTableAdapter.Insert(textBox1.Text, label_id_room.Text, "Оплачений",comboBox1.Text,datemonth);
            
            tableFinZvitTableAdapter.Insert(textBox1.Text, label_id_room.Text, "Оплачений", monthCalendar1.SelectionRange.Start,monthCalendar1.SelectionRange.Start, comboBox1.Text);
            Close();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            datemonth = monthCalendar1.SelectionRange.Start;
        }
    }
}
