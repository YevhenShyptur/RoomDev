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
    public partial class NewPribiranya : Form
    {
        public NewPribiranya()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RoomListChoose form = new RoomListChoose();
            form.labelID = label_id_room;
            form.butNameRoom = button1;
            form.ShowDialog();
        }
        public Label reboot;
        private void button2_Click(object sender, EventArgs e)
        {
            if (button1.Text=="виберіть квартиру")
            {
                MessageBox.Show("виберіть квартиру");
                return;
            }
            int a = bindingSource1.Find("idroom", label_id_room.Text);
            if (a!=-1)
            {
               
                bindingSource1.RemoveAt(a);
            }
            
           
            tablePribiranyaTableAdapter.Insert(label_id_room.Text, button1.Text, monthCalendar1.SelectionRange.Start, "добре прибрано");

            tablePribiranyaTableAdapter.Update(roomDATADataSet);
            reboot.Text = "new";
                Close();
        }

        private void NewPribiranya_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "roomDATADataSet.TablePribiranya". При необходимости она может быть перемещена или удалена.
            this.tablePribiranyaTableAdapter.Fill(this.roomDATADataSet.TablePribiranya);
            button2.BackColor = Color.Green;
            button3.BackColor = Color.Red;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button1.Text == "виберіть квартиру")
            {
                MessageBox.Show("виберіть квартиру");
                return;
            }
            int a = bindingSource1.Find("idroom", label_id_room.Text);
            if (a != -1)
            {
                MessageBox.Show(a.ToString());
                bindingSource1.RemoveAt(a);
            }


            tablePribiranyaTableAdapter.Insert(label_id_room.Text, button1.Text, monthCalendar1.SelectionRange.Start, "погано прибрано");

            tablePribiranyaTableAdapter.Update(roomDATADataSet);
            reboot.Text = "new";
            Close();

        }
    }
}
