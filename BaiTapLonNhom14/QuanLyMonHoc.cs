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
    public partial class QuanLyMonHoc : Form
    {
        private string currentSql;
        public QuanLyMonHoc()
        {
            InitializeComponent();
        }

        private void QuanLyMonHoc_Load(object sender, EventArgs e)
        {
            SetDataComboBox(comboBoxKhoa, "SELECT * FROM KHOA", "tenKhoa", "maKhoa");
        }
        private void SetDataComboBox(ComboBox comboBox, string sqlQuery, string displayMember, string valueMember)
        {
            comboBox.DisplayMember = displayMember;
            comboBox.ValueMember = valueMember;
            comboBox.DataSource = DataAccess.SqlExecute(sqlQuery);
        }

        private void comboBoxKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "SELECT MONHOC.maMonHoc as N'Mã môn học', MONHOC.tenMonHoc as N'Tên môn học' FROM MONHOC INNER JOIN THUOC ON MONHOC.maMonHoc = THUOC.maMonHoc INNER JOIN KHOA ON THUOC.maKhoa = KHOA.maKhoa AND KHOA.tenKhoa = N'" + comboBoxKhoa.Text + "'";
            dataGridViewMonHoc.DataSource = DataAccess.SqlExecute(sql);
            currentSql = sql;
        }

        private void dataGridViewMonHoc_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (!String.IsNullOrEmpty(dataGridViewMonHoc[0, dataGridViewMonHoc.CurrentRow.Index].Value.ToString()))
            {
                DataGridViewSelectedRowCollection selectedRow = dataGridViewMonHoc.SelectedRows;
                textBoxMaMonHoc.Text = selectedRow[0].Cells[0].Value.ToString();
                textBoxTenMonHoc.Text = selectedRow[0].Cells[1].Value.ToString();
            }
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            try
            {
                DataRowView maKhoa = (DataRowView)comboBoxKhoa.SelectedItem;
                DataAccess.SqlExecute("insert into MONHOC values('" + textBoxMaMonHoc.Text + "', '" + textBoxTenMonHoc.Text + "')");
                DataAccess.SqlExecute("insert into THUOC values ('" + maKhoa[0].ToString() + "', '" + textBoxMaMonHoc.Text + "')");
            }
            catch (Exception)
            {
                MessageBox.Show("Thêm không thành công.");
                return;
            }
            MessageBox.Show("Thêm thành công");
            dataGridViewMonHoc.DataSource = DataAccess.SqlExecute(currentSql);
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(dataGridViewMonHoc[0, dataGridViewMonHoc.CurrentRow.Index].Value.ToString()))
            {
                MessageBox.Show("Chọn môn học để sửa!");
            }
            else
            {
                try
                {
                    DataRowView maKhoa = (DataRowView)comboBoxKhoa.SelectedItem;
                    DataAccess.SqlExecute("update MONHOC set tenMonHoc = N'" + textBoxTenMonHoc.Text + "' where maMonHoc = '" + textBoxMaMonHoc.Text + "';");
                }
                catch (Exception)
                {
                    MessageBox.Show("Sửa không thành công");
                    return;
                }
                MessageBox.Show("Sửa thành công");
                dataGridViewMonHoc.DataSource = DataAccess.SqlExecute(currentSql);
            }
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(dataGridViewMonHoc[0, dataGridViewMonHoc.CurrentRow.Index].Value.ToString()))
            {
                MessageBox.Show("Chọn môn học để xóa!");
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận xóa?", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        DataAccess.SqlExecute("delete from THUOC where maMonHoc = '" + textBoxMaMonHoc.Text + "'");
                        DataAccess.SqlExecute("delete from MONHOC where maMonHoc = '" + textBoxMaMonHoc.Text + "'");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Xóa không thành công");
                        return;
                    }
                    MessageBox.Show("Xóa thành công");
                    dataGridViewMonHoc.DataSource = DataAccess.SqlExecute(currentSql);
                }        
            }
        }

        private void dataGridViewMonHoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
