using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Chia;
using cộng;
using Trừ;

namespace Menu_1._2

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cong f = new cong();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Tru f = new Tru();
            f.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            chia f = new chia();
            f.Show();
        }
    }
}
