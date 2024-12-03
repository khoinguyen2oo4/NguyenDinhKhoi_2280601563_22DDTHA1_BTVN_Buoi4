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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Nhân_viên empForm = new Nhân_viên();
            if (empForm.ShowDialog() == DialogResult.OK)
            {
                dataGridView.Rows.Add(empForm.MSNV, empForm.TenNV, empForm.LuongCB);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView.SelectedRows[0];
                if (row.Cells[0].Value != null)
                {
                    Nhân_viên empForm = new Nhân_viên
                    {
                        MSNV = row.Cells[0].Value.ToString(),
                        TenNV = row.Cells[1].Value.ToString(),
                        LuongCB = row.Cells[2].Value.ToString()
                    };

                    if (empForm.ShowDialog() == DialogResult.OK)
                    {
                        row.Cells[0].Value = empForm.MSNV;
                        row.Cells[1].Value = empForm.TenNV;
                        row.Cells[2].Value = empForm.LuongCB;
                    }
                }
                else
                {
                    MessageBox.Show("Dòng này không có dữ liệu để sửa!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để sửa!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView.SelectedRows[0];
                if (row.Cells[0].Value != null)
                {
                    DialogResult confirmResult = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        dataGridView.Rows.RemoveAt(row.Index);
                    }
                }
                else
                {
                    MessageBox.Show("Dòng này không có dữ liệu để xóa!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa!");
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
