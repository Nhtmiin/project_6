using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kiểm_tra_số_chính_phương
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
                // Giả sử textBox1 nhập hệ số a, textBox2 nhập hệ số b
                double a = double.Parse(textBox1.Text.Trim());
                double b = double.Parse(textBox2.Text.Trim());

                string result;

                if (a == 0)
                {
                    if (b == 0)
                        result = "Phương trình có vô số nghiệm.";
                    else
                        result = "Phương trình vô nghiệm.";
                }
                else
                {
                    double x = -b / a;
                    result = "Nghiệm của phương trình là x = " + x.ToString("F2");
                }

                textBox3.Text = result; // Kết quả hiển thị ở textBox3
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
