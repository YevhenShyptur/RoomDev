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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            bts[0] = button1;
            bts[1] = button2;
            bts[2] = button3;
            bts[3] = button4;
            bts[4] = button5;
            bts[5] = button6;
            bts[6] = button7;
            bts[7] = button8;
            bts[8] = button9;
            bts[9] = button10;
            bts[10] = button11;
            bts[11] = button12;
            bts[12] = button13;
            bts[13] = button14;
            bts[14] = button15;
            bts[15] = button16;
            bts[16] = button17;
            bts[17] = button18;
            bts[18] = button19;
            bts[19] = button20;
            bts[20] = button21;
            bts[21] = button22;
            bts[22] = button23;
            bts[23] = button24;
            bts[24] = button25;
            bts[25] = button26;
            bts[26] = button27;
            bts[27] = button28;
            bts[28] = button29;
            bts[29] = button30;
            bts[30] = button31;
            bts[31] = button32;
            bts[32] = button33;
            bts[33] = button34;
            bts[34] = button35;
            bts[35] = button36;
            bts[36] = button37;
            bts[37] = button38;
            bts[38] = button39;
            bts[39] = button40;
            bts[40] = button41;
            bts[41] = button42;
            bts[42] = button43;
            bts[43] = button44;
            bts[44] = button45;
            bts[45] = button46;
            bts[46] = button47;
            bts[47] = button48;
            bts[48] = button49;
            bts[49] = button50;
            bts[50] = button51;
            bts[51] = button52;
            labelbts[0] = label1;
            labelbts[1] = label2;
            labelbts[2] = label3;
            labelbts[3] = label4;
            labelbts[4] = label5;
            labelbts[5] = label6;
            labelbts[6] = label7;
            labelbts[7] = label8;
            labelbts[8] = label9;
            labelbts[9] = label10;
            labelbts[10] = label11;
            labelbts[11] = label12;
            labelbts[12] = label13;
            labelbts[13] = label14;
            labelbts[14] = label15;
            labelbts[15] = label16;
            labelbts[16] = label17;
            labelbts[17] = label18;
            labelbts[18] = label19;
            labelbts[19] = label20;
            labelbts[20] = label21;
            labelbts[21] = label22;
            labelbts[22] = label23;
            labelbts[23] = label24;
            labelbts[24] = label25;
            labelbts[25] = label26;
            labelbts[26] = label27;
            labelbts[27] = label28;
            labelbts[28] = label29;
            labelbts[29] = label30;
            labelbts[30] = label31;
            labelbts[31] = label32;
            labelbts[32] = label33;
            labelbts[33] = label34;
            labelbts[34] = label35;
            labelbts[35] = label36;
            labelbts[36] = label37;
            labelbts[37] = label38;
            labelbts[38] = label39;
            labelbts[39] = label40;
            labelbts[40] = label41;
            labelbts[41] = label42;
            labelbts[42] = label43;
            labelbts[43] = label44;
            labelbts[44] = label45;
            labelbts[45] = label46;
            labelbts[46] = label47;
            labelbts[47] = label48;
            labelbts[48] = label49;
            labelbts[49] = label50;
            labelbts[50] = label51;
            labelbts[51] = label52;


        }

        private void додатиНовуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new New_Room(false);
            form.ShowDialog();
        }

        private void списокКвартирToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form1 = new Room_list();
            form1.ShowDialog();
        }

        private void додатиКлієнтаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new NewClient(false);
            form.ShowDialog();
        }

        private void списокКлієнтівToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clients form = new Clients(false,0);
            form.ShowDialog();
        }

        private void додатиБроньToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new NewBook();
            form.ShowDialog();
        }
        Button[] bts = new Button[52];
        Label[] labelbts = new Label[52];
        
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "roomDATADataSet.TableFinZvit". При необходимости она может быть перемещена или удалена.
            this.tableFinZvitTableAdapter.Fill(this.roomDATADataSet.TableFinZvit);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "roomDATADataSet.TableOplata". При необходимости она может быть перемещена или удалена.
            this.tableOplataTableAdapter.Fill(this.roomDATADataSet.TableOplata);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "roomDATADataSet.Table". При необходимости она может быть перемещена или удалена.
            this.tableTableAdapter.Fill(this.roomDATADataSet.Table);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "roomDATADataSet.TableBook". При необходимости она может быть перемещена или удалена.
            this.tableBookTableAdapter.Fill(this.roomDATADataSet.TableBook);



            changecolorbuttons(bts);
            changelabelbuttons(labelbts);

            findneworder();
        }
     
        public void findneworder()
        {
            DateTime dt = DateTime.Today;
            DateTime lastday=new DateTime(2040,10,30);
            DateTime lastday1 = new DateTime(2040, 10, 30);
            foreach (DataRow row in roomDATADataSet.Table)
            {
                lastday = lastday1;
                if (row[3].ToString()=="ЗАСЕЛЕНА")
                {
                    this.tableFinZvitTableAdapter.Fill(this.roomDATADataSet.TableFinZvit);
                    foreach (DataRow rowoplata in roomDATADataSet.TableFinZvit)
                    {
                        if (row[0].ToString() == rowoplata[2].ToString() && rowoplata[6].ToString()=="Оренда"  )
                        {
                            lastday = Convert.ToDateTime(rowoplata[5].ToString());
                        }
                    }
                     dt = Convert.ToDateTime(row[4].ToString());
                    bool itsthisdata = false;
                    DateTime newlastday = lastday;
                    while (dt<=newlastday)
                    {
                        if (dt==newlastday)
                        {
                            itsthisdata = true;
                        }
                        newlastday = newlastday.AddMonths(-1);

                    }
                    if (lastday != lastday1 & itsthisdata)
                    {
                        while (lastday.AddMonths(1) <= DateTime.Today)
                        {
                            tableFinZvitTableAdapter.Insert(row[5].ToString(),
                                row[0].ToString(),
                                "Не оплачений",
                                null,
                                lastday.AddMonths(1),
                                "Оренда");
                            tableOplataTableAdapter.Insert(row[5].ToString(),
                               row[0].ToString(), "Не оплачений", "Оренда", lastday.AddMonths(1));
                            lastday = lastday.AddMonths(1);
                        }
                    }
                    else
                    {
                        while (dt <= DateTime.Today)
                        {
                            tableFinZvitTableAdapter.Insert(row[5].ToString(),
                                row[0].ToString(),
                                "Не оплачений",
                                null,
                                dt,
                                "Оренда");
                            tableOplataTableAdapter.Insert(row[5].ToString(),
                              row[0].ToString(), "Не оплачений", "Оренда", dt);
                            dt = dt.AddMonths(1);

                        }
                    }
                    
                    
                }
                
            }
        }
        public void changelabelbuttons(Label[] labels)
        {
            this.tableTableAdapter.Fill(this.roomDATADataSet.Table);
            this.tableOplataTableAdapter.Fill(this.roomDATADataSet.TableOplata);
            //this.tableFinZvitTableAdapter.Fill(this.roomDATADataSet.TableFinZvit);
            for (int i = 0; i < bts.Length; i++)
            {
                labelbts[i].Text = "Оплачений";
                    foreach (DataRow row in roomDATADataSet.Table)
                    {
                    
                    if (row[1].ToString()==bts[i].Text)
                    {
                        if (row[3].ToString()=="ЗАСЕЛЕНА")
                        {

                            foreach (DataRow rowoplata in roomDATADataSet.TableFinZvit)
                            {
                                if (row[1].ToString()==rowoplata[2].ToString() && rowoplata[3].ToString()=="Не оплачений")
                                {
                                    labelbts[i].Text = "Не оплачений";
                                    break;
                                }
                            }
                            
                        }
                        else
                        {
                            labelbts[i].Text = "---";

                        }

                    }
                   
                    }
                
            }
            
        }
        public void changecolorbuttons(Button[] bts1)
        {
           
            this.tableTableAdapter.Fill(this.roomDATADataSet.Table);
            for (int i = 0; i < bts1.Length; i++)
            {
                foreach (DataRow row in roomDATADataSet.Table)
                {
                    if (row[1].ToString() == bts1[i].Text)
                    {
                        if (row[3].ToString()=="ЗАСЕЛЕНА")
                        {
                            if (row[2].ToString() =="Короткий період")
                            {
                                bts1[i].BackColor = Color.Yellow;
                            }
                            else
                            {
                                bts1[i].BackColor = Color.Red;
                            }
                           
                        }
                        else
                        {
                            
                                bts1[i].BackColor = Color.LightGreen;
                            
                        }


                    }
                }
            }
            findneworder();
        }
        public void redroomfrombutton(Button bt)
        {
            RedRoom form3 = new RedRoom(bt.Text);

            form3.ShowDialog();
          
            changecolorbuttons(bts);
            changelabelbuttons(labelbts);
        }
        private void новийПлатіжToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fr = new NewOrder();
            fr.ShowDialog();
            changecolorbuttons(bts);
            changelabelbuttons(labelbts);
        }

        private void витратиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vitraty form12 = new Vitraty();
            form12.ShowDialog();
            changecolorbuttons(bts);
            changelabelbuttons(labelbts);
        }

        private void фінансовийЗвітToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fin_zvit fn = new fin_zvit();
            fn.ShowDialog();
            changecolorbuttons(bts);
            changelabelbuttons(labelbts);
        }

        private void прибиранняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pribiranya pib = new Pribiranya();
            pib.ShowDialog();
            changecolorbuttons(bts);
            changelabelbuttons(labelbts);
        }

        private void подобоваОрендаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dobovaorenda dobor = new dobovaorenda();
            dobor.ShowDialog();
            changecolorbuttons(bts);
            changelabelbuttons(labelbts);
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // New_Room nw = new New_Room(false);
            //nw.ShowDialog();
            redroomfrombutton(button1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            redroomfrombutton(button2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            redroomfrombutton(button3);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            redroomfrombutton(button9);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            redroomfrombutton(button5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            redroomfrombutton(button6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            redroomfrombutton(button7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            redroomfrombutton(button8);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            redroomfrombutton(button4);
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
            redroomfrombutton(button18);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            redroomfrombutton(button13);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            redroomfrombutton(button14);

        }

        private void button15_Click(object sender, EventArgs e)
        {
            redroomfrombutton(button15);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            redroomfrombutton(button10);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            redroomfrombutton(button11);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            redroomfrombutton(button19);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            redroomfrombutton(button16);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            redroomfrombutton(button17);

        }

        private void button12_Click(object sender, EventArgs e)
        {
            redroomfrombutton(button12);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            redroomfrombutton(button20);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            redroomfrombutton(button23);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            redroomfrombutton(button24);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            redroomfrombutton(button25);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            redroomfrombutton(button26);

        }

        private void button27_Click(object sender, EventArgs e)
        {
            redroomfrombutton(button27);
        }

        private void button28_Click(object sender, EventArgs e)
        {
            redroomfrombutton(button28);
        }

        private void button29_Click(object sender, EventArgs e)
        {
            redroomfrombutton(button29);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            redroomfrombutton(button21);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            redroomfrombutton(button22);
        }

        private void button30_Click(object sender, EventArgs e)
        {
            redroomfrombutton(button30);
        }

        private void button33_Click(object sender, EventArgs e)
        {
            redroomfrombutton(button33);
        }

        private void button34_Click(object sender, EventArgs e)
        {
            redroomfrombutton(button34);
        }

        private void button35_Click(object sender, EventArgs e)
        {
            redroomfrombutton(button35);
        }

        private void button36_Click(object sender, EventArgs e)
        {
            redroomfrombutton(button36);
        }

        private void button37_Click(object sender, EventArgs e)
        {
            redroomfrombutton(button37);
        }

        private void button38_Click(object sender, EventArgs e)
        {
            redroomfrombutton(button38);
        }

        private void button39_Click(object sender, EventArgs e)
        {
            redroomfrombutton(button39);
        }

        private void button31_Click(object sender, EventArgs e)
        {
            redroomfrombutton(button31);
        }

        private void button32_Click(object sender, EventArgs e)
        {
            redroomfrombutton(button32);
        }

        private void button45_Click(object sender, EventArgs e)
        {
            redroomfrombutton(button45);
        }

        private void button43_Click(object sender, EventArgs e)
        {
            redroomfrombutton(button43);
        }

        private void button41_Click(object sender, EventArgs e)
        {
            redroomfrombutton(button41);
        }

        private void button40_Click(object sender, EventArgs e)
        {
            redroomfrombutton(button40);
        }

        private void button46_Click(object sender, EventArgs e)
        {
            redroomfrombutton(button46);
        }

        private void button44_Click(object sender, EventArgs e)
        {
            redroomfrombutton(button44);
        }

        private void button42_Click(object sender, EventArgs e)
        {
            redroomfrombutton(button42);
        }

        private void button52_Click(object sender, EventArgs e)
        {
            redroomfrombutton(button52);
        }

        private void button47_Click(object sender, EventArgs e)
        {
            redroomfrombutton(button47);
        }

        private void button48_Click(object sender, EventArgs e)
        {
            redroomfrombutton(button48);
        }

        private void button49_Click(object sender, EventArgs e)
        {
            redroomfrombutton(button49);
        }

        private void button50_Click(object sender, EventArgs e)
        {
            redroomfrombutton(button50);
        }

        private void button51_Click(object sender, EventArgs e)
        {
            redroomfrombutton(button51);
        }

        private void labelreboot_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
