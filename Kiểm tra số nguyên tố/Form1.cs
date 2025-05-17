using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kiểm_tra_số_nguyên_tố
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
                int n = int.Parse(textBox1.Text.Trim());

                if (n <= 1)
                {
                    textBox2.Text = n + " không phải là số nguyên tố.";
                    return;
                }

                bool laNguyenTo = true;

                for (int i = 2; i <= Math.Sqrt(n); i++)
                {
                    if (n % i == 0)
                    {
                        laNguyenTo = false;
                        break;
                    }
                }

                if (laNguyenTo)
                    textBox2.Text = n + " là số nguyên tố.";
                else
                    textBox2.Text = n + " không phải là số nguyên tố.";
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng nhập số nguyên hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
