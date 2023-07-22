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
    public partial class shutdown : Form
    {
        public shutdown()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Start();
            progressBar1.Increment(20);
            if (progressBar1.Value == 100)
            {
                timer1.Stop();
                Application.Exit();
            }
        }
    }
}
