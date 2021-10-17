using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week8task3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double sum = 0, discount = 0;
        private void addButton_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Mehsulun adi " + mehsulTextBox.Text);
            listBox1.Items.Add("Mehsulun qiymeti " + qiymetTextBox.Text);
            sum += Convert.ToDouble(qiymetTextBox.Text);
            qiymetTextBox.Text = "";
            mehsulTextBox.Text = "";
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            qiymetTextBox.Text = "";
            mehsulTextBox.Text = "";
            textBox1.Text = "";
            sum = 0;
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            if (pensiyaCheckBox.Checked == true) { discount = 10; }
            if (tələbəCheckBox.Checked == true) { discount = 8; }
            double edv = 0;
            edv = sum * 18 / 100;
            sum += edv;
            discount = sum * discount / 100;
            sum -= discount;

            textBox1.Text = sum.ToString();
        }
    }
}
