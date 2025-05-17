using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chiaab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double so1 = Convert.ToDouble(textBox1.Text);
                double so2 = Convert.ToDouble(textBox2.Text);
                double ketQua ;
                if(so1 > so2)
                {
                    ketQua = so1;
                }
                else
                {
                    ketQua = so2;
                }
                
                textBox3.Text = ketQua.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng số!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
