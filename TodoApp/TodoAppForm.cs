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
    public partial class todoAppForm : Form
    {
        private ITodoService _todoService;
        private Form _form;

        public todoAppForm()
        {
            InitializeComponent();
            _todoService = new TodoService(new InMemoryTodoDal());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           

            timer1.Start();
            timer1.Interval = 100;

        Login lg = new Login();
            lg.MdiParent = this;
                lg.Show();
            lg.StartPosition = FormStartPosition.CenterScreen;
            grpBoxOperationends(false);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("T");
        }

        private void btnExit_Click(object sender, EventArgs e) 
        {
            Application.Exit();
        }

      private void grpBoxOperationends(bool control)
        {
            foreach(var item in grpBoxOperation.Controls)
            {
                if (item is Button operationButton)
                {
                    operationButton.Enabled = control;
                }
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["NewTodo"] != null)
            {
                _form.MdiParent = Application.OpenForms["TodoAppForm"];
                _form.Focus();


                
            }
            else
            {
                _form = new NewTodo();
                _form.MdiParent = Application.OpenForms["TodoAppForm"];
                _form.StartPosition = FormStartPosition.CenterParent;
                _form.Show();
            }

           
        }

        private void btnGetAll_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["GetAllForm"] != null)
            {
                _form = Application.OpenForms["GetAllForm"];
                _form.Focus();
            }
            else
            {
                if (_todoService.Count() > 0)
                {
                    GetAllForm form = new GetAllForm();

                    form.MdiParent = Application.OpenForms["TodoAppForm"];
                    form.StartPosition = FormStartPosition.CenterParent;
                    form.Show();
              

                }
                else
                {
                    MessageBox.Show(GlobalConustants.EmptyList, GlobalConustants.CaptionInfo, MessageBoxButtons.OK, MessageBoxIcon.Information);



                }
            }
        }
    }
}
