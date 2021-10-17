
namespace PhoneBook.UI.WinFormsApp
{
    partial class PhoneBookForm
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
            this.grpbxContact = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.grpbxContactDetails = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBoxDescription = new System.Windows.Forms.RichTextBox();
            this.textBoxNumber3 = new System.Windows.Forms.TextBox();
            this.textBoxWebsite = new System.Windows.Forms.TextBox();
            this.textBoxNumber1 = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxNumber2 = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnXmlOutput = new System.Windows.Forms.Button();
            this.btnJsonOutput = new System.Windows.Forms.Button();
            this.btnJsonInput = new System.Windows.Forms.Button();
            this.btnCsvOutput = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.grpbxContact.SuspendLayout();
            this.grpbxContactDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbxContact
            // 
            this.grpbxContact.Controls.Add(this.listBox1);
            this.grpbxContact.Location = new System.Drawing.Point(12, 12);
            this.grpbxContact.Name = "grpbxContact";
            this.grpbxContact.Size = new System.Drawing.Size(258, 528);
            this.grpbxContact.TabIndex = 0;
            this.grpbxContact.TabStop = false;
            this.grpbxContact.Text = "Contact";
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(3, 18);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(252, 507);
            this.listBox1.TabIndex = 0;
            this.listBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDoubleClick);
            // 
            // grpbxContactDetails
            // 
            this.grpbxContactDetails.Controls.Add(this.label9);
            this.grpbxContactDetails.Controls.Add(this.label8);
            this.grpbxContactDetails.Controls.Add(this.label7);
            this.grpbxContactDetails.Controls.Add(this.label6);
            this.grpbxContactDetails.Controls.Add(this.label5);
            this.grpbxContactDetails.Controls.Add(this.label4);
            this.grpbxContactDetails.Controls.Add(this.label3);
            this.grpbxContactDetails.Controls.Add(this.label2);
            this.grpbxContactDetails.Controls.Add(this.label1);
            this.grpbxContactDetails.Controls.Add(this.richTextBoxDescription);
            this.grpbxContactDetails.Controls.Add(this.textBoxNumber3);
            this.grpbxContactDetails.Controls.Add(this.textBoxWebsite);
            this.grpbxContactDetails.Controls.Add(this.textBoxNumber1);
            this.grpbxContactDetails.Controls.Add(this.textBoxSurname);
            this.grpbxContactDetails.Controls.Add(this.textBoxNumber2);
            this.grpbxContactDetails.Controls.Add(this.textBoxEmail);
            this.grpbxContactDetails.Controls.Add(this.textBoxAddress);
            this.grpbxContactDetails.Controls.Add(this.textBoxName);
            this.grpbxContactDetails.Location = new System.Drawing.Point(284, 12);
            this.grpbxContactDetails.Name = "grpbxContactDetails";
            this.grpbxContactDetails.Size = new System.Drawing.Size(760, 287);
            this.grpbxContactDetails.TabIndex = 1;
            this.grpbxContactDetails.TabStop = false;
            this.grpbxContactDetails.Text = "ContactDetails";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(509, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 17);
            this.label9.TabIndex = 18;
            this.label9.Text = "Description";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(283, 196);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "Number3";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Number2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(283, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Number1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(283, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Website";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(283, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Surname";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Name";
            // 
            // richTextBoxDescription
            // 
            this.richTextBoxDescription.Location = new System.Drawing.Point(512, 63);
            this.richTextBoxDescription.Name = "richTextBoxDescription";
            this.richTextBoxDescription.Size = new System.Drawing.Size(216, 175);
            this.richTextBoxDescription.TabIndex = 9;
            this.richTextBoxDescription.Text = "";
            // 
            // textBoxNumber3
            // 
            this.textBoxNumber3.Location = new System.Drawing.Point(286, 216);
            this.textBoxNumber3.Name = "textBoxNumber3";
            this.textBoxNumber3.Size = new System.Drawing.Size(190, 22);
            this.textBoxNumber3.TabIndex = 8;
            // 
            // textBoxWebsite
            // 
            this.textBoxWebsite.Location = new System.Drawing.Point(286, 115);
            this.textBoxWebsite.Name = "textBoxWebsite";
            this.textBoxWebsite.Size = new System.Drawing.Size(190, 22);
            this.textBoxWebsite.TabIndex = 7;
            // 
            // textBoxNumber1
            // 
            this.textBoxNumber1.Location = new System.Drawing.Point(286, 164);
            this.textBoxNumber1.Name = "textBoxNumber1";
            this.textBoxNumber1.Size = new System.Drawing.Size(190, 22);
            this.textBoxNumber1.TabIndex = 6;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(286, 63);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(190, 22);
            this.textBoxSurname.TabIndex = 5;
            // 
            // textBoxNumber2
            // 
            this.textBoxNumber2.Location = new System.Drawing.Point(37, 216);
            this.textBoxNumber2.Name = "textBoxNumber2";
            this.textBoxNumber2.Size = new System.Drawing.Size(190, 22);
            this.textBoxNumber2.TabIndex = 4;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(37, 115);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(190, 22);
            this.textBoxEmail.TabIndex = 3;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(37, 164);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(190, 22);
            this.textBoxAddress.TabIndex = 1;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(37, 63);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(190, 22);
            this.textBoxName.TabIndex = 0;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(284, 313);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(747, 37);
            this.btnCreate.TabIndex = 2;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(284, 381);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(346, 37);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(685, 381);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(346, 37);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnXmlOutput
            // 
            this.btnXmlOutput.Location = new System.Drawing.Point(284, 500);
            this.btnXmlOutput.Name = "btnXmlOutput";
            this.btnXmlOutput.Size = new System.Drawing.Size(167, 37);
            this.btnXmlOutput.TabIndex = 5;
            this.btnXmlOutput.Text = "Xml Output";
            this.btnXmlOutput.UseVisualStyleBackColor = true;
            this.btnXmlOutput.Click += new System.EventHandler(this.btnXmlOutput_Click);
            // 
            // btnJsonOutput
            // 
            this.btnJsonOutput.Location = new System.Drawing.Point(284, 448);
            this.btnJsonOutput.Name = "btnJsonOutput";
            this.btnJsonOutput.Size = new System.Drawing.Size(167, 37);
            this.btnJsonOutput.TabIndex = 6;
            this.btnJsonOutput.Text = "Json Output";
            this.btnJsonOutput.UseVisualStyleBackColor = true;
            this.btnJsonOutput.Click += new System.EventHandler(this.btnJsonOutput_Click);
            // 
            // btnJsonInput
            // 
            this.btnJsonInput.Location = new System.Drawing.Point(685, 448);
            this.btnJsonInput.Name = "btnJsonInput";
            this.btnJsonInput.Size = new System.Drawing.Size(346, 44);
            this.btnJsonInput.TabIndex = 8;
            this.btnJsonInput.Text = "Json Input";
            this.btnJsonInput.UseVisualStyleBackColor = true;
            this.btnJsonInput.Click += new System.EventHandler(this.btnJsonInput_Click);
            // 
            // btnCsvOutput
            // 
            this.btnCsvOutput.Location = new System.Drawing.Point(466, 500);
            this.btnCsvOutput.Name = "btnCsvOutput";
            this.btnCsvOutput.Size = new System.Drawing.Size(167, 37);
            this.btnCsvOutput.TabIndex = 7;
            this.btnCsvOutput.Text = "Csv Output";
            this.btnCsvOutput.UseVisualStyleBackColor = true;
            this.btnCsvOutput.Click += new System.EventHandler(this.btnCsvOutput_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(466, 448);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(167, 37);
            this.textBox1.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(502, 428);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 17);
            this.label10.TabIndex = 10;
            this.label10.Text = "Export Name";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // PhoneBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 552);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnJsonInput);
            this.Controls.Add(this.btnCsvOutput);
            this.Controls.Add(this.btnJsonOutput);
            this.Controls.Add(this.btnXmlOutput);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.grpbxContactDetails);
            this.Controls.Add(this.grpbxContact);
            this.Name = "PhoneBookForm";
            this.Text = "PhoneBookForm";
            this.Load += new System.EventHandler(this.PhoneBookForm_Load);
            this.grpbxContact.ResumeLayout(false);
            this.grpbxContactDetails.ResumeLayout(false);
            this.grpbxContactDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbxContact;
        private System.Windows.Forms.GroupBox grpbxContactDetails;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnXmlOutput;
        private System.Windows.Forms.Button btnJsonOutput;
        private System.Windows.Forms.Button btnJsonInput;
        private System.Windows.Forms.Button btnCsvOutput;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBoxNumber2;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBoxDescription;
        private System.Windows.Forms.TextBox textBoxNumber3;
        private System.Windows.Forms.TextBox textBoxWebsite;
        private System.Windows.Forms.TextBox textBoxNumber1;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}