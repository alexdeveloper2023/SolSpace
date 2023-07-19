using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SolSpaceOS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            progressBar1.Increment(15);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value = 100;
            Act escri = new Act();
            if (progressBar1.Value == 100) {
                escri.ShowDialog();
                this.Close();
            }
        }
    }
}
