using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuturePlayGroundTest
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 open = new Form1();
            open.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }
    }
}
