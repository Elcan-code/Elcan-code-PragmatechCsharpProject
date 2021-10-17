using PhoneBook.Business.Constants;
using PhoneBook.Business.Enums;
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
    public partial class PhoneBookForm : Form
    {
        private readonly IContactService contactService;
        public PhoneBookForm()
        {

            InitializeComponent();
            contactService = new ContactService(new ContactRepository());
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            this.Close();
            CreateContacts contacts = new CreateContacts();
            this.Hide();
            contacts.ShowDialog();
           
            
           
        }

        private void PhoneBookForm_Load(object sender, EventArgs e)
        {
            FillListBox();
        }

       public void FillListBox()
        {
            listBox1.DataSource = null;
            var entities = contactService.GetAll();
            if (entities != null)
            {
                listBox1.DataSource = contactService.GetAll();
            }
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListBox listBox = (ListBox)sender;
            var selectedItem = (Contact)listBox.SelectedItem;
            textBoxName.Text = selectedItem.Name;
            textBoxSurname.Text = selectedItem.Surname;
            textBoxEmail.Text = selectedItem.Email;
            textBoxWebsite.Text = selectedItem.Website;
            textBoxAddress.Text = selectedItem.Address;
            richTextBoxDescription.Text = selectedItem.Description;
            textBoxNumber1.Text = selectedItem.Number1;
            textBoxNumber2.Text = selectedItem.Number2;
            textBoxNumber3.Text = selectedItem.Number3;
           grpbxContactDetails.Text = "Update Contact";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var selectItem = (Contact)listBox1.SelectedItem;
            if(selectItem != null)
            {
                var entity = new Contact()
                {
                    Id = selectItem.Id,
                    Name = textBoxName.Text,
                    Surname = textBoxSurname.Text,
                    Website = textBoxWebsite.Text,
                    Email =textBoxEmail.Text,
                    Number1 = textBoxNumber1.Text,
                    Number2 = textBoxNumber2.Text,
                    Number3 = textBoxNumber3.Text,
                    Address = textBoxAddress.Text,
                    Description = richTextBoxDescription.Text

                };
                var result = contactService.Update(entity);


                if (result > 0)
                {
                    FillListBox();
                    MessageBox.Show(GlobalConstants.UpdateSuccess, GlobalConstants.UpdateSuccess, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
               
                        MessageBox.Show(GlobalConstants.ModelStateNotValid, GlobalConstants.CaptionInfo, MessageBoxButtons.OK, MessageBoxIcon.Information);

                }



            }
            }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var selectItem = (Contact)listBox1.SelectedItem;
            if (selectItem != null)
            {
                var result = contactService.Delete(selectItem.Id);

                if (result>0)
                {
                    FillListBox();
                    MessageBox.Show(GlobalConstants.DeleteSuccess, GlobalConstants.DeleteSuccess, MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            else
                {
                    MessageBox.Show(GlobalConstants.ModelStateNotValid, GlobalConstants.CaptionInfo, MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }


        }

        private void btnXmlOutput_Click(object sender, EventArgs e)
        {
            var result = contactService.ExportXml(textBox1.Text);

            if (result > 0)
            {
                MessageBox.Show(GlobalConstants.Success, GlobalConstants.Success, MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            else
            {
                MessageBox.Show(GlobalConstants.Fail, GlobalConstants.CaptionInfo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
                   
            }

        private void btnJsonOutput_Click(object sender, EventArgs e)
        {
            var result = contactService.ExportJson(textBox1.Text);

            if (result > 0)
            {
                MessageBox.Show(GlobalConstants.Success, GlobalConstants.Success, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show(GlobalConstants.Fail, GlobalConstants.CaptionInfo, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnCsvOutput_Click(object sender, EventArgs e)
        {
            var result = contactService.ExportCsv(textBox1.Text);

            if (result > 0)
            {
                MessageBox.Show(GlobalConstants.Success, GlobalConstants.Success, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show(GlobalConstants.Fail, GlobalConstants.CaptionInfo, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnJsonInput_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.ShowDialog();
            string path = openFileDialog1.FileName;

            int result=contactService.ImportJson(path);
           
                if (result > 0)
                {
                    MessageBox.Show(GlobalConstants.Success, GlobalConstants.Success, MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show(GlobalConstants.Fail, GlobalConstants.CaptionInfo, MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
        }
    }
    }
    

