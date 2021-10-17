using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HovuzTask4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hesableButton_Click(object sender, EventArgs e)
        {

            hecmTextBox.Text = Hecm(Convert.ToInt32(uzunluqTextBox.Text), Convert.ToInt32(enTextBox.Text), Convert.ToInt32(derinlikTextBox.Text)).ToString();
            dolmavaxtiGroupBox.Enabled = true;
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            double sum = Convert.ToDouble(kran1TextBox.Text) + Convert.ToInt32(kran2TextBox.Text);
            double hecm = Convert.ToDouble(hecmTextBox.Text);
            double dolmavaxti = hecm / sum;
            dolmavaxtiTextBox.Text = dolmavaxti.ToString();
        }

        public int Hecm(int hundurluk, int en, int uzunluq)
        {
            return hundurluk * uzunluq * en;
        }
    }
}
