using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapLonNhom14
{
    public partial class QuanLyKhoa : Form
    {
        string sql = "Select maKhoa as N'Mã khoa', tenKhoa as N'Tên Khoa' from KHOA";
        public QuanLyKhoa()
        {
            InitializeComponent();
        }

        private void QuanLyKhoa_Load(object sender, EventArgs e)
        {
            dataGridViewKhoa.DataSource = DataAccess.SqlExecute(sql);
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            if (textBoxTenKhoa.Text == "" || textBoxMaKhoa.Text == "")
            {
                MessageBox.Show("Hãy điền đầy đủ thông tin khoa!");
            }
            else
            {
                try
                {
                    DataAccess.SqlExecute("insert into KHOA values('" + textBoxMaKhoa.Text + "', N'" + textBoxTenKhoa.Text + "');");
                }
                catch (Exception)
                {
                    MessageBox.Show("Thêm khoa không thành công!");
                    return;
                }
                MessageBox.Show("Thêm khoa thành công.");
                dataGridViewKhoa.DataSource = DataAccess.SqlExecute(sql);
                dataGridViewKhoa.Refresh();
            }
        }

        private void dataGridViewKhoa_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBoxMaKhoa.Text = dataGridViewKhoa.SelectedRows[0].Cells[0].Value.ToString();
            textBoxTenKhoa.Text = dataGridViewKhoa.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {                                   
            if (dataGridViewKhoa.SelectedRows.Count > 0 && dataGridViewKhoa.SelectedRows[0].Cells[0].Value != null)
            {
                if (textBoxMaKhoa.Text == "" || textBoxTenKhoa.Text == "")
                {
                    MessageBox.Show("Hãy điền đẩy đủ thông tin khoa!");
                }
                else
                {
                    try
                    {
                        DataAccess.SqlExecute("update KHOA set tenKhoa = N'" + textBoxTenKhoa.Text + "' where maKhoa = '" + textBoxMaKhoa.Text + "'");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Sửa không thành công!");
                        return;
                    }
                    MessageBox.Show("Sửa thành công.");
                    dataGridViewKhoa.DataSource = DataAccess.SqlExecute(sql);
                }
            }
            else
            {
                MessageBox.Show("Chọn khoa để sửa!");
            }
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            if (dataGridViewKhoa.SelectedRows.Count > 0 && dataGridViewKhoa.SelectedRows[0].Cells[0].Value != null)
            {
                try
                {
                    DataAccess.SqlExecute("delete from KHOA where maKhoa = '" + textBoxMaKhoa.Text + "'");
                }
                catch (Exception)
                {
                    MessageBox.Show("Xóa không thành công!");
                    return;
                }
                MessageBox.Show("Xóa thành công.");
                dataGridViewKhoa.DataSource = DataAccess.SqlExecute(sql);
            }
            else
            {
                MessageBox.Show("Chọn khoa để xóa!");
            }
        }
    }
}
