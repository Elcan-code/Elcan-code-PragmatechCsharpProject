
namespace Booktask1
{
    partial class Form1
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.musteriList = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.nomreTextBox = new System.Windows.Forms.TextBox();
            this.mailTextBox = new System.Windows.Forms.TextBox();
            this.NomreLabel = new System.Windows.Forms.Label();
            this.soyadTextBox = new System.Windows.Forms.TextBox();
            this.MailLabel = new System.Windows.Forms.Label();
            this.adTextbox = new System.Windows.Forms.TextBox();
            this.AdLabel = new System.Windows.Forms.Label();
            this.SoyadLabel = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.musteriList);
            this.groupBox2.Location = new System.Drawing.Point(41, 43);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(259, 317);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // musteriList
            // 
            this.musteriList.FormattingEnabled = true;
            this.musteriList.ItemHeight = 16;
            this.musteriList.Location = new System.Drawing.Point(17, 24);
            this.musteriList.Name = "musteriList";
            this.musteriList.Size = new System.Drawing.Size(225, 276);
            this.musteriList.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.nomreTextBox);
            this.groupBox1.Controls.Add(this.mailTextBox);
            this.groupBox1.Controls.Add(this.NomreLabel);
            this.groupBox1.Controls.Add(this.soyadTextBox);
            this.groupBox1.Controls.Add(this.MailLabel);
            this.groupBox1.Controls.Add(this.adTextbox);
            this.groupBox1.Controls.Add(this.AdLabel);
            this.groupBox1.Controls.Add(this.SoyadLabel);
            this.groupBox1.Location = new System.Drawing.Point(364, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 320);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Musteri Formu";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 266);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 35);
            this.button1.TabIndex = 7;
            this.button1.Text = "Yadda Saxla";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // nomreTextBox
            // 
            this.nomreTextBox.Location = new System.Drawing.Point(22, 221);
            this.nomreTextBox.Name = "nomreTextBox";
            this.nomreTextBox.Size = new System.Drawing.Size(197, 22);
            this.nomreTextBox.TabIndex = 6;
            // 
            // mailTextBox
            // 
            this.mailTextBox.Location = new System.Drawing.Point(22, 163);
            this.mailTextBox.Name = "mailTextBox";
            this.mailTextBox.Size = new System.Drawing.Size(197, 22);
            this.mailTextBox.TabIndex = 5;
            // 
            // NomreLabel
            // 
            this.NomreLabel.AutoSize = true;
            this.NomreLabel.Location = new System.Drawing.Point(19, 201);
            this.NomreLabel.Name = "NomreLabel";
            this.NomreLabel.Size = new System.Drawing.Size(50, 17);
            this.NomreLabel.TabIndex = 3;
            this.NomreLabel.Text = "Nomre";
            // 
            // soyadTextBox
            // 
            this.soyadTextBox.Location = new System.Drawing.Point(22, 106);
            this.soyadTextBox.Name = "soyadTextBox";
            this.soyadTextBox.Size = new System.Drawing.Size(197, 22);
            this.soyadTextBox.TabIndex = 2;
            // 
            // MailLabel
            // 
            this.MailLabel.AutoSize = true;
            this.MailLabel.Location = new System.Drawing.Point(19, 143);
            this.MailLabel.Name = "MailLabel";
            this.MailLabel.Size = new System.Drawing.Size(33, 17);
            this.MailLabel.TabIndex = 4;
            this.MailLabel.Text = "Mail";
            // 
            // adTextbox
            // 
            this.adTextbox.Location = new System.Drawing.Point(22, 48);
            this.adTextbox.Name = "adTextbox";
            this.adTextbox.Size = new System.Drawing.Size(197, 22);
            this.adTextbox.TabIndex = 1;
            // 
            // AdLabel
            // 
            this.AdLabel.AutoSize = true;
            this.AdLabel.Location = new System.Drawing.Point(19, 27);
            this.AdLabel.Name = "AdLabel";
            this.AdLabel.Size = new System.Drawing.Size(25, 17);
            this.AdLabel.TabIndex = 0;
            this.AdLabel.Text = "Ad";
            // 
            // SoyadLabel
            // 
            this.SoyadLabel.AutoSize = true;
            this.SoyadLabel.Location = new System.Drawing.Point(19, 86);
            this.SoyadLabel.Name = "SoyadLabel";
            this.SoyadLabel.Size = new System.Drawing.Size(48, 17);
            this.SoyadLabel.TabIndex = 1;
            this.SoyadLabel.Text = "Soyad";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 415);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox musteriList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox nomreTextBox;
        private System.Windows.Forms.TextBox mailTextBox;
        private System.Windows.Forms.Label NomreLabel;
        private System.Windows.Forms.TextBox soyadTextBox;
        private System.Windows.Forms.Label MailLabel;
        private System.Windows.Forms.TextBox adTextbox;
        private System.Windows.Forms.Label AdLabel;
        private System.Windows.Forms.Label SoyadLabel;
    }
}

