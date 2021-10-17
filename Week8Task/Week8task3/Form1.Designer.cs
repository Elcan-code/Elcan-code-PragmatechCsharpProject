
namespace Week8task3
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tələbəCheckBox = new System.Windows.Forms.CheckBox();
            this.pensiyaCheckBox = new System.Windows.Forms.CheckBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.calculateButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.qiymetTextBox = new System.Windows.Forms.TextBox();
            this.mehsulTextBox = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.tələbəCheckBox);
            this.groupBox1.Controls.Add(this.pensiyaCheckBox);
            this.groupBox1.Controls.Add(this.clearButton);
            this.groupBox1.Controls.Add(this.calculateButton);
            this.groupBox1.Location = new System.Drawing.Point(527, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(228, 211);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Əməliyyatlar";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(34, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(163, 22);
            this.textBox1.TabIndex = 11;
            // 
            // tələbəCheckBox
            // 
            this.tələbəCheckBox.AutoSize = true;
            this.tələbəCheckBox.Location = new System.Drawing.Point(34, 59);
            this.tələbəCheckBox.Name = "tələbəCheckBox";
            this.tələbəCheckBox.Size = new System.Drawing.Size(74, 21);
            this.tələbəCheckBox.TabIndex = 8;
            this.tələbəCheckBox.Text = "Tələbə";
            this.tələbəCheckBox.UseVisualStyleBackColor = true;
            // 
            // pensiyaCheckBox
            // 
            this.pensiyaCheckBox.AutoSize = true;
            this.pensiyaCheckBox.Location = new System.Drawing.Point(114, 59);
            this.pensiyaCheckBox.Name = "pensiyaCheckBox";
            this.pensiyaCheckBox.Size = new System.Drawing.Size(90, 21);
            this.pensiyaCheckBox.TabIndex = 9;
            this.pensiyaCheckBox.Text = "Pensiyaçı";
            this.pensiyaCheckBox.UseVisualStyleBackColor = true;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(34, 157);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(163, 38);
            this.clearButton.TabIndex = 6;
            this.clearButton.Text = "Təmizlə";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(34, 97);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(163, 38);
            this.calculateButton.TabIndex = 5;
            this.calculateButton.Text = "Hesabla";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(271, 241);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(180, 38);
            this.addButton.TabIndex = 16;
            this.addButton.Text = "Əlavə et";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(268, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Məhsulun qiyməti";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(268, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Məhsulun adı";
            // 
            // qiymetTextBox
            // 
            this.qiymetTextBox.Location = new System.Drawing.Point(271, 183);
            this.qiymetTextBox.Name = "qiymetTextBox";
            this.qiymetTextBox.Size = new System.Drawing.Size(180, 22);
            this.qiymetTextBox.TabIndex = 13;
            // 
            // mehsulTextBox
            // 
            this.mehsulTextBox.Location = new System.Drawing.Point(271, 103);
            this.mehsulTextBox.Name = "mehsulTextBox";
            this.mehsulTextBox.Size = new System.Drawing.Size(180, 22);
            this.mehsulTextBox.TabIndex = 12;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(25, 70);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(215, 260);
            this.listBox1.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 359);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.qiymetTextBox);
            this.Controls.Add(this.mehsulTextBox);
            this.Controls.Add(this.listBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox tələbəCheckBox;
        private System.Windows.Forms.CheckBox pensiyaCheckBox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox qiymetTextBox;
        private System.Windows.Forms.TextBox mehsulTextBox;
        private System.Windows.Forms.ListBox listBox1;
    }
}

