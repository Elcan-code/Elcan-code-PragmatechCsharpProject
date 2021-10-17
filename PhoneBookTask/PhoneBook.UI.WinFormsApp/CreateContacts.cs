using PhoneBook.Business.Constants;
using PhoneBook.Business.Services;
using PhoneBook.Core.Repository;
using PhoneBook.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneBook.UI.WinFormsApp
{
    public partial class CreateContacts : Form
    {
        public CreateContacts()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxName.Text) && !string.IsNullOrEmpty(textBoxSurname.Text)&& !string.IsNullOrEmpty(textBoxNumber1.Text))
            {

                IContactService contactService = new ContactService(new ContactRepository());

                var contact = new Contact()
                {
                    Name = textBoxName.Text,
                    Surname = textBoxSurname.Text,
                    Number1 = textBoxNumber1.Text,
                    Number2 = textBoxNumber2.Text,
                    Number3 = textBoxNumber3.Text,
                    Email = textBoxEmail.Text,
                    Address = textBoxAddress.Text,
                    Website=textBoxWebSite.Text,
                    Description=richTextBoxDescription.Text,


                };
                var result = contactService.Add(contact);

                if (result > 0)
                {
                    this.Close();
                    MessageBox.Show("Ugurlu Emeliyyat");
                    PhoneBookForm phf = new PhoneBookForm();
                    phf.FillListBox();
                    this.Hide();
                    phf.ShowDialog();
                  
                }
                else { MessageBox.Show(GlobalConstants.Required, GlobalConstants.CaptionInfo, MessageBoxButtons.OK, MessageBoxIcon.Information); }

               
            }
            else
            {
                MessageBox.Show(GlobalConstants.Required, GlobalConstants.CaptionInfo, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}

