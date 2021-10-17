using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tesdiqleButton_Click(object sender, EventArgs e)
        {
            Istifadeci.Items.Add("Ad: " + adTextBox.Text);
            Istifadeci.Items.Add("Soyad: " + soyadTextBox.Text);
            Istifadeci.Items.Add("Nomre: " + nomreTextBox.Text);
            Istifadeci.Items.Add("Adres: " + adressRichTextBox.Text);
            adTextBox.Text = "";
            soyadTextBox.Text = "";
            nomreTextBox.Text = "";
            adressRichTextBox.Text = "";

            Sifaris.Enabled = true;
        }
        int qiymet = 0;
        private void hesablaButton_Click(object sender, EventArgs e)
        {
            if (olcuComboBox.SelectedItem == "Kicik")
            {
                qiymet = 15;
            }
            if (olcuComboBox.SelectedItem == "Orta")
            {
                qiymet = 20;
            }
            if (olcuComboBox.SelectedItem == "Boyuk")
            {
                qiymet = 25;
            }
            qiymet *= Convert.ToInt32(pizzaSayTextBox.Text);
            qiymetTextBox.Text = qiymet.ToString();
        }

        private void alButton_Click(object sender, EventArgs e)
        {
            Sifarisler.Items.Add("Olcusu : " + olcuComboBox.SelectedItem);
            Sifarisler.Items.Add("Sayi : " + pizzaSayTextBox.Text);
            Sifarisler.Items.Add("Icki : " + ickiComboBox.SelectedItem);
            Sifarisler.Items.Add("Sayi : " + sayTextBox.Text);
            Sifarisler.Items.Add("Yekun qiymet : " + qiymetTextBox.Text);
        }

        private void temizleButton_Click(object sender, EventArgs e)
        {
            Istifadeci.Items.Clear();
            Sifarisler.Items.Clear();
        }
    }
}
