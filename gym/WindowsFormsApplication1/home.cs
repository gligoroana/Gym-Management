using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace WindowsFormsApplication1
{
    public partial class home : UserControl
    {
        public home()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.facebook.com/");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.instagram.com/");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("https://twitter.com/");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.google.com/");
        }
    }
}
