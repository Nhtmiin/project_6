using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tìm_bội_chung_nhỏ_nhất
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int UCLN(int a, int b)
        {
   
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(textBox1.Text.Trim());
                int b = int.Parse(textBox2.Text.Trim());

                int ucln = UCLN(a, b);
                int bcnn = Math.Abs(a * b) / ucln;

                textBox3.Text = bcnn.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng nhập số nguyên hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
