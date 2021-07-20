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
    public partial class Pribiranya : Form
    {
        public Pribiranya()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label_reb.Text = "old";
            NewPribiranya nprib = new NewPribiranya();
            nprib.reboot = label_reb;
            nprib.ShowDialog();
        }

        private void Pribiranya_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "roomDATADataSet.TablePribiranya". При необходимости она может быть перемещена или удалена.
            this.tablePribiranyaTableAdapter.Fill(this.roomDATADataSet.TablePribiranya);

        }

        private void label_reb_TextChanged(object sender, EventArgs e)
        {
            this.tablePribiranyaTableAdapter.Fill(this.roomDATADataSet.TablePribiranya);
        }
    }
}
