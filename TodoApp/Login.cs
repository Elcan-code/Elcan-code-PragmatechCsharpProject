using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TODOAPP_2_.Business.Abstract;
using TODOAPP_2_.Business.Concrete;
using TODOAPP_2_.Conustants;
using TODOAPP_2_.DataAccess.Concrete;

namespace TODOAPP_2_
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            textBox.BackColor = Color.LightGray;
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            textBox.BackColor = Color.DarkGray;
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            textBox.BackColor = Color.DarkGray;
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            textBox.BackColor = Color.LightGray;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxUserName.Text) && !string.IsNullOrEmpty(textBoxPassword.Text)) 
            {
                IUserService userservice = new UserService(new InMemoryUserDal());
                var user = userservice.GetUser(textBoxUserName.Text,textBoxPassword.Text);
                if (user != null)
                {
                    Form todoListForm = Application.OpenForms["todoAppForm"];
                    Panel leftpanel = (Panel)todoListForm.Controls["leftSidePanel"];
                    GroupBox grpBox = (GroupBox)leftpanel.Controls["grpBoxOperation"];
                    foreach(Control control in grpBox.Controls)
                    {
                        if(control is Button)
                        {
                            control.Enabled = true;
                        }
                    }
                    this.Close();
                }
                else
                {
                    MessageBox.Show(GlobalConustants.InvalidAttempt, GlobalConustants.CaptionInfo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show(GlobalConustants.Required, GlobalConustants.CaptionInfo,MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
    }
}
