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
    public partial class fin_zvit : Form
    {
        public fin_zvit()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked==true)
            {
                monthCalendar2.Visible = true;
            }
            else
            {
                monthCalendar2.Visible = false;
            }

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RoomListChoose form = new RoomListChoose();
            form.labelID = label_id_room;
            form.butNameRoom = button1;
            form.ShowDialog();
            //if (dataGridView1.Rows.Count>1)

            //{
            //    string filter2 = string.Format("  Idroom = '{0}'  ",  label_id_room.Text); //добавляем условие для фильтрации по первому полю
            //                                                                                       //string filter2 = string.Format(" Idroom = '{0}' AND Id= '{1}' ", ID, label3.Text);                                                    //применяем фильтр
            //    tableFinZvitBindingSource.Filter = filter2;
            //}
            filter();
        }

        private void fin_zvit_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "roomDATADataSet.TableFinZvit". При необходимости она может быть перемещена или удалена.
            this.tableFinZvitTableAdapter.Fill(this.roomDATADataSet.TableFinZvit);
           // comboBox1.SelectedIndex = 0;
            sumall();
            comboBox1.Text = "ВСЕ";
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            filter();
          
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Text = "вибрати квартиру";
            filter();
        }
        double sumoplat;
        double sumneoplat ;
            double sumvitrat;
        private void dataGridView1_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        public void sumall()
        {
            sumneoplat = 0;
            sumoplat = 0;
            sumvitrat = 0;
            label5.Text = "0";
            label6.Text = "0";
            label7.Text = "0";
            
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
               
                if (dataGridView1[3, i].Value.ToString() == "Оплачений")

                {
                    sumoplat += Convert.ToDouble(dataGridView1[1, i].Value.ToString());
                }
                else
                {
                    if (dataGridView1[3, i].Value.ToString() == "Не оплачений")
                    {
                        sumneoplat += Convert.ToDouble(dataGridView1[1, i].Value.ToString());
                    }
                    else
                    {
                        if (dataGridView1[3, i].Value.ToString() == "Витрати")
                        {
                            sumvitrat += Convert.ToDouble(dataGridView1[1, i].Value.ToString());
                        }


                    }
                }
            }
           
            label5.Text = sumoplat.ToString();
            label6.Text = sumneoplat.ToString();
            label7.Text = sumvitrat.ToString();
            return;
        }
      
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
           // sumall();
        }

        private void label_id_room_TextChanged(object sender, EventArgs e)
        {
            //sumall();
            //MessageBox.Show("1");
        }

        private void button1_TextChanged(object sender, EventArgs e)
        {
            sumall();
           
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            filter();

        }

        private void monthCalendar2_DateChanged(object sender, DateRangeEventArgs e)
        {
            filter();
        }
        public void filter()
        {
            this.tableFinZvitTableAdapter.Fill(this.roomDATADataSet.TableFinZvit);
            tableFinZvitBindingSource.Filter = null;
            string filter3="";
            
                if (checkBox1.Checked==true)
                {
                     filter3 = string.Format(" datavystavlenogo >= '{0}' AND datavystavlenogo <= '{1}' ", monthCalendar1.SelectionRange.Start.ToShortDateString(), monthCalendar2.SelectionRange.Start.ToShortDateString());                                                    //применяем фильтр
                   
                }
                if (checkBox1.Checked != true)
            {
                filter3 = string.Format("  datavystavlenogo = '{0}'  ", monthCalendar1.SelectionRange.Start.ToShortDateString()); //добавляем условие для фильтрации по первому полю

            }



                 if (button1.Text!="вибрати квартиру")
                {
                    filter3+= string.Format("AND idroom = '{0}' ",label_id_room.Text);                                                    //применяем фильтр

                }
                 if (comboBox1.Text!="ВСЕ")
            {
                filter3 += string.Format("AND ZaShoOplata = '{0}' ", comboBox1.Text);
            }

            tableFinZvitBindingSource.Filter = filter3;
            sumall();
            return;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.tableFinZvitTableAdapter.Fill(this.roomDATADataSet.TableFinZvit);
            tableFinZvitBindingSource.Filter = null;
            string filter3 = "";

            if (checkBox1.Checked == true)
            {
                filter3 = string.Format(" datavystavlenogo >= '{0}' AND datavystavlenogo <= '{1}' ", monthCalendar1.SelectionRange.Start.ToShortDateString(), monthCalendar2.SelectionRange.Start.ToShortDateString());                                                    //применяем фильтр

            }
            if (checkBox1.Checked != true)
            {
                filter3 = string.Format("  datavystavlenogo = '{0}'  ", monthCalendar1.SelectionRange.Start.ToShortDateString()); //добавляем условие для фильтрации по первому полю

            }
            filter3+= string.Format("AND oplacheniyilinet = 'Витрати' ");
            tableFinZvitBindingSource.Filter = filter3;
            sumall();
        }
    }
}
