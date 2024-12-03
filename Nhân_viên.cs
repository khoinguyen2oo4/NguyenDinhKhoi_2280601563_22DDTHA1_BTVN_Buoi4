using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dataGridView
{
    public partial class Nhân_viên : Form
    {
        public string MSNV { get; set; }
        public string TenNV { get; set; }
        public string LuongCB { get; set; }

        public Nhân_viên()
        {
            InitializeComponent();
        }

        private void Nhân_viên_Load(object sender, EventArgs e)
        {
            txtMSNV.Text = MSNV;
            txtTenNV.Text = TenNV;
            txtLuongCB.Text = LuongCB;
        }

        private void btnDongy_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMSNV.Text) ||
                string.IsNullOrWhiteSpace(txtTenNV.Text) ||
                !decimal.TryParse(txtLuongCB.Text, out _))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ và đúng định dạng dữ liệu!");
                return;
            }

            MSNV = txtMSNV.Text;
            TenNV = txtTenNV.Text;
            LuongCB = txtLuongCB.Text;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
