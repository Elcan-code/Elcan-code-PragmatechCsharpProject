
namespace TODOAPP_2_
{
    partial class GetAllForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.grpOperation = new System.Windows.Forms.GroupBox();
            this.grpBoxList = new System.Windows.Forms.GroupBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.btnGetAll = new System.Windows.Forms.Button();
            this.btnPending = new System.Windows.Forms.Button();
            this.btnCanceled = new System.Windows.Forms.Button();
            this.btnSuspend = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.grpOperation.SuspendLayout();
            this.grpBoxList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grpOperation);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(218, 584);
            this.panel1.TabIndex = 0;
            // 
            // grpOperation
            // 
            this.grpOperation.Controls.Add(this.btnSuspend);
            this.grpOperation.Controls.Add(this.btnCanceled);
            this.grpOperation.Controls.Add(this.btnPending);
            this.grpOperation.Controls.Add(this.btnGetAll);
            this.grpOperation.Dock = System.Windows.Forms.DockStyle.Left;
            this.grpOperation.Location = new System.Drawing.Point(0, 0);
            this.grpOperation.Name = "grpOperation";
            this.grpOperation.Size = new System.Drawing.Size(215, 584);
            this.grpOperation.TabIndex = 0;
            this.grpOperation.TabStop = false;
            this.grpOperation.Text = "Operation";
            // 
            // grpBoxList
            // 
            this.grpBoxList.Controls.Add(this.dataGridView);
            this.grpBoxList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBoxList.Location = new System.Drawing.Point(218, 0);
            this.grpBoxList.Name = "grpBoxList";
            this.grpBoxList.Size = new System.Drawing.Size(649, 584);
            this.grpBoxList.TabIndex = 1;
            this.grpBoxList.TabStop = false;
            this.grpBoxList.Text = "List";
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(3, 18);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(643, 563);
            this.dataGridView.TabIndex = 0;
            // 
            // btnGetAll
            // 
            this.btnGetAll.Location = new System.Drawing.Point(6, 34);
            this.btnGetAll.Name = "btnGetAll";
            this.btnGetAll.Size = new System.Drawing.Size(200, 44);
            this.btnGetAll.TabIndex = 0;
            this.btnGetAll.Text = "Get All";
            this.btnGetAll.UseVisualStyleBackColor = true;
            this.btnGetAll.Click += new System.EventHandler(this.btnGetAll_Click);
            // 
            // btnPending
            // 
            this.btnPending.Location = new System.Drawing.Point(6, 84);
            this.btnPending.Name = "btnPending";
            this.btnPending.Size = new System.Drawing.Size(200, 44);
            this.btnPending.TabIndex = 1;
            this.btnPending.TabStop = false;
            this.btnPending.Text = "Pending";
            this.btnPending.UseVisualStyleBackColor = true;
            this.btnPending.Click += new System.EventHandler(this.btnPending_Click);
            // 
            // btnCanceled
            // 
            this.btnCanceled.Location = new System.Drawing.Point(6, 134);
            this.btnCanceled.Name = "btnCanceled";
            this.btnCanceled.Size = new System.Drawing.Size(200, 44);
            this.btnCanceled.TabIndex = 2;
            this.btnCanceled.Text = "Canceled";
            this.btnCanceled.UseVisualStyleBackColor = true;
            this.btnCanceled.Click += new System.EventHandler(this.btnCanceled_Click);
            // 
            // btnSuspend
            // 
            this.btnSuspend.Location = new System.Drawing.Point(6, 184);
            this.btnSuspend.Name = "btnSuspend";
            this.btnSuspend.Size = new System.Drawing.Size(200, 44);
            this.btnSuspend.TabIndex = 3;
            this.btnSuspend.Text = "Suspend";
            this.btnSuspend.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSuspend.UseVisualStyleBackColor = true;
            this.btnSuspend.Click += new System.EventHandler(this.btnSuspend_Click);
            // 
            // GetAllForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 584);
            this.Controls.Add(this.grpBoxList);
            this.Controls.Add(this.panel1);
            this.Name = "GetAllForm";
            this.Text = "GetAllForm";
            this.Load += new System.EventHandler(this.GetAllForm_Load);
            this.panel1.ResumeLayout(false);
            this.grpOperation.ResumeLayout(false);
            this.grpBoxList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grpOperation;
        private System.Windows.Forms.GroupBox grpBoxList;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btnSuspend;
        private System.Windows.Forms.Button btnCanceled;
        private System.Windows.Forms.Button btnPending;
        private System.Windows.Forms.Button btnGetAll;
    }
}