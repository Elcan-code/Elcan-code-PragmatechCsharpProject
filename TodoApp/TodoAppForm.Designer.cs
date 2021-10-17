
namespace TODOAPP_2_
{
    partial class todoAppForm
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
            this.components = new System.ComponentModel.Container();
            this.leftSidePanel = new System.Windows.Forms.Panel();
            this.grpBoxOperation = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnGetAll = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.downpanel = new System.Windows.Forms.Panel();
            this.lblDate = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.leftSidePanel.SuspendLayout();
            this.grpBoxOperation.SuspendLayout();
            this.downpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // leftSidePanel
            // 
            this.leftSidePanel.Controls.Add(this.grpBoxOperation);
            this.leftSidePanel.Controls.Add(this.pictureBox1);
            this.leftSidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftSidePanel.Location = new System.Drawing.Point(0, 0);
            this.leftSidePanel.Name = "leftSidePanel";
            this.leftSidePanel.Size = new System.Drawing.Size(232, 816);
            this.leftSidePanel.TabIndex = 0;
            // 
            // grpBoxOperation
            // 
            this.grpBoxOperation.Controls.Add(this.btnExit);
            this.grpBoxOperation.Controls.Add(this.btnGetAll);
            this.grpBoxOperation.Controls.Add(this.btnNew);
            this.grpBoxOperation.Dock = System.Windows.Forms.DockStyle.Left;
            this.grpBoxOperation.Location = new System.Drawing.Point(0, 196);
            this.grpBoxOperation.Name = "grpBoxOperation";
            this.grpBoxOperation.Size = new System.Drawing.Size(232, 620);
            this.grpBoxOperation.TabIndex = 1;
            this.grpBoxOperation.TabStop = false;
            this.grpBoxOperation.Text = "Operation";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(4, 118);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(222, 42);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnGetAll
            // 
            this.btnGetAll.Location = new System.Drawing.Point(3, 70);
            this.btnGetAll.Name = "btnGetAll";
            this.btnGetAll.Size = new System.Drawing.Size(222, 42);
            this.btnGetAll.TabIndex = 1;
            this.btnGetAll.Text = "Get All";
            this.btnGetAll.UseVisualStyleBackColor = true;
            this.btnGetAll.Click += new System.EventHandler(this.btnGetAll_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(4, 22);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(222, 42);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // downpanel
            // 
            this.downpanel.Controls.Add(this.lblDate);
            this.downpanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.downpanel.Location = new System.Drawing.Point(232, 757);
            this.downpanel.Name = "downpanel";
            this.downpanel.Size = new System.Drawing.Size(1062, 59);
            this.downpanel.TabIndex = 1;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(770, 22);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(72, 18);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "00:00:00";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::TODOAPP_2_.Properties.Resources.to_do_list__1_;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(232, 196);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // todoAppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1294, 816);
            this.Controls.Add(this.downpanel);
            this.Controls.Add(this.leftSidePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.Name = "todoAppForm";
            this.Text = "TodoApp";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.leftSidePanel.ResumeLayout(false);
            this.grpBoxOperation.ResumeLayout(false);
            this.downpanel.ResumeLayout(false);
            this.downpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel leftSidePanel;
        private System.Windows.Forms.GroupBox grpBoxOperation;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel downpanel;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnGetAll;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Timer timer1;
    }
}

