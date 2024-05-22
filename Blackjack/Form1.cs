using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blackjack
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int bahismiktari = 0;
        int kazanc = 0;
        int kayip = 0;


        private void bahisToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.MaxLength = 20;
            taboyun.Enabled = false;
        }

        private void butonaz_Click(object sender, EventArgs e)
        {
            bahismiktari = bahismiktari - 10;
            labelbhs.Text = bahismiktari.ToString();

            if (bahismiktari == 0)
            {
                butonaz.Enabled = false;
            }
            if (bahismiktari <= 600)
            {
                butonart.Enabled = true;
            }
        }

        private void butonart_Click(object sender, EventArgs e)
        {
            bahismiktari = bahismiktari + 10;
            labelbhs.Text = bahismiktari.ToString();

            if (bahismiktari == 600)
            {
                butonart.Enabled = false;
            }
            if (bahismiktari >= 0)
            {
                butonaz.Enabled = true;
            }
        }

        private void buton100_Click(object sender, EventArgs e)
        {
            bahismiktari = 100;
            labelbhs.Text = bahismiktari.ToString();
            butonart.Enabled = true;
            butonaz.Enabled = true;
        }

        private void buton200_Click(object sender, EventArgs e)
        {
            bahismiktari = 200;
            labelbhs.Text = bahismiktari.ToString();
            butonart.Enabled = true;
            butonaz.Enabled = true;
        }

        private void buton300_Click(object sender, EventArgs e)
        {
            bahismiktari = 300;
            labelbhs.Text = bahismiktari.ToString();
            butonart.Enabled = true;
            butonaz.Enabled = true;
        }

        private void buton400_Click(object sender, EventArgs e)
        {
            bahismiktari = 400;
            labelbhs.Text = bahismiktari.ToString();
            butonart.Enabled = true;
            butonaz.Enabled = true;
        }

        private void buton500_Click(object sender, EventArgs e)
        {
            bahismiktari = 500;
            labelbhs.Text = bahismiktari.ToString();
            butonart.Enabled = true;
            butonaz.Enabled = true;
        }

        private void buton600_Click(object sender, EventArgs e)
        {
            bahismiktari = 600;
            labelbhs.Text = bahismiktari.ToString();
            butonart.Enabled = false;
            butonaz.Enabled = true;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabbahis_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void taboyun_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tabbilgi_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                groupBoxbhs.Visible = false;
            }
            else
            {
                groupBoxbhs.Visible = true;
            }
            
        }

        private void labelbhs_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (bahismiktari == 0)
            {
                MessageBox.Show("Bahis giriniz!","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult cevap;
                cevap = MessageBox.Show("Bir daha değişiklik yapamazsınız. Girdiğiniz bilgileri onaylıyor musunuz?", "Onay", MessageBoxButtons.YesNo,MessageBoxIcon.Information);
                if (cevap == DialogResult.Yes)
                {
                    //label5.Text = textBox1.Text;
                    //label7.Text = bahismiktari.ToString();

                    groupBoxbhs.Enabled = false;
                    groupBoxbhs.Visible = false;
                    textBox1.Visible = false;
                    label3.Visible = false;
                    textBox1.Enabled = false;
                    //groupBoxbilgi.Visible = true;
                    label2.Visible = false;
                    label1.Visible = true;

                    labelbilgiwho.Text = textBox1.Text;
                    labelbilgibhs.Text = bahismiktari.ToString();
                    groupBoxbilgi.Visible = true;

                    tabControl1.SelectedTab = taboyun;
                    tabbahis.Enabled = false;
                    taboyun.Enabled = true;
                    //button1.Visible = false;

                }
                else
                {

                }
                
            }
        }
    }
}
