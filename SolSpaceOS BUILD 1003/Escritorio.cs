using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using SolSpaceOS.Properties;

namespace SolSpaceOS
{
    public partial class Escritorio : Form
    {
        public Image icon;
        public Escritorio()
        {
            InitializeComponent();
        }

        private void Escritorio_Load(object sender, EventArgs e)
        {
            SoundPlayer start = new SoundPlayer(Resources.Startup);
            start.PlaySync();
            label1.Text = "ESTO ES UN SIMULADOR DE SISTEMA OPERATIVO NO REAL BUILD 1003";
            panel2.Visible = false;
            icon = PapeleraIco.Image;
            label5.Text = "OrangeWeb";
            label3.Text = "Papelera";
            label6.Text = "Tienda";
            OrangeWeb orange = new OrangeWeb();
            orange.SetBevel(false);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
            SoundPlayer shut = new SoundPlayer(Resources.Shutdown);
            shut.PlaySync();
            panel2.Visible = false;
            panel3.Visible = false;
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            panel3.Visible = true;
            label4.Text = "OrangeWeb";
            label7.Text = "Tienda";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            if (panel2.Visible == true)
            {
                panel2.Visible = true;
            }
            else
            {
                panel2.Visible = false;
            }
        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            this.panel3.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.panel3.Visible = true;
        }

        private void panel3_MouseLeave(object sender, EventArgs e)
        {
            this.panel3.Visible = true;
        }

        private void Escritorio_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            this.label2.Visible = true;
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            panel2.Visible = false;
        }

        private void panel3_Leave(object sender, EventArgs e)
        {
            panel3.Visible = false;
        }

        private void panel2_MouseEnter(object sender, EventArgs e)
        {
            panel3.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Volumen f = new Volumen();
            f.TopLevel = false;
            f.Parent = this;
            f.Show();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            this.label2.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.label2.Visible = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (label3.Text == textBox1.Text)
            {
                label3.ForeColor = Color.White;
            }else{
                label3.ForeColor = Color.Black;
            }
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Sobre f = new Sobre();
            f.TopLevel = false;
            f.Parent = this;
            f.Show();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            panel3.Visible = true;
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel3.Visible = false;

            OrangeWeb orange = new OrangeWeb();
            orange.TopLevel = false;
            orange.Parent = this;
            MDIClientSupport.SetBevel(orange, true);
            orange.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            OrangeWeb orange = new OrangeWeb();
            orange.TopLevel = false;
            orange.Parent = this;
            orange.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Tienda tiend = new Tienda();
            tiend.TopLevel = false;
            tiend.Parent = this;
            tiend.Show();
        }
    }
}
