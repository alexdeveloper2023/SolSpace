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
using System.Drawing.Text;

namespace SolSpaceOS
{
    public partial class Act : Form
    {
        public Label name = new Label();
        public Act()
        {
            InitializeComponent();
        }

        private void Escritorio_Load(object sender, EventArgs e)
        {
            SoundPlayer start = new SoundPlayer(Resources.Startup);
            start.Play();
            label1.Text = "ESTO ES UN SIMULADOR DE SISTEMA OPERATIVO NO REAL BUILD 1004";
            panel2.Visible = false;
            MDIClientSupport.SetBevel(this, false);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
            SoundPlayer shut = new SoundPlayer(Resources.Shutdown);
            shut.PlaySync();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (panel2.Visible == false)
            {
                panel2.Visible = true;
            }
            else
            {
                panel2.Visible = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Volumen v = new Volumen();
            v.TopLevel = false;
            v.Parent = this;
            v.Show();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Sobre f = new Sobre();
            f.TopLevel = false;
            f.Parent = this;
            f.SetBevel(false);
            f.Show();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            MainluWeb m = new MainluWeb();
            m.TopLevel = false;
            m.Parent = this;
            m.SetBevel(false);
            m.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Tienda tienda = new Tienda();
            tienda.TopLevel = false;
            tienda.Parent = this;
            tienda.SetBevel(false);
            tienda.Show();
        }

        private void pictureBox8_MouseHover(object sender, EventArgs e)
        {
            name.Text = "MainluWeb";
            name.Size = new Size(128,128);
            name.ForeColor = Color.Black;
            name.BackColor = Color.Transparent;
            this.Controls.Add(name);
            name.Show();
            name.BringToFront();
        }

        private void pictureBox8_MouseMove(object sender, MouseEventArgs e)
        {
            name.Location = new Point(Cursor.Position.X + 10, Cursor.Position.Y + 2);
        }

        private void pictureBox8_MouseLeave(object sender, EventArgs e)
        {
            name.Hide();
        }

        private void pictureBox8_MouseEnter(object sender, EventArgs e)
        {
            name.Text = "MainluWeb";
            name.AutoSize = true;
            name.ForeColor = Color.Black;
            name.BackColor = Color.White;
            this.Controls.Add(name);
            name.Show();
            name.BringToFront();
        }

        private void pictureBox9_MouseMove(object sender, MouseEventArgs e)
        {
            name.Location = new Point(Cursor.Position.X + 10, Cursor.Position.Y + 2);
        }

        private void pictureBox9_MouseEnter(object sender, EventArgs e)
        {
            name.Text = "Tienda";
            name.AutoSize = true;
            name.ForeColor = Color.Black;
            name.BackColor = Color.White;
            this.Controls.Add(name);
            name.Show();
            name.BringToFront();
        }

        private void pictureBox9_MouseLeave(object sender, EventArgs e)
        {
            name.Hide();
        }

        private void Papelera_MouseEnter(object sender, EventArgs e)
        {
            name.Text = "Papelera";
            name.AutoSize = true;
            name.ForeColor = Color.Black;
            name.BackColor = Color.White;
            this.Controls.Add(name);
            name.Show();
            name.BringToFront();
        }

        private void Papelera_MouseLeave(object sender, EventArgs e)
        {
            name.Hide();
        }

        private void Papelera_MouseMove(object sender, MouseEventArgs e)
        {
            name.Location = new Point(Cursor.Position.X + 10, Cursor.Position.Y + 2);
        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            name.Text = "Sobre SolSpace";
            name.AutoSize = true;
            name.ForeColor = Color.Black;
            name.BackColor = Color.White;
            this.Controls.Add(name);
            name.Show();
            name.BringToFront();
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            name.Hide();
        }

        private void pictureBox4_MouseMove(object sender, MouseEventArgs e)
        {
            name.Location = new Point(Cursor.Position.X + 10, Cursor.Position.Y + 2);
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            name.Text = "SolSpace Updates";
            name.AutoSize = true;
            name.ForeColor = Color.Black;
            name.BackColor = Color.White;
            this.Controls.Add(name);
            name.Show();
            name.BringToFront();
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            name.Hide();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            name.Location = new Point(Cursor.Position.X + 10, Cursor.Position.Y + 2);
        }

        private void Act_Click(object sender, EventArgs e)
        {
            MainluWeb m = new MainluWeb();
            m.TopLevel = false;
            m.Parent = this;
            m.SetBevel(false);
            m.Show();
            m.webView21.Source = new Uri("https://sites.google.com/view/alsoftp/solspace_updates");
        }
    }
}
