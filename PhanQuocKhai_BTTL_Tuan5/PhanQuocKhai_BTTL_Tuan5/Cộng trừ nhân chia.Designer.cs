namespace PhanQuocKhai_BTTL_Tuan5
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
            this.components = new System.ComponentModel.Container();
            this.txta = new System.Windows.Forms.TextBox();
            this.txtb = new System.Windows.Forms.TextBox();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.btcong = new System.Windows.Forms.Button();
            this.bttru = new System.Windows.Forms.Button();
            this.btnhan = new System.Windows.Forms.Button();
            this.btchia = new System.Windows.Forms.Button();
            this.txt_a = new System.Windows.Forms.Label();
            this.txt_b = new System.Windows.Forms.Label();
            this.txt_KQ = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txta
            // 
            this.txta.Location = new System.Drawing.Point(131, 54);
            this.txta.Name = "txta";
            this.txta.Size = new System.Drawing.Size(100, 20);
            this.txta.TabIndex = 0;
            // 
            // txtb
            // 
            this.txtb.Location = new System.Drawing.Point(504, 54);
            this.txtb.Name = "txtb";
            this.txtb.Size = new System.Drawing.Size(100, 20);
            this.txtb.TabIndex = 1;
            // 
            // txtKetQua
            // 
            this.txtKetQua.Location = new System.Drawing.Point(257, 135);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.Size = new System.Drawing.Size(215, 20);
            this.txtKetQua.TabIndex = 2;
            // 
            // btcong
            // 
            this.btcong.Location = new System.Drawing.Point(131, 192);
            this.btcong.Name = "btcong";
            this.btcong.Size = new System.Drawing.Size(75, 23);
            this.btcong.TabIndex = 3;
            this.btcong.Text = "+";
            this.btcong.UseVisualStyleBackColor = true;
            this.btcong.Click += new System.EventHandler(this.btcong_Click);
            // 
            // bttru
            // 
            this.bttru.Location = new System.Drawing.Point(257, 192);
            this.bttru.Name = "bttru";
            this.bttru.Size = new System.Drawing.Size(75, 23);
            this.bttru.TabIndex = 4;
            this.bttru.Text = "-";
            this.bttru.UseVisualStyleBackColor = true;
            this.bttru.Click += new System.EventHandler(this.bttru_Click);
            // 
            // btnhan
            // 
            this.btnhan.Location = new System.Drawing.Point(398, 192);
            this.btnhan.Name = "btnhan";
            this.btnhan.Size = new System.Drawing.Size(75, 23);
            this.btnhan.TabIndex = 5;
            this.btnhan.Text = "x";
            this.btnhan.UseVisualStyleBackColor = true;
            this.btnhan.Click += new System.EventHandler(this.btnhan_Click);
            // 
            // btchia
            // 
            this.btchia.Location = new System.Drawing.Point(504, 192);
            this.btchia.Name = "btchia";
            this.btchia.Size = new System.Drawing.Size(75, 23);
            this.btchia.TabIndex = 6;
            this.btchia.Text = "/";
            this.btchia.UseVisualStyleBackColor = true;
            this.btchia.Click += new System.EventHandler(this.btchia_Click);
            // 
            // txt_a
            // 
            this.txt_a.AutoSize = true;
            this.txt_a.Location = new System.Drawing.Point(70, 57);
            this.txt_a.Name = "txt_a";
            this.txt_a.Size = new System.Drawing.Size(19, 13);
            this.txt_a.TabIndex = 8;
            this.txt_a.Text = "a=";
            // 
            // txt_b
            // 
            this.txt_b.AutoSize = true;
            this.txt_b.Location = new System.Drawing.Point(395, 54);
            this.txt_b.Name = "txt_b";
            this.txt_b.Size = new System.Drawing.Size(19, 13);
            this.txt_b.TabIndex = 9;
            this.txt_b.Text = "b=";
            // 
            // txt_KQ
            // 
            this.txt_KQ.AutoSize = true;
            this.txt_KQ.Location = new System.Drawing.Point(179, 135);
            this.txt_KQ.Name = "txt_KQ";
            this.txt_KQ.Size = new System.Drawing.Size(46, 13);
            this.txt_KQ.TabIndex = 10;
            this.txt_KQ.Text = "Kết Quả";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 261);
            this.Controls.Add(this.txt_KQ);
            this.Controls.Add(this.txt_b);
            this.Controls.Add(this.txt_a);
            this.Controls.Add(this.btchia);
            this.Controls.Add(this.btnhan);
            this.Controls.Add(this.bttru);
            this.Controls.Add(this.btcong);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.txtb);
            this.Controls.Add(this.txta);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txta;
        private System.Windows.Forms.TextBox txtb;
        private System.Windows.Forms.TextBox txtKetQua;
        private System.Windows.Forms.Button btcong;
        private System.Windows.Forms.Button bttru;
        private System.Windows.Forms.Button btnhan;
        private System.Windows.Forms.Button btchia;
        private System.Windows.Forms.Label txt_a;
        private System.Windows.Forms.Label txt_b;
        private System.Windows.Forms.Label txt_KQ;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

