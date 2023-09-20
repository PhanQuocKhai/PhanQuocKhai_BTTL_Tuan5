using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanQuocKhai_BTTL_Tuan5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btcong_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(txta.Text);
                int b = int.Parse(txtb.Text);
                int Tong = a + b;
                txtKetQua.Text = Tong.ToString();
            }
            catch
            {
                MessageBox.Show("Loi roi", "Canh Bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void bttru_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(txta.Text);
                int b = int.Parse(txtb.Text);
                int Hieu = a - b;
                txtKetQua.Text = Hieu.ToString();
            }
            catch
            {
                MessageBox.Show("Loi roi", "Canh Bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void btnhan_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(txta.Text);
                int b = int.Parse(txtb.Text);
                int Tich = a * b;
                txtKetQua.Text = Tich.ToString();
            }
            catch
            {
                MessageBox.Show("Loi roi", "Canh Bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void btchia_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(txta.Text);
                int b = int.Parse(txtb.Text);
                int Thuong = a / b;
                txtKetQua.Text = Thuong.ToString();
            }
            catch
            {
                MessageBox.Show("Loi roi", "Canh Bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
        private void txta_TextChanged(object sender, KeyPressEventArgs e)
        {
            Control ctr = (Control)sender;
            if(ctr.Text.Length>0 && !Char.IsDigit(ctr.Text[ctr.Text.Length-11]) )this.errorProvider1.SetError(ctr,"this is not avalid number");
            else
                this.errorProvider1.Clear();
        }
        private void txtb_TextChanged(object sender, KeyPressEventArgs e)
        {
            Control ctr = (Control)sender;
            if(ctr.Text.Length>0 && !Char.IsDigit(ctr.Text[ctr.Text.Length-11]) )this.errorProvider1.SetError(ctr,"this is not avalid number");
            else
                this.errorProvider1.Clear();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Ban co muon thoat?", "Thoat", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }
        
    }
}
