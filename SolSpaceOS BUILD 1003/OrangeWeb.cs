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
    public partial class OrangeWeb : Form
    {
        public OrangeWeb()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PictureBox papelera = new PictureBox();
            Escritorio escri = new Escritorio();
            papelera.Image = escri.PapeleraIco.Image;
        }

        private void OrangeWeb_Load(object sender, EventArgs e)
        {
            
        }
    }
}
