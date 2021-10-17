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
using TODOAPP_2_.Entities.Concrete;
using TODOAPP_2_.Enums;

namespace TODOAPP_2_
{
    public partial class NewTodo : Form
    {
        private readonly ITodoService _todoservice;
        public NewTodo()
        {
            InitializeComponent();
            _todoservice = new TodoService(new InMemoryTodoDal());
        }

        private void NewTodo_Load(object sender, EventArgs e)
        {
            cmbStatus.DataSource = Enum.GetValues(typeof(Status));
            cmbImLevel.DataSource = Enum.GetValues(typeof(ImportanceLevel));
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var result = _todoservice.Add(new TodoEntity
            {
                Id = Guid.NewGuid(),
                Title = textBoxTitle.Text,
                Shortdescription = textBoxShortDes.Text,
                Description = textBoxDes.Text,
                ImportanceLevel = cmbImLevel.SelectedIndex,
                Status = (Status)cmbStatus.SelectedItem,
                CreateDate = DateTime.Now

            }) ;
            if (result > 0)
            {
                MessageBox.Show(GlobalConustants.AddSucces, GlobalConustants.CaptionInfo, MessageBoxButtons.OK, MessageBoxIcon.Information);

                DialogResult dialogResult = MessageBox.Show(
                    GlobalConustants.AddAgain,
                    GlobalConustants.CaptQuestion,
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question

                    );

                if (dialogResult == DialogResult.Yes)
                {
                    ClearTextBox();
                }
                else
                {
                    Form getAllForms = Application.OpenForms["GetAllForm"];
                    if (getAllForms == null)
                    {
                        getAllForms = new GetAllForm();
                        getAllForms.MdiParent = Application.OpenForms["TodoAppForm"];
                        getAllForms.StartPosition = FormStartPosition.CenterScreen;
                        getAllForms.Show();
                        GroupBox groupBoxList = (GroupBox)getAllForms.Controls["grpBoxList"];
                        DataGridView dataGridView = (DataGridView)groupBoxList.Controls["dataGridView"];
                        dataGridView.DataSource = null;
                        dataGridView.DataSource = _todoservice.GettAll();
                        this.Close();

                    }
                    else
                    {
                        GroupBox groupBoxList = (GroupBox)getAllForms.Controls["grpBoxList"];
                        DataGridView dataGridView = (DataGridView)groupBoxList.Controls["dataGridView"];
                        dataGridView.DataSource = null;
                        dataGridView.DataSource = _todoservice.GettAll();
                        this.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show(GlobalConustants.AddError, GlobalConustants.CaptionInfo, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ClearTextBox()
        {
            foreach(var item in this.Controls)
            {
                if(item is TextBox textBox)
                {
                    textBox.Text = string.Empty;
                }
            }
        }
    }
}
