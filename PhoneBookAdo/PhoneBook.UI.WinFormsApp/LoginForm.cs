using System;
using System.Drawing;
using System.Windows.Forms;
using PhoneBook.Business.Constants;
using PhoneBook.Business.Enums;
using PhoneBook.Business.Services;
using PhoneBook.Core.Repository;
using PhoneBook.Entities;

namespace PhoneBook.UI.WinFormsApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBoxUsername.Text) && !string.IsNullOrEmpty(txtBoxPassword.Text))
            {

                IUserService userService = new UserService(new UserRepository());

                var user = new User()
                {
                    Username = txtBoxUsername.Text,
                    Password = txtBoxPassword.Text
                };
                var result = userService.Login(user);

                if (result > 0)
                {
                    this.Hide();
                    PhoneBookForm form = new PhoneBookForm();
                    form.ShowDialog();
                    this.Close();
                    
                }
                else { MessageBox.Show(GlobalConstants.Required, GlobalConstants.CaptionInfo, MessageBoxButtons.OK, MessageBoxIcon.Information); }

          

            }
            else
            {
                MessageBox.Show(GlobalConstants.Required, GlobalConstants.CaptionInfo, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
         
        }

        private void txtBoxUsername_MouseDown(object sender, MouseEventArgs e)
        {
            txtBoxUsername.BackColor = Color.DarkSlateGray;
            txtBoxUsername.ForeColor = Color.White;
            txtBoxPassword.BackColor = Color.White;
            txtBoxPassword.ForeColor = Color.Black;
        }

        private void txtBoxPassword_MouseDown(object sender, MouseEventArgs e)
        {
            txtBoxPassword.BackColor = Color.DarkSlateGray;
            txtBoxPassword.ForeColor = Color.White;
            txtBoxUsername.ForeColor = Color.Black;
            txtBoxUsername.BackColor = Color.White;

        }

        private void checkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkShowPassword.Checked == false)
            {
                txtBoxPassword.PasswordChar = '*';
            }
            else
            {
                txtBoxPassword.PasswordChar=char.MinValue;
            }
        }
    }
}