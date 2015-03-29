namespace BPID_CESAR_WinForms
{
    partial class MainForm
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
            this.labelText = new System.Windows.Forms.Label();
            this.labelCipher = new System.Windows.Forms.Label();
            this.labelDecrypted = new System.Windows.Forms.Label();
            this.richTextBoxText = new System.Windows.Forms.RichTextBox();
            this.richTextBoxEncrypted = new System.Windows.Forms.RichTextBox();
            this.richTextBoxDecrypted = new System.Windows.Forms.RichTextBox();
            this.buttonEncrypt = new System.Windows.Forms.Button();
            this.buttonDecrypt = new System.Windows.Forms.Button();
            this.labelShift = new System.Windows.Forms.Label();
            this.textBoxShiftEncryption = new System.Windows.Forms.TextBox();
            this.textBoxShiftDecryption = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelText
            // 
            this.labelText.AutoSize = true;
            this.labelText.Location = new System.Drawing.Point(12, 54);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(28, 13);
            this.labelText.TabIndex = 0;
            this.labelText.Text = "Text";
            // 
            // labelCipher
            // 
            this.labelCipher.AutoSize = true;
            this.labelCipher.Location = new System.Drawing.Point(13, 189);
            this.labelCipher.Name = "labelCipher";
            this.labelCipher.Size = new System.Drawing.Size(37, 13);
            this.labelCipher.TabIndex = 1;
            this.labelCipher.Text = "Cipher";
            // 
            // labelDecrypted
            // 
            this.labelDecrypted.AutoSize = true;
            this.labelDecrypted.Location = new System.Drawing.Point(12, 314);
            this.labelDecrypted.Name = "labelDecrypted";
            this.labelDecrypted.Size = new System.Drawing.Size(53, 13);
            this.labelDecrypted.TabIndex = 2;
            this.labelDecrypted.Text = "Decripted";
            // 
            // richTextBoxText
            // 
            this.richTextBoxText.Location = new System.Drawing.Point(71, 12);
            this.richTextBoxText.Name = "richTextBoxText";
            this.richTextBoxText.Size = new System.Drawing.Size(500, 85);
            this.richTextBoxText.TabIndex = 3;
            this.richTextBoxText.Text = "";
            // 
            // richTextBoxEncrypted
            // 
            this.richTextBoxEncrypted.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBoxEncrypted.Location = new System.Drawing.Point(71, 145);
            this.richTextBoxEncrypted.Name = "richTextBoxEncrypted";
            this.richTextBoxEncrypted.ReadOnly = true;
            this.richTextBoxEncrypted.Size = new System.Drawing.Size(500, 96);
            this.richTextBoxEncrypted.TabIndex = 4;
            this.richTextBoxEncrypted.Text = "";
            // 
            // richTextBoxDecrypted
            // 
            this.richTextBoxDecrypted.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBoxDecrypted.Location = new System.Drawing.Point(71, 286);
            this.richTextBoxDecrypted.Name = "richTextBoxDecrypted";
            this.richTextBoxDecrypted.ReadOnly = true;
            this.richTextBoxDecrypted.Size = new System.Drawing.Size(500, 86);
            this.richTextBoxDecrypted.TabIndex = 5;
            this.richTextBoxDecrypted.Text = "";
            // 
            // buttonEncrypt
            // 
            this.buttonEncrypt.Location = new System.Drawing.Point(177, 103);
            this.buttonEncrypt.Name = "buttonEncrypt";
            this.buttonEncrypt.Size = new System.Drawing.Size(387, 36);
            this.buttonEncrypt.TabIndex = 6;
            this.buttonEncrypt.Text = "Encrypt";
            this.buttonEncrypt.UseVisualStyleBackColor = true;
            this.buttonEncrypt.Click += new System.EventHandler(this.buttonEncrypt_Click);
            // 
            // buttonDecrypt
            // 
            this.buttonDecrypt.Location = new System.Drawing.Point(177, 247);
            this.buttonDecrypt.Name = "buttonDecrypt";
            this.buttonDecrypt.Size = new System.Drawing.Size(388, 33);
            this.buttonDecrypt.TabIndex = 7;
            this.buttonDecrypt.Text = "Decrypt";
            this.buttonDecrypt.UseVisualStyleBackColor = true;
            this.buttonDecrypt.Click += new System.EventHandler(this.buttonDecrypt_Click);
            // 
            // labelShift
            // 
            this.labelShift.AutoSize = true;
            this.labelShift.Location = new System.Drawing.Point(13, 115);
            this.labelShift.Name = "labelShift";
            this.labelShift.Size = new System.Drawing.Size(28, 13);
            this.labelShift.TabIndex = 8;
            this.labelShift.Text = "Shift";
            // 
            // textBoxShiftEncryption
            // 
            this.textBoxShiftEncryption.Location = new System.Drawing.Point(71, 112);
            this.textBoxShiftEncryption.Name = "textBoxShiftEncryption";
            this.textBoxShiftEncryption.Size = new System.Drawing.Size(100, 20);
            this.textBoxShiftEncryption.TabIndex = 9;
            // 
            // textBoxShiftDecryption
            // 
            this.textBoxShiftDecryption.Location = new System.Drawing.Point(71, 254);
            this.textBoxShiftDecryption.Name = "textBoxShiftDecryption";
            this.textBoxShiftDecryption.Size = new System.Drawing.Size(100, 20);
            this.textBoxShiftDecryption.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Shift(decr)";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 379);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxShiftDecryption);
            this.Controls.Add(this.textBoxShiftEncryption);
            this.Controls.Add(this.labelShift);
            this.Controls.Add(this.buttonDecrypt);
            this.Controls.Add(this.buttonEncrypt);
            this.Controls.Add(this.richTextBoxDecrypted);
            this.Controls.Add(this.richTextBoxEncrypted);
            this.Controls.Add(this.richTextBoxText);
            this.Controls.Add(this.labelDecrypted);
            this.Controls.Add(this.labelCipher);
            this.Controls.Add(this.labelText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.Text = "Cesar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelText;
        private System.Windows.Forms.Label labelCipher;
        private System.Windows.Forms.Label labelDecrypted;
        private System.Windows.Forms.RichTextBox richTextBoxText;
        private System.Windows.Forms.RichTextBox richTextBoxEncrypted;
        private System.Windows.Forms.RichTextBox richTextBoxDecrypted;
        private System.Windows.Forms.Button buttonEncrypt;
        private System.Windows.Forms.Button buttonDecrypt;
        private System.Windows.Forms.Label labelShift;
        private System.Windows.Forms.TextBox textBoxShiftEncryption;
        private System.Windows.Forms.TextBox textBoxShiftDecryption;
        private System.Windows.Forms.Label label1;
    }
}

