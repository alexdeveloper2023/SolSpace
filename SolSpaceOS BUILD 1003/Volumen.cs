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
using System.Windows.Media;

namespace SolSpaceOS
{
    public partial class Volumen : Form
    {
        MediaPlayer player = new MediaPlayer();
        public Volumen()
        {
            InitializeComponent();
        }
        private void trackBar1_Scroll_1(object sender, EventArgs e)
        {
            player.Volume = trackBar1.Value;
        }
    }
}
