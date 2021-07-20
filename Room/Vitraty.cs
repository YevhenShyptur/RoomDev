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
    public partial class Vitraty : Form
    {
        public Vitraty()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="")
            {
                MessageBox.Show("Заповніть поле за що оплата!");
                return;
            }
            if (textBox2.Text=="")
            {
                MessageBox.Show("Введіть суму до списання!");
                return;
            }
            double a = -1 * Convert.ToDouble(textBox2.Text);
            tableFinZvitTableAdapter.Insert(a.ToString(), "-", "Витрати", monthCalendar1.SelectionStart, monthCalendar1.SelectionStart, textBox1.Text);
            MessageBox.Show("Кошти списані");
            Close(); }

        private void Vitraty_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "roomDATADataSet.TableFinZvit". При необходимости она может быть перемещена или удалена.
            this.tableFinZvitTableAdapter.Fill(this.roomDATADataSet.TableFinZvit);
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
