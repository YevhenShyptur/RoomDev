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
    public partial class NewBook : Form
    {
        public NewBook()
        {
            InitializeComponent();
        }

        private void NewBook_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "roomDATADataSet.TableClients". При необходимости она может быть перемещена или удалена.
            this.tableClientsTableAdapter.Fill(this.roomDATADataSet.TableClients);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "roomDATADataSet.TableBook". При необходимости она может быть перемещена или удалена.
            this.tableBookTableAdapter.Fill(this.roomDATADataSet.TableBook);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "roomDATADataSet.Table". При необходимости она может быть перемещена или удалена.
            this.tableTableAdapter.Fill(this.roomDATADataSet.Table);
            year = DateTime.Now.Year;
            month = DateTime.Now.Month;
            DateTime now = DateTime.Now;
            DateTime label = new DateTime(year, month,1);
            label1.Text = label.ToString("y");
            dataGridView1.RowCount = 6;
            int day = 0;
            int daysInCurrentMonth = System.DateTime.DaysInMonth(year, month);//сколько дней в месяце

                DateTime date1 = new DateTime(year, month, 1); // какой день первое число
            switch (date1.DayOfWeek.ToString())
            {
                case "Monday":

                    day = 1;
                    break;
                case "Tuesday":

                    day = 2;
                    break;
                case "Wednesday":

                    day = 3;
                    break;
                case "Thursday":

                    day = 4;
                    break;
                case "Friday":

                    day = 5;
                    break;
                case "Saturday":

                    day = 6;
                    break;
                case "Sunday":

                    day = 7;
                    break;
            }
            int daycalendar = 1;
            for (int i = day-1; i < 7; i++)
            {
                dataGridView1[i, 0].Value = daycalendar;
                daycalendar++;
            }
            for (int i = 1; i < 6; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    if (daycalendar<=daysInCurrentMonth)
                    {
                        dataGridView1[j, i].Value = daycalendar;
                        daycalendar++;
                    }
                   
                }
            }


        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }
        int daysInCurrentMonth;
        DateTime daybook;
        int year;
        int month;
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.RowCount = 6;
            int day = 0;
            month++;
            if (month==13)
            {
                month=1;
                year++;
            }
            DateTime label = new DateTime(year, month, 1);
            label1.Text = label.ToString("y");
            daysInCurrentMonth = System.DateTime.DaysInMonth(year, month);//сколько дней в месяце

            DateTime date1 = new DateTime(year, month, 1); // какой день первое число
            switch (date1.DayOfWeek.ToString())
            {
                case "Monday":
                   
                    day = 1;
                    break;
                case "Tuesday":
                   
                    day = 2;
                    break;
                case "Wednesday":
                   
                    day = 3;
                    break;
                case "Thursday":
                   
                    day = 4;
                    break;
                case "Friday":
                  
                    day = 5;
                    break;
                case "Saturday":
                   
                    day = 6;
                    break;
                case "Sunday":
                   
                    day = 7;
                    break;
            }
            int daycalendar = 1;
            for (int i = day - 1; i < 7; i++)
            {
                dataGridView1[i, 0].Value = daycalendar;
                daycalendar++;
            }
            for (int i = 1; i < 6; i++)
            {
                for (int f   = 0; f < 7; f++)
                {
                    if (daycalendar <= daysInCurrentMonth)
                    {
                        dataGridView1[f, i].Value = daycalendar;
                        daycalendar++;
                    }

                }
            }
            DateTime dt;
            int j = 0;
            string[] daysbook1 = new string[31];
            if (dataGridView2.RowCount > 0)
            {


                for (int i = 0; i < dataGridView2.RowCount; i++)
                {
                    dt = Convert.ToDateTime(dataGridView2[2, i].Value.ToString());
                    if (dt.ToString("y") == label1.Text)
                    {
                        daysbook1[j] = dt.Day.ToString();
                        j++;
                    }
                }


                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    for (int k = 0; k < dataGridView1.ColumnCount; k++)
                    {
                        for (int z = 0; z < daysbook1.Length; z++)
                        {
                            if (daysbook1[z] != null && dataGridView1[k, i].Value != null)
                            {
                                if (daysbook1[z] == dataGridView1[k, i].Value.ToString())
                                {
                                    dataGridView1[k, i].Style.BackColor = System.Drawing.Color.Yellow;
                                }
                            }

                        }
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.RowCount = 6;
            int day = 0;
            month--;
            if (month == 0)
            {
                month = 12;
                year--;
            }
            DateTime label = new DateTime(year, month, 1);
            label1.Text = label.ToString("y");
            daysInCurrentMonth = System.DateTime.DaysInMonth(year, month);//сколько дней в месяце

            DateTime date1 = new DateTime(DateTime.Now.Year, month, 1); // какой день первое число
            switch (date1.DayOfWeek.ToString())
            {
                case "Monday":

                    day = 1;
                    break;
                case "Tuesday":

                    day = 2;
                    break;
                case "Wednesday":

                    day = 3;
                    break;
                case "Thursday":

                    day = 4;
                    break;
                case "Friday":

                    day = 5;
                    break;
                case "Saturday":

                    day = 6;
                    break;
                case "Sunday":

                    day = 7;
                    break;
            }
            int daycalendar = 1;
            for (int i = day - 1; i < 7; i++)
            {
                dataGridView1[i, 0].Value = daycalendar;
                daycalendar++;
            }
            for (int i = 1; i < 6; i++)
            {
                for (int f   = 0; f < 7; f++)
                {
                    if (daycalendar <= daysInCurrentMonth)
                    {
                        dataGridView1[f, i].Value = daycalendar;
                        daycalendar++;
                    }

                }
            }
            DateTime dt;
            int j = 0;
            string[] daysbook1 = new string[31];
            if (dataGridView2.RowCount > 0)
            {


                for (int i = 0; i < dataGridView2.RowCount; i++)
                {
                    dt = Convert.ToDateTime(dataGridView2[2, i].Value.ToString());
                    if (dt.ToString("y") == label1.Text)
                    {
                        daysbook1[j] = dt.Day.ToString();
                        j++;
                    }
                }


                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    for (int k = 0; k < dataGridView1.ColumnCount; k++)
                    {
                        for (int z = 0; z < daysbook1.Length; z++)
                        {
                            if (daysbook1[z] != null && dataGridView1[k, i].Value != null)
                            {
                                if (daysbook1[z] == dataGridView1[k, i].Value.ToString())
                                {
                                    dataGridView1[k, i].Style.BackColor = System.Drawing.Color.Yellow;
                                }
                            }

                        }
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (label_id_room.Text== "label_id_room")
            {
                MessageBox.Show("Не вибрана квартира");
                return;
            }
            if (label_id_client.Text== "label_id_client")
            {
                MessageBox.Show("Не вибраний клієнт");
                return;

            }
            for (int i = 0; i < dataGridView1.SelectedCells.Count; i++)
            {
                if (dataGridView1.SelectedCells[i].Value.ToString()!="")
                {
                    daybook= new DateTime(year, month,Convert.ToInt32(dataGridView1.SelectedCells[i].Value.ToString()) );
                   // MessageBox.Show(year.ToString() + "." + month.ToString() + "." + dataGridView1.SelectedCells[i].Value.ToString());
                    // bindingSource1.Find()
                    // tableBookTableAdapter.Insert()
                    tableBookTableAdapter.Insert(label_id_room.Text, daybook, label_id_client.Text, textBox5.Text);
                
                }
                
            }
            Close();
        }

        
        
        private void button3_Click(object sender, EventArgs e)
        {
            RoomListChoose form = new RoomListChoose();
            form.labelID = label_id_room;
            form.butNameRoom = button3;
            form.ShowDialog();
           
        }

        private void label_id_room_TextChanged(object sender, EventArgs e)
        {
          

        bindingSource1.Filter = null;
            
            string filter = string.Format(" idroom ='{0}'", label_id_room.Text); //добавляем условие для фильтрации по первому полю

         
            bindingSource1.Filter = filter;

            DateTime dt;
            int j = 0;
            string[] daysbook1 = new string[31];
            string[] daysbook2 = new string[31];
            if (dataGridView2.RowCount > 0)
            {


                for (int i = 0; i < dataGridView2.RowCount; i++)
                {
                    dt = Convert.ToDateTime(dataGridView2[2, i].Value.ToString());
                    if (dt.ToString("y") == label1.Text)
                    {
                        daysbook1[j] = dt.Day.ToString();
                        daysbook2[j]= dataGridView2[3, i].Value.ToString();
                j++;
                    }
                }
              
                
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    for (int k = 0; k < dataGridView1.ColumnCount; k++)
                    {
                        for (int z = 0; z < daysbook1.Length; z++)
                        {
                            if (daysbook1[z] != null && dataGridView1[k, i].Value != null)
                            {
                                if (daysbook1[z] == dataGridView1[k, i].Value.ToString())
                                {
                                    dataGridView1[k, i].Style.BackColor = System.Drawing.Color.Yellow;
                                    string[] w= search(daysbook2[z]);
                                    dataGridView1[k, i].ToolTipText = w[0] + "/ " + w[1] + "/ " + w[2] + "/ " + w[3];
                                }
                            }
                           
                        }
                    }
                }
            }

        }
         private string[] search(string id)
        {
            string[] m=new string[4];
            for (int i = 0; i < dataGridView3.RowCount; i++)
            {
                if (dataGridView3[0, i].Value.ToString()==id)
                { m[0] = dataGridView3[1, i].Value.ToString();
                    m[1] = dataGridView3[2, i].Value.ToString();
                    m[2] = dataGridView3[3, i].Value.ToString();
                    m[3] = dataGridView3[4, i].Value.ToString();
                    break;
                }
                
                

            }
            return m;
        }
              private void button6_Click(object sender, EventArgs e)
        {
            Clients form = new Clients(true,0);
            form.lab1 = label_id_client;
            form.txt1 = textBox1;
            form.txt2 = textBox2;
            form.txt3 = textBox3;
            form.txt4 = textBox4;
            form.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
         //   MessageBox.Show(dataGridView1[])
        }
    }
}
