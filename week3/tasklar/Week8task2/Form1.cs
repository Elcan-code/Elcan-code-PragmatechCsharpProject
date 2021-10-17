using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week8task2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

    

     

        private void Form1_Load(object sender, EventArgs e)
        {

            foreach (var item in Bookdb.BookList())
            {
                kitabComboBox.Items.Add(item.Kitabad);
            }
        }

        private void kitabComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var item in Bookdb.BookList())
            {
                if (item.Kitabad == kitabComboBox.SelectedItem)
                {
                    adLabel.Text = item.Kitabad;
                    yazıçıLabel.Text = item.Yazıçı;
                    kataqoriyaLabel.Text = item.Kataqoriya;
                    stokLabel.Text = item.Stok.ToString();
                    haqqındaRichBox.Text = item.Haqqında;
                    pictureBox1.ImageLocation = item.Şəkil;
                }
            }
        }
    }
}
