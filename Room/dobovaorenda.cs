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
    public partial class dobovaorenda : Form
    {
        public dobovaorenda()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button3.Text!="вибрати квартиру")
            {
                label_id_client.Text = "";
                Clients clients = new Clients(true, int.Parse(label_id_room.Text));
                clients.lab1 = label_id_client;
                clients.ShowDialog();
            }
            else
            {
                MessageBox.Show("Спочатку виберіть квартиру");
            }
            
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RoomListChoose ch = new RoomListChoose();
            ch.labelID = label_id_room;
            ch.butNameRoom = button3;
            ch.ShowDialog();
        }

        private void dobovaorenda_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "roomDATADataSet.TableOplata". При необходимости она может быть перемещена или удалена.
            this.tableOplataTableAdapter.Fill(this.roomDATADataSet.TableOplata);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "roomDATADataSet.Table". При необходимости она может быть перемещена или удалена.
            this.tableTableAdapter.Fill(this.roomDATADataSet.Table);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "roomDATADataSet.TableClients". При необходимости она может быть перемещена или удалена.
            this.tableClientsTableAdapter.Fill(this.roomDATADataSet.TableClients);
            this.tableFinZvitTableAdapter1.Fill(this.roomDATADataSet.TableFinZvit);
            button1.BackColor = Color.Green;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double days = (monthCalendar1.SelectionRange.End - monthCalendar1.SelectionRange.Start).TotalDays;
            if (textBox1.Text == "" || textBox1.Text == "0")
            {
                MessageBox.Show("Виберіть ціну за добу");
                return;
            }
            if (days==0)
            {
                MessageBox.Show("Виберіть більший інтервал для проживання");
            }
            else
            {
                if (button3.Text=="вибрати квартиру")
                {
                    MessageBox.Show("Виберіть спочатку квартиру");
                    return;
                }
                if (button2.Text=="вибрати клієнта")
                {
                    MessageBox.Show("Виберіть спочатку проживаючого");
                    return;
                }
                if (label_id_client.Text != "" && label_id_room.Text != "")
                {
                    int a = bindingSource1.Find("id", label_id_client.Text);

                    foreach (DataRow row in roomDATADataSet.TableClients)
                    {
                        if (row[0].ToString() == label_id_client.Text)
                        {

                            row[5] = label_id_room.Text;


                            tableClientsTableAdapter.Update(row);
                        }
                    }
                    foreach (DataRow row1 in roomDATADataSet.Table)
                    {
                        if (row1[0].ToString() == label_id_room.Text)
                        {
                            row1[3] = "ЗАСЕЛЕНА";
                            row1[2] = "Короткий період";
                            tableTableAdapter.Update(row1);

                        }
                    }
                    tableOplataTableAdapter.Insert(label3.Text, label_id_room.Text, "Оплачений", "Подобова оренда", DateTime.Today);
                    tableFinZvitTableAdapter1.Insert(label3.Text, label_id_room.Text, "Оплачений", DateTime.Today, DateTime.Today, "Подобова оренда");
                    MessageBox.Show("Успішно поселений");
                   
                    Close();
                }
            }
                
            
        }
       
        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            if (textBox1.Text!="")
            {
                double days = (monthCalendar1.SelectionRange.End - monthCalendar1.SelectionRange.Start).TotalDays;
                label3.Text = (days * double.Parse(textBox1.Text)).ToString();
            }
            else
            {
                MessageBox.Show("введіть ціну за добу");
            }


        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }

        private void label_id_client_TextChanged(object sender, EventArgs e)
        {
            foreach (DataRow row in roomDATADataSet.TableClients)
            {
                if (row[0].ToString() == label_id_client.Text)
                {
                    button2.Text = row[1].ToString();
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text!="")
            {
                double days = (monthCalendar1.SelectionRange.End - monthCalendar1.SelectionRange.Start).TotalDays;
                label3.Text = (days * double.Parse(textBox1.Text)).ToString();
            }
            else
            {
                label3.Text = "0";
            }
            
        }
    }
}
