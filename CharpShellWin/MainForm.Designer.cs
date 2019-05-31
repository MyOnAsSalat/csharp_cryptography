namespace CharpShellWin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.encrypt = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.text = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.param2 = new System.Windows.Forms.TextBox();
            this.decrypted = new System.Windows.Forms.TextBox();
            this.encrypted2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.param = new System.Windows.Forms.TextBox();
            this.encrypted = new System.Windows.Forms.TextBox();
            this.decrypt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(674, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(134, 34);
            this.button3.TabIndex = 5;
            this.button3.Text = "Load from file";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(582, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 34);
            this.button2.TabIndex = 4;
            this.button2.Text = "Cls";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(814, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(76, 34);
            this.button4.TabIndex = 6;
            this.button4.Text = "Reffs";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Tahoma", 9.25F);
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(489, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(87, 34);
            this.button5.TabIndex = 4;
            this.button5.Text = "Save";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(896, 4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(81, 34);
            this.button6.TabIndex = 7;
            this.button6.Text = "Usings";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // encrypt
            // 
            this.encrypt.Font = new System.Drawing.Font("Tahoma", 9.25F);
            this.encrypt.Image = ((System.Drawing.Image)(resources.GetObject("encrypt.Image")));
            this.encrypt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.encrypt.Location = new System.Drawing.Point(3, 3);
            this.encrypt.Name = "encrypt";
            this.encrypt.Size = new System.Drawing.Size(87, 34);
            this.encrypt.TabIndex = 3;
            this.encrypt.Text = "Encrypt";
            this.encrypt.UseVisualStyleBackColor = true;
            this.encrypt.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(3, 205);
            this.textBox1.MaxLength = 327670;
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(974, 350);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // text
            // 
            this.text.Location = new System.Drawing.Point(12, 28);
            this.text.Multiline = true;
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(333, 79);
            this.text.TabIndex = 8;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.param2);
            this.splitContainer1.Panel1.Controls.Add(this.decrypted);
            this.splitContainer1.Panel1.Controls.Add(this.encrypted2);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.param);
            this.splitContainer1.Panel1.Controls.Add(this.encrypted);
            this.splitContainer1.Panel1.Controls.Add(this.text);
            this.splitContainer1.Panel1.Controls.Add(this.textBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.decrypt);
            this.splitContainer1.Panel2.Controls.Add(this.encrypt);
            this.splitContainer1.Panel2.Controls.Add(this.button5);
            this.splitContainer1.Panel2.Controls.Add(this.button2);
            this.splitContainer1.Panel2.Controls.Add(this.button3);
            this.splitContainer1.Panel2.Controls.Add(this.button4);
            this.splitContainer1.Panel2.Controls.Add(this.button6);
            this.splitContainer1.Size = new System.Drawing.Size(980, 603);
            this.splitContainer1.SplitterDistance = 558;
            this.splitContainer1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(622, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 16);
            this.label6.TabIndex = 19;
            this.label6.Text = "Текст";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "Зашифрованный текст";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(359, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Параметры";
            // 
            // param2
            // 
            this.param2.Location = new System.Drawing.Point(351, 128);
            this.param2.Multiline = true;
            this.param2.Name = "param2";
            this.param2.Size = new System.Drawing.Size(265, 71);
            this.param2.TabIndex = 16;
            // 
            // decrypted
            // 
            this.decrypted.Location = new System.Drawing.Point(622, 128);
            this.decrypted.Multiline = true;
            this.decrypted.Name = "decrypted";
            this.decrypted.Size = new System.Drawing.Size(342, 71);
            this.decrypted.TabIndex = 15;
            // 
            // encrypted2
            // 
            this.encrypted2.Location = new System.Drawing.Point(12, 128);
            this.encrypted2.Multiline = true;
            this.encrypted2.Name = "encrypted2";
            this.encrypted2.Size = new System.Drawing.Size(333, 71);
            this.encrypted2.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(622, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Зашифрованный текст";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(359, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Параметры";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Текст";
            // 
            // param
            // 
            this.param.Location = new System.Drawing.Point(351, 28);
            this.param.Multiline = true;
            this.param.Name = "param";
            this.param.Size = new System.Drawing.Size(265, 79);
            this.param.TabIndex = 10;
            // 
            // encrypted
            // 
            this.encrypted.Location = new System.Drawing.Point(622, 28);
            this.encrypted.Multiline = true;
            this.encrypted.Name = "encrypted";
            this.encrypted.Size = new System.Drawing.Size(342, 79);
            this.encrypted.TabIndex = 9;
            // 
            // decrypt
            // 
            this.decrypt.Font = new System.Drawing.Font("Tahoma", 9.25F);
            this.decrypt.Image = ((System.Drawing.Image)(resources.GetObject("decrypt.Image")));
            this.decrypt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.decrypt.Location = new System.Drawing.Point(103, 4);
            this.decrypt.Name = "decrypt";
            this.decrypt.Size = new System.Drawing.Size(87, 34);
            this.decrypt.TabIndex = 8;
            this.decrypt.Text = "Decrypt";
            this.decrypt.UseVisualStyleBackColor = true;
            this.decrypt.Click += new System.EventHandler(this.decrypt_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 603);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Tahoma", 9.25F);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CharpShell Win";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button encrypt;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox text;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox param;
        private System.Windows.Forms.TextBox encrypted;
        private System.Windows.Forms.TextBox param2;
        private System.Windows.Forms.TextBox decrypted;
        private System.Windows.Forms.TextBox encrypted2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button decrypt;
    }
}

