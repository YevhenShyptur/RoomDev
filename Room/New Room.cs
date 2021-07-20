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
    public partial class New_Room : Form
    {
        public New_Room(bool reboot)
        {
            InitializeComponent();
            rebotorno = reboot;
        }
        bool rebotorno;//= false;
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
        public Label reb;
        public Label kukuriku;
        public Button but111;
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="")
            {
                MessageBox.Show("Введіть номер квартири");
                return;
            }
            int a = bindingSource1.Find("Number", textBox1.Text);
            if (a != -1)
            {
                MessageBox.Show("Дана квартира вже існує змініть назву");
                return;
            }
           // tableTableAdapter.Insert(int.Parse( textBox1.Text), richTextBox1.Text,"ПУСТА",System.DateTime.Today);
            if (rebotorno)
            {
                reb.Text = "new";
            }
            
            Close();
        }

        private void New_Room_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "roomDATADataSet1.TableClients". При необходимости она может быть перемещена или удалена.
            this.tableClientsTableAdapter.Fill(this.roomDATADataSet1.TableClients);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "roomDATADataSet1.Table". При необходимости она может быть перемещена или удалена.
            this.tableTableAdapter.Fill(this.roomDATADataSet1.Table);
            button1.BackColor = Color.Green;
            button2.BackColor = Color.Red;
        }
        

    }
}
