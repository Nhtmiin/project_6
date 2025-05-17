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

                if (n < 0)
                {
                    textBox2.Text = n + " không phải là số đối xứng (số âm không tính).";
                    return;
                }

                string str = n.ToString();
                string dao = new string(str.Reverse().ToArray());

                if (str == dao)
                    textBox2.Text = n + " là số đối xứng.";
                else
                    textBox2.Text = n + " không phải là số đối xứng.";
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng nhập số nguyên hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
