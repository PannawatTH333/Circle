using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Circle
{
    public partial class Form1 : Form
    {
     

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Hello, User", "First Message");
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("ต้องการปิดจริงหรือไม่", "แน่ใจนะ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCircleArea_Click(object sender, EventArgs e)
        {
            double Radius = 0;
            if (double.TryParse(txtRadius.Text, out Radius) == false)
            {
                MessageBox.Show("ข้อมูลไม่ถูกต้อง", " Error!!!");
                txtRadius.Focus();
                txtRadius.SelectAll();
                return;
            }

            //process คำนวณ
            double CircleArea = Math.PI*Math.Pow(Radius, 2);

            //output นำไปแสดงผลที่ lblResult
            lblResult.Text = CircleArea.ToString("0.00");

            txtRadius.Focus();
            txtRadius.SelectAll();

            
        }

        private void btnTriangleArea_Click(object sender, EventArgs e)
        {
            double Width = 0;
            if (double.TryParse(txtWidth.Text, out Width) == false)
            {
                MessageBox.Show("ข้อมูลไม่ถูกต้อง", " Error!!!");
                txtRadius.Focus();
                txtRadius.SelectAll();
                return;
            }

            double w = 0, h = 0, sum = 0;
            //แปลงค่า ข้อความเป็นตัวเลข
            w = Convert.ToInt32(txtWidth.Text);
            h = Convert.ToInt32(txtHeight.Text);
            sum = 0.5 * w * h;
            // นำไปแสดงผลที่ lblResult
            lblResult.Text = sum.ToString();

            txtRadius.Focus();
            txtRadius.SelectAll();
        }

        private void btnHexagonArea_Click(object sender, EventArgs e)
        {
            double HexahonWidth = 0;
            if (double.TryParse(txtHexahonWidth.Text, out HexahonWidth) == false)
            {
                MessageBox.Show("ข้อมูลไม่ถูกต้อง", " Error!!!");
                txtRadius.Focus();
                txtRadius.SelectAll();
                return;
            }

            // คำนวณ รากที่3หารด้วย4 * ด้าน กำลัง2 * 6
            double HexagonArea = Math.Sqrt(3)/4 * Math.Pow(HexahonWidth, 2) * 6;

            //นำไปแสดงผลที่ lblResult
            lblResult.Text = HexagonArea.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtRadius.Clear();
            txtHeight.Clear();
            txtWidth.Clear();
            txtHexahonWidth.Clear();
            lblResult.Text = "";
        }
    }
}
