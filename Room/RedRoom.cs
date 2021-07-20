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
    public partial class RedRoom : Form
    {
        public RedRoom(string name1)
        {
            InitializeComponent();
           
             Name1=name1;
            // int a = bindingSource1.Find("number", name1);
          
            this.tableTableAdapter.Fill(this.roomDATADataSet1.Table);
            foreach (DataRow row in roomDATADataSet1.Table)
            {
                if (row[1].ToString() == name1)
                {
                    ID = Convert.ToInt32(row[0].ToString());
                    Coment = row[2].ToString();
                   

                   
                }
            }
           
        }
        int ID; string Name1; string Coment;
        double sumneoplat = 0;
        double sumoplat = 0;
        DateTime datamonth; DateTime olddatamonth;
        double originalsuma = 0;
        private void RedRoom_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "roomDATADataSet1.TableFinZvit". При необходимости она может быть перемещена или удалена.
            this.tableFinZvitTableAdapter.Fill(this.roomDATADataSet1.TableFinZvit);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "roomDATADataSet1.TableOplata". При необходимости она может быть перемещена или удалена.
            this.tableOplataTableAdapter.Fill(this.roomDATADataSet1.TableOplata);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "roomDATADataSet1.TableClients". При необходимости она может быть перемещена или удалена.
            this.tableClientsTableAdapter.Fill(this.roomDATADataSet1.TableClients);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "roomDATADataSet1.Pokaznik". При необходимости она может быть перемещена или удалена.
            this.pokaznikTableAdapter.Fill(this.roomDATADataSet1.Pokaznik);
            this.tableTableAdapter.Fill(this.roomDATADataSet1.Table);
            DateTime dateTime=new DateTime(2040,10,30);
            foreach (DataRow row in roomDATADataSet1.Table)
            {
                if (row[1].ToString()==Name1)
                {
                    textBox3.Text = row[5].ToString();
                    
                    if (textBox3.Text=="")
                    {
                        textBox3.Text = "0";

                    }
                    originalsuma = Convert.ToDouble(textBox3.Text);
                    olddatamonth = Convert.ToDateTime(row[4].ToString());

                    if (row[4].ToString()==dateTime.ToString() || row[4].ToString()=="")
                    {
                        monthCalendar1.Visible = false;
                        label8.Visible = false;
                        datamonth = dateTime;
                    }
                    else
                    {
                        datamonth =Convert.ToDateTime( row[4].ToString());
                        monthCalendar1.SelectionStart = datamonth;
                       
                    }
                    
                }
            }
            oldname = textBox1.Text = Name1;
            richTextBox1.Text = Coment;
           comboBox1.Text="Вода";
            comboBox2.Text = "ВСІ";
          //  string filter1 = string.Format(" Idroom = '{0}'", ID);
            string filter2 = string.Format(" Idroom = '{0}'", ID); //добавляем условие для фильтрации по первому полю
            pokaznikBindingSource.Filter = filter2;                                                                 //применяем фильтр
            tableClientsBindingSource.Filter = filter2;
            string filter3 = string.Format("  Idroom = '{0}' ", ID);
            tableOplataBindingSource.Filter = filter3;
            button1.BackColor = Color.Green;
            button2.BackColor = Color.Red;
            button3.BackColor = Color.Green;
            if (dataGridView3.Rows.Count > 1 )
            {
               
                for (int i = 0; i < dataGridView3.Rows.Count-1; i++)
                {
                    if (dataGridView3[3, i].Value.ToString() == "Не оплачений")
                    {
                        dataGridView3[3, i].Style.BackColor = Color.Red;
                       
                        sumneoplat += Convert.ToDouble(dataGridView3[1, i].Value.ToString());

                       
                       
                    }
                    else
                    {
                        dataGridView3[3, i].Style.BackColor = System.Drawing.Color.Green;
                        sumoplat += Convert.ToDouble(dataGridView3[1, i].Value.ToString());
                       
                    }
                    
                }
            }
            
            label7.Text = sumneoplat.ToString();
            label6.Text = sumoplat.ToString();
            this.Text = "Редагувати дані про квартиру №"+"  "+Name1;
           
            if (dataGridView2.Rows.Count > 1)
            {
                itsnewroom = false;
            }
        }
        bool itsnewroom=true;
        string oldname;
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
        public Label redlabel;
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text!="")
            {
                int a= bindingSource1.Find( "Number", textBox1.Text);
                if (a!=-1 & textBox1.Text!=oldname)
                {
                    MessageBox.Show("Дана квартира вже існує");
                    return;
                }
                else
                {

                    if (dataGridView2.Rows.Count>1)
                    {
                        // tableTableAdapter.Update(int.Parse(textBox1.Text), richTextBox1.Text, "ЗАСЕЛЕНА",datamonth, ID, int.Parse(textBox1.Text), datamonth);
                        this.tableTableAdapter.Fill(this.roomDATADataSet1.Table);
                        DateTime olddata=new DateTime(2040,10,30);
                        foreach (DataRow row in roomDATADataSet1.Table)
                        {
                            if (row[1].ToString() == Name1)
                            {
                                
                                    olddata = Convert.ToDateTime(row[4]);
                             

                            }
                        }
                        if (itsnewroom)
                        {
                            datamonth = monthCalendar1.SelectionRange.Start;
                        }
                        
                        tableTableAdapter.Update(int.Parse(textBox1.Text), richTextBox1.Text, "ЗАСЕЛЕНА", datamonth,Convert.ToDouble( textBox3.Text) ,ID, int.Parse(textBox1.Text), olddata,originalsuma);

                       
                        for (int i = 0; i < dataGridView2.Rows.Count-1; i++)
                        {
                            tableClientsTableAdapter.Update(dataGridView2[1, i].Value.ToString(),

                                dataGridView2[2, i].Value.ToString(),
                                dataGridView2[3, i].Value.ToString(),
                                dataGridView2[4, i].Value.ToString(),
                                ID.ToString(),
                               int.Parse( dataGridView2[0, i].Value.ToString()),
                                int.Parse(dataGridView2[0, i].Value.ToString()));
                        } 
                       
                        
                    }

                    else
                    {
                        DateTime datamonth11 = new DateTime(2040, 10, 30);
                        tableTableAdapter.Update(int.Parse(textBox1.Text), richTextBox1.Text, "ПУСТА", datamonth11,0, ID, int.Parse(textBox1.Text), olddatamonth,originalsuma);
                    }

                  //  redlabel.Text = "change";
                                           Close();
                }
                
            }
            else
            {
                MessageBox.Show("Номер квартири незаповнений");
                return;
            }
        }
        int a = 0;
        private void button3_Click(object sender, EventArgs e)
        {
           
            if (textBox2.Text!="")
            {
                pokaznikTableAdapter.Insert(ID, comboBox1.Text, dateTimePicker1.Value, textBox2.Text);
                textBox2.Text = "";
                rebootpokaznik.Text = a++.ToString();
            }
            else
            {
                MessageBox.Show("Введіть дані лічильника");
            }
           

        }

        private void button4_Click(object sender, EventArgs e)
        {
            pokaznikBindingSource.Filter = null;
            if (comboBox2.Text=="ВСІ")
            {
                string filter3 = string.Format("Idroom = '{0}'", ID);


                  pokaznikBindingSource.Filter = filter3;
                return;
            }
            //    
            string filter2 = string.Format("Idroom = '{0}' AND Vid_pokaznika = '{1}'", ID, comboBox2.Text); //добавляем условие для фильтрации по первому полю
                                                                                            //применяем фильтр
            pokaznikBindingSource.Filter = filter2;
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Clients form = new Clients(true, ID);
            form.lab1 = label3;
           // form.txt1 = textBox1;
           // form.txt2 = textBox2;
           // form.txt3 = textBox3;
            //form.txt4 = textBox4;
            form.ShowDialog();
        }

        private void label3_TextChanged(object sender, EventArgs e)
        {
            this.tableClientsTableAdapter.Fill(this.roomDATADataSet1.TableClients);
        
            string filter2 = string.Format("  Idroom = '{0}' OR Id= '{1}' ", ID,label3.Text); //добавляем условие для фильтрации по первому полю
                                                                         //string filter2 = string.Format(" Idroom = '{0}' AND Id= '{1}' ", ID, label3.Text);                                                    //применяем фильтр
           tableClientsBindingSource.Filter = filter2;
            //tableClientsBindingSource.Filter = "Idroom = '" + ID + "' AND Id =' "+label3.Text+"'";


        }

        private void button6_Click(object sender, EventArgs e)
        {
            string caption = "Так";
            string message = "Ви впевнені що хочете висилити цього жильця з квартири";
            DialogResult result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                return;
            }
            int a = tableClientsBindingSource.Find("Id", dataGridView2[0, dataGridView2.CurrentCell.RowIndex].Value.ToString());
            tableClientsTableAdapter.Update(dataGridView2[1, dataGridView2.CurrentCell.RowIndex].Value.ToString(),
                dataGridView2[2, dataGridView2.CurrentCell.RowIndex].Value.ToString(),
                dataGridView2[3, dataGridView2.CurrentCell.RowIndex].Value.ToString(),
                dataGridView2[4, dataGridView2.CurrentCell.RowIndex].Value.ToString(),
                "", Convert.ToInt32( dataGridView2[0, dataGridView2.CurrentCell.RowIndex].Value.ToString()));
            this.tableClientsTableAdapter.Fill(this.roomDATADataSet1.TableClients);
            if (dataGridView2.Rows.Count==1)
            {
                
                    tableTableAdapter.Update(int.Parse(textBox1.Text), richTextBox1.Text, "ПУСТА", monthCalendar1.SelectionRange.Start,0, ID, int.Parse(textBox1.Text), monthCalendar1.SelectionRange.Start,originalsuma);
               // redlabel.Text = "change";
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
           // this.tableOplataTableAdapter.Fill(this.roomDATADataSet1.TableOplata);
            tableOplataBindingSource.Filter = null;

           string filter2 = string.Format("  Idroom = '{0}' AND vid_pokaznika = '{1}' ", ID,comboBox3.Text); //добавляем условие для фильтрации по первому полю
                                                                                               //string filter2 = string.Format(" Idroom = '{0}' AND Id= '{1}' ", ID, label3.Text);                                                    //применяем фильтр
            tableOplataBindingSource.Filter = filter2;
            sumneoplat = sumoplat = 0;
            if (dataGridView3.Rows.Count != 1)
            {
                for (int i = 0; i < dataGridView3.Rows.Count - 1; i++)
                {
                    if (dataGridView3[3, i].Value.ToString() == "Не оплачений")
                    {
                        sumneoplat += Convert.ToDouble(dataGridView3[1, i].Value.ToString());
                        dataGridView3[3, i].Style.BackColor = System.Drawing.Color.Red;
                    }
                    else
                    {
                        sumoplat += Convert.ToDouble(dataGridView3[1, i].Value.ToString());
                        dataGridView3[3, i].Style.BackColor = System.Drawing.Color.Green;
                    }
                }
            }

            label7.Text = sumneoplat.ToString();
            label6.Text = sumoplat.ToString();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count==0)
            {
                MessageBox.Show("Таблиця пуста");
                return;
            }
            string caption = "Так";
            string message = "Ви впевнені що хочете видалити даний показник";
            DialogResult result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                return;
            }
            int a = pokaznikBindingSource.Find("Id", dataGridView1[0, dataGridView1.CurrentCell.RowIndex].Value.ToString());
            pokaznikBindingSource.RemoveAt(a);
            pokaznikTableAdapter.Update(roomDATADataSet1);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (dataGridView3.Rows.Count<2)
            {
                return;
            }
            if (dataGridView3[3, dataGridView3.CurrentCell.RowIndex].Value.ToString()=="Не оплачений")
            {


                tableOplataTableAdapter.Update(dataGridView3[1, dataGridView3.CurrentCell.RowIndex].Value.ToString(),
                    dataGridView3[2, dataGridView3.CurrentCell.RowIndex].Value.ToString(),
                    "Оплачений",
                      dataGridView3[4, dataGridView3.CurrentCell.RowIndex].Value.ToString(),
                     Convert.ToDateTime(dataGridView3[5, dataGridView3.CurrentCell.RowIndex].Value.ToString()),
                      Convert.ToInt32(dataGridView3[0, dataGridView3.CurrentCell.RowIndex].Value.ToString()),
                      Convert.ToDateTime(dataGridView3[5,dataGridView3.CurrentCell.RowIndex].Value.ToString()));

                tableOplataTableAdapter.Update(roomDATADataSet1);
                foreach (DataRow row in roomDATADataSet1.TableFinZvit)
                {
                    if (row[2].ToString() == Name1 && row[6].ToString()=="Оренда" && Convert.ToDateTime( row[5].ToString())== Convert.ToDateTime(dataGridView3[5, dataGridView3.CurrentCell.RowIndex].Value.ToString()))
                    {
                        row[3] = "Оплачений";
                        row[4] = DateTime.Today;
                        tableFinZvitTableAdapter.Update(row);

                    }
                }
                
                this.tableOplataTableAdapter.Fill(this.roomDATADataSet1.TableOplata);
                string filter3 = string.Format("  Idroom = '{0}' ", ID);
                tableOplataBindingSource.Filter = filter3;
                sumneoplat = 0;
                sumoplat = 0;
                if (dataGridView3.Rows.Count > 1)
                {
                    
                    for (int i = 0; i < dataGridView3.Rows.Count - 1; i++)
                    {
                        if (dataGridView3[3, i].Value.ToString() == "Не оплачений")
                        {
                            dataGridView3[3, i].Style.BackColor = Color.Red;

                            sumneoplat += Convert.ToDouble(dataGridView3[1, i].Value.ToString());



                        }
                        else
                        {
                            dataGridView3[3, i].Style.BackColor = System.Drawing.Color.Green;
                            sumoplat += Convert.ToDouble(dataGridView3[1, i].Value.ToString());

                        }

                    }
                }

                label7.Text = sumneoplat.ToString();
                label6.Text = sumoplat.ToString();
            }

        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            if (dataGridView2.Rows.Count>1)
            {
                monthCalendar1.Visible = true;
                label8.Visible = true;
            }
            else
            {
                monthCalendar1.Visible = false;
                label8.Visible = false;
            }
            sumneoplat = 0;
            sumoplat = 0;
            if (dataGridView3.Rows.Count > 1)
            {

                for (int i = 0; i < dataGridView3.Rows.Count - 1; i++)
                {
                    if (dataGridView3[3, i].Value.ToString() == "Не оплачений")
                    {
                        dataGridView3[3, i].Style.BackColor = Color.Red;

                        sumneoplat += Convert.ToDouble(dataGridView3[1, i].Value.ToString());



                    }
                    else
                    {
                        dataGridView3[3, i].Style.BackColor = System.Drawing.Color.Green;
                        sumoplat += Convert.ToDouble(dataGridView3[1, i].Value.ToString());

                    }

                }
            }

            label7.Text = sumneoplat.ToString();
            label6.Text = sumoplat.ToString();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }

        private void rebootpokaznik_TextChanged(object sender, EventArgs e)
        {
            this.pokaznikTableAdapter.Fill(this.roomDATADataSet1.Pokaznik);
        }
        DateTime newdata;
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            newdata = monthCalendar1.SelectionRange.Start;
            datamonth = newdata;
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (dataGridView3.Rows.Count>1)
            {
                DateTime dt = Convert.ToDateTime(dataGridView3[5, dataGridView3.CurrentCell.RowIndex].Value.ToString());
                double sum = Convert.ToDouble(dataGridView3[1, dataGridView3.CurrentCell.RowIndex].Value.ToString());
                foreach (DataRow row in roomDATADataSet1.TableFinZvit)
                {
                    if (row[2].ToString()==ID.ToString() && Convert.ToDateTime(row[5].ToString())== dt && Convert.ToDouble(row[1].ToString())==sum )
                    {
                        int b = bindingSource3.Find("Id", row[0].ToString());

                        bindingSource3.RemoveAt(b);
                        tableFinZvitTableAdapter.Update(roomDATADataSet1);
                        
                        break;
                    }
                }
                int a = tableOplataBindingSource.Find("Id", dataGridView3[0, dataGridView3.CurrentCell.RowIndex].Value.ToString());
                tableOplataBindingSource.RemoveAt(a);
                tableOplataTableAdapter.Update(roomDATADataSet1);

                MessageBox.Show("Оплата видалена");
            }
        }
    }
}
