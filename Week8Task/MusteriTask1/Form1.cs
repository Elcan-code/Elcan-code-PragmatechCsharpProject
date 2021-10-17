using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusteriTask1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int count = 0;
        List<Musteri> musteri = new List<Musteri>();
        private void button1_Click(object sender, EventArgs e)
        {

            DialogResult dr = MessageBox.Show("Melumatlar yadda saxlansin", "Bildiris", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {




                musteri.Add(new Musteri()
                {

                    Id = count + 1,
                    Ad = adTextbox.Text,
                    Soyad = soyadTextBox.Text,
                    Nomre = Convert.ToInt32(nomreTextBox.Text),
                    Mail = mailTextBox.Text

                }); ;
                count = musteri.Count();
                MessageBox.Show("Bazada olan musteri sayi : " + count.ToString());

                Clear();
            }
            else if (dr == DialogResult.No)
            {

                foreach (var item in musteri)
                {
                    musteriList.Items.Add(item.Ad + " " + item.Soyad); ;
                }

                Clear();
            }
        }
        public void Clear()
        {
            adTextbox.Text = "";
            nomreTextBox.Text = "";
            soyadTextBox.Text = "";
            mailTextBox.Text = "";

        }


    }
}
