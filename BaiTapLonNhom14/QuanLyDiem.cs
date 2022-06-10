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
    public partial class QuanLyDiem : Form
    {
        private string selectDiem = "select SV.maSV as N'Mã SV', MONHOC.maMonHoc as N'Mã môn học', MONHOC.tenMonHoc as N'Tên môn học', DIEM.diem as N'Điểm', KHOA.tenKhoa as N'Khoa' from DIEM inner join SV on DIEM.maSV = SV.maSV inner join MONHOC on DIEM.maMonHoc = MONHOC.maMonHoc inner join THUOC on MONHOC.maMonHoc = THUOC.maMonHoc inner join KHOA on KHOA.maKhoa = THUOC.maKhoa inner join LOP on SV.tenLop = LOP.tenLop and Lop.maKhoa = Khoa.maKhoa";
        private int status;
        private string currentSql;
        public QuanLyDiem()
        {
            InitializeComponent();
        }

        private void QuanLyDiem_Load(object sender, EventArgs e)
        {
            SetDataComboBox(comboBoxKhoa, "SELECT * FROM KHOA", "tenKhoa", "maKhoa");
            dataGridView1.DataSource = DataAccess.SqlExecute(selectDiem);
            EnableButton();
            currentSql = selectDiem;
        }
        private void SetDataComboBox(ComboBox comboBox, string sqlQuery, string displayMember, string valueMember)
        {
            comboBox.DisplayMember = displayMember;
            comboBox.ValueMember = valueMember;
            comboBox.DataSource = DataAccess.SqlExecute(sqlQuery);
            comboBoxKhoa.SelectedItem = null;
        }

        private void showResult(DataTable data)
        {
            if (data.Rows.Count > 0)
            {
                MessageBox.Show("Tìm được " + data.Rows.Count + " kết quả");
            }
            else
            {
                MessageBox.Show("Không tồn tại!");
            }
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            if (textBoxMaSV.Text != "")
            {
                string sql = selectDiem + " and SV.maSV = '" + textBoxMaSV.Text + "'";
                DataTable data = DataAccess.SqlExecute(sql);
                dataGridView1.DataSource = data;
                showResult(data);
                currentSql = sql;
                return;
            }
            if (textBoxMaMonHoc.Text != "")
            {
                string sql = selectDiem + " and DIEM.maMonHoc = '" + textBoxMaMonHoc.Text + "'";
                DataTable data = DataAccess.SqlExecute(sql);
                dataGridView1.DataSource = data;
                showResult(data);
                currentSql = sql;
                return;
            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBoxMaSV.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBoxMaMonHoc.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBoxTenMonHoc.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBoxDiem.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            comboBoxKhoa.SelectedIndex = where();
        }
        private int where()
        {
            foreach (DataRowView i in comboBoxKhoa.Items)
            {
                if (i.Row[1].ToString() == dataGridView1.CurrentRow.Cells[4].Value.ToString())
                {
                    return comboBoxKhoa.Items.IndexOf(i);
                }
            }
            return 0;
        }

        private void DisableButton()
        {
            buttonShow.Enabled = false;
            buttonSave.Enabled = false;
            buttonThem.Enabled = false;
            buttonSua.Enabled = false;
            buttonSave.Enabled = true;
            buttonCancel.Enabled = true;
        }
        private void EnableButton()
        {
            buttonShow.Enabled = true;
            buttonSave.Enabled = true;
            buttonThem.Enabled = true;
            buttonSua.Enabled = true;
            buttonSave.Enabled = false;
            buttonCancel.Enabled = false;
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            DisableButton();
            status = 0;
            textBoxTenMonHoc.Enabled = false;
            textBoxTenMonHoc.BackColor = Color.White;
            textBoxTenMonHoc.Text = "";
            comboBoxKhoa.Enabled = false;
            comboBoxKhoa.BackColor = Color.White;
            comboBoxKhoa.SelectedItem = null;
            dataGridView1.RowHeaderMouseClick -= dataGridView1_RowHeaderMouseClick;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (status == 0)
            {
                try
                {
                    DataAccess.SqlExecute("insert into DIEM values('" + textBoxDiem.Text + "', '" + textBoxMaSV.Text + "', '" + textBoxMaMonHoc.Text + "');");
                }
                catch (Exception)
                {
                    MessageBox.Show("Thêm không thành công!");
                    return;
                }
                MessageBox.Show("Thêm thành công.");
                dataGridView1.DataSource = DataAccess.SqlExecute(currentSql);
            }
            if (status == 1)
            {
                try
                {
                    DataAccess.SqlExecute("update DIEM set diem = '" + textBoxDiem.Text + "' where maSV = '" + textBoxMaSV.Text + "' and maMonHoc = '" + textBoxMaMonHoc.Text + "'");
                }
                catch (Exception)
                {
                    MessageBox.Show("Sửa không thành công!");
                    return;
                }
                MessageBox.Show("Sửa điểm thành công.");
                dataGridView1.DataSource = DataAccess.SqlExecute(currentSql);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            if (status == 0)
            {
                EnableButton();
                textBoxTenMonHoc.Enabled = true;
                comboBoxKhoa.Enabled = true;
                dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            }
            if (status == 1)
            {
                EnableButton();
                textBoxTenMonHoc.Enabled = true;
                textBoxMaMonHoc.Enabled = true;
                textBoxMaSV.Enabled = true;
                comboBoxKhoa.Enabled = true;
            }
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DisableButton();
                status = 1;
                textBoxTenMonHoc.Enabled = false;
                textBoxTenMonHoc.BackColor = Color.White;
                textBoxMaMonHoc.Enabled = false;
                textBoxMaMonHoc.BackColor = Color.White;
                textBoxMaSV.Enabled = false;
                textBoxMaSV.BackColor = Color.White;
                comboBoxKhoa.Enabled = false;
                comboBoxKhoa.BackColor = Color.White;
            }
            else
            {
                MessageBox.Show("Chọn điểm cần sửa!");
            }
        }
    }
}
