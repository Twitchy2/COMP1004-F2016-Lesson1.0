using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NEW_BUTTON_TRY_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonPress_Click(object sender, EventArgs e)
        {
            wordLabel.Text = "It took me around 4 hours\n to download this.\n Yet it took 2 minutes to code this.";
        }

        private void buttonPress_MouseHover(object sender, EventArgs e)
        {
            buttonPress.Text = "It hurts to live.";
        }
    }
}
