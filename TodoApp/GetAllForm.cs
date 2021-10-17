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
using TODOAPP_2_.DataAccess.Concrete;
using TODOAPP_2_.Enums;

namespace TODOAPP_2_
{
    public partial class GetAllForm : Form
    {
        private readonly ITodoService _todoservice;

        
        public GetAllForm()
        {
            InitializeComponent();
            _todoservice = new TodoService(new InMemoryTodoDal());
        }

        private void GetAllForm_Load(object sender, EventArgs e)
        {
            dataGridView.DataSource = _todoservice.GettAll();
            dataGridView.Columns["Id"].Visible = false;
        }

        private void btnGetAll_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = _todoservice.GettAll();
            dataGridView.Columns["Id"].Visible = false;
        }

        private void btnPending_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = _todoservice.GettAll(Status.Pending);
            dataGridView.Columns["Id"].Visible = false;
        }

        private void btnCanceled_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = _todoservice.GettAll(Status.Canceled);
            dataGridView.Columns["Id"].Visible = false;
        }

        private void btnSuspend_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = _todoservice.GettAll(Status.Suspend);
            dataGridView.Columns["Id"].Visible = false;
        }
    }
}
