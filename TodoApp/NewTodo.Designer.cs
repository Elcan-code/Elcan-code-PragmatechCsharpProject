
namespace TODOAPP_2_
{
    partial class NewTodo
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.textBoxShortDes = new System.Windows.Forms.TextBox();
            this.lblShortDes = new System.Windows.Forms.Label();
            this.textBoxDes = new System.Windows.Forms.TextBox();
            this.lblDes = new System.Windows.Forms.Label();
            this.lblImpLevel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.cmbImLevel = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(59, 47);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(35, 17);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Title";
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(62, 74);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(320, 22);
            this.textBoxTitle.TabIndex = 2;
            // 
            // textBoxShortDes
            // 
            this.textBoxShortDes.Location = new System.Drawing.Point(62, 145);
            this.textBoxShortDes.Multiline = true;
            this.textBoxShortDes.Name = "textBoxShortDes";
            this.textBoxShortDes.Size = new System.Drawing.Size(320, 86);
            this.textBoxShortDes.TabIndex = 4;
            // 
            // lblShortDes
            // 
            this.lblShortDes.AutoSize = true;
            this.lblShortDes.Location = new System.Drawing.Point(59, 118);
            this.lblShortDes.Name = "lblShortDes";
            this.lblShortDes.Size = new System.Drawing.Size(117, 17);
            this.lblShortDes.TabIndex = 3;
            this.lblShortDes.Text = "Short Description";
            // 
            // textBoxDes
            // 
            this.textBoxDes.Location = new System.Drawing.Point(62, 272);
            this.textBoxDes.Multiline = true;
            this.textBoxDes.Name = "textBoxDes";
            this.textBoxDes.Size = new System.Drawing.Size(320, 139);
            this.textBoxDes.TabIndex = 6;
            // 
            // lblDes
            // 
            this.lblDes.AutoSize = true;
            this.lblDes.Location = new System.Drawing.Point(59, 252);
            this.lblDes.Name = "lblDes";
            this.lblDes.Size = new System.Drawing.Size(79, 17);
            this.lblDes.TabIndex = 5;
            this.lblDes.Text = "Description";
            // 
            // lblImpLevel
            // 
            this.lblImpLevel.AutoSize = true;
            this.lblImpLevel.Location = new System.Drawing.Point(59, 427);
            this.lblImpLevel.Name = "lblImpLevel";
            this.lblImpLevel.Size = new System.Drawing.Size(116, 17);
            this.lblImpLevel.TabIndex = 7;
            this.lblImpLevel.Text = "Importance Level";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 497);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Status";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(202, 565);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(180, 36);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(62, 518);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(320, 24);
            this.cmbStatus.TabIndex = 12;
            // 
            // cmbImLevel
            // 
            this.cmbImLevel.FormattingEnabled = true;
            this.cmbImLevel.Location = new System.Drawing.Point(62, 447);
            this.cmbImLevel.Name = "cmbImLevel";
            this.cmbImLevel.Size = new System.Drawing.Size(320, 24);
            this.cmbImLevel.TabIndex = 13;
            // 
            // NewTodo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 646);
            this.Controls.Add(this.cmbImLevel);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblImpLevel);
            this.Controls.Add(this.textBoxDes);
            this.Controls.Add(this.lblDes);
            this.Controls.Add(this.textBoxShortDes);
            this.Controls.Add(this.lblShortDes);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "NewTodo";
            this.Text = "NewTodo";
            this.Load += new System.EventHandler(this.NewTodo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.TextBox textBoxShortDes;
        private System.Windows.Forms.Label lblShortDes;
        private System.Windows.Forms.TextBox textBoxDes;
        private System.Windows.Forms.Label lblDes;
        private System.Windows.Forms.Label lblImpLevel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.ComboBox cmbImLevel;
    }
}