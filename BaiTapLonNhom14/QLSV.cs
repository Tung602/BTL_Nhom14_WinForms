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
    public partial class QLSV : Form
    {

        // Hàm tạo QLSV
        public QLSV()
        {
            InitializeComponent();
            ErroProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
        }

        // =============================================================================================================

        //Chuỗi truy xuất tất cả thông tin của sinh viên
        string SqlSelectSV = "SELECT " +
                             "SV.maSV      as 'Mã SV', " +
                             "SV.tenSV     as 'Họ tên', " +
                             "SV.NgaySinh  as 'Ngày sinh'," +
                             "SV.gioiTinh  as 'Giới tính', " +
                             "SV.queQuan   as 'Quê quán', " +
                             "LOP.tenLop   as 'Lớp', " +
                             "KHOA.tenKhoa as 'Khoa' " +
                             "FROM  KHOA " +
                             "INNER JOIN LOP ON KHOA.maKhoa = LOP.maKhoa " +
                             "INNER JOIN SV  ON LOP.tenLop  = SV.tenLop ";

        // Giới tính khi chọn checkbox
        string gioiTinh = "";

        // Current data query
        string currentDataQuery;

        // Selected row

        DataGridViewSelectedRowCollection selectedRow;

        // Trạng thái của button thêm sửa xóa
        int state;

        // ErrorProvider để hiển thị lỗi khi input
        ErrorProvider ErroProvider1 = new ErrorProvider();
       
        // Hàm xóa ErrorProvider cho các input
        private void removeErrorProvider()
        {
            ErroProvider1.SetError(this.textBox_HoTen, String.Empty);
            ErroProvider1.SetError(this.textBox_MaSV, String.Empty);
            ErroProvider1.SetError(this.dateTimePicker_NgaySinh, String.Empty);
            ErroProvider1.SetError(this.label_Gender, String.Empty);
        }

        // Hàm thêm event cho các input
        private void AddEventHander()
        {
            this.textBox_MaSV.TextChanged += new System.EventHandler(this.textBox_MaSV_TextChanged);
            this.textBox_HoTen.TextChanged += new System.EventHandler(this.textBox_HoTen_TextChanged);
            this.dateTimePicker_NgaySinh.ValueChanged += new System.EventHandler(this.dateTimePicker_NgaySinh_ValueChanged);
            this.checkBox_Nam.CheckedChanged += new System.EventHandler(this.checkBox_Nam_CheckedChanged1);
            this.checkBox_Nu.CheckedChanged += new System.EventHandler(this.checkBox_Nu_CheckedChanged1);
        }

        private void AddEventHander1()
        {
            this.textBox_HoTen.TextChanged += new System.EventHandler(this.textBox_HoTen_TextChanged1);
            this.dateTimePicker_NgaySinh.ValueChanged += new System.EventHandler(this.dateTimePicker_NgaySinh_ValueChanged1);
            this.checkBox_Nam.CheckedChanged += new System.EventHandler(this.checkBox_Nam_CheckedChanged2);
            this.checkBox_Nu.CheckedChanged += new System.EventHandler(this.checkBox_Nu_CheckedChanged2);
        }

        // Hàm xóa event cho các input
        private void RemoveEventHander()
        {
            this.textBox_MaSV.TextChanged -= this.textBox_MaSV_TextChanged;
            this.textBox_HoTen.TextChanged -= this.textBox_HoTen_TextChanged;
            this.dateTimePicker_NgaySinh.ValueChanged -= this.dateTimePicker_NgaySinh_ValueChanged;
            this.checkBox_Nam.CheckedChanged -= this.checkBox_Nam_CheckedChanged1;
            this.checkBox_Nu.CheckedChanged -= this.checkBox_Nu_CheckedChanged1;
        }

        private void RemoveEventHander1()
        {
            this.textBox_HoTen.TextChanged -= this.textBox_HoTen_TextChanged1;
            this.dateTimePicker_NgaySinh.ValueChanged -= this.dateTimePicker_NgaySinh_ValueChanged1;
            this.checkBox_Nam.CheckedChanged -= this.checkBox_Nam_CheckedChanged2;
            this.checkBox_Nu.CheckedChanged -= this.checkBox_Nu_CheckedChanged2;
        }

        private bool isAllValid()
        {
            isIdValid();
            isNameValid();
            isDateValid();
            isGenderValid();
            return isNameValid() && isIdValid() && isDateValid() && isGenderValid() ? true : false;
        }

        private bool isAllValid1()
        {
            isNameValid();
            isDateValid();
            isGenderValid();
            return isNameValid() && isDateValid() && isGenderValid() ? true : false;
        }

        // Hàm kiểm tra ID hợp lệ
        private bool isIdValid()
        {
            
            DataTable table = DataAccess.SqlExecute("SELECT maSV FROM SV WHERE maSV = '" + textBox_MaSV.Text.Trim() + "';");
            if (textBox_MaSV.Text.Trim() == "")
            {
                ErroProvider1.SetError(this.textBox_MaSV, "Nhập mã sinh viên.");
                return false;
            }
            else if (table.Rows.Count != 0)
            {
                ErroProvider1.SetError(this.textBox_MaSV, "Mã sinh viên đã tồn tại.");
                return false;
            }
            else
            {
                ErroProvider1.SetError(this.textBox_MaSV, String.Empty);
                return true;
            }
        }

        // Hàm kiểm tra tên hợp lệ
        private bool isNameValid()
        {
            if (textBox_HoTen.Text.Trim() == "")
            {
                ErroProvider1.SetError(this.textBox_HoTen, "Tên không hợp lệ.");
                return false;
            }
            else
            {
                ErroProvider1.SetError(this.textBox_HoTen, String.Empty);
                return true;
            }
        }

        // Hàm kiểm tra ngày sinh hợp lệ
        private bool isDateValid()
        {
            if (!(dateTimePicker_NgaySinh.Value.Date.Year > 1990 && dateTimePicker_NgaySinh.Value.Date.Year < 2005))
            {
                ErroProvider1.SetError(this.dateTimePicker_NgaySinh, "Ngày sinh không hợp lệ.");
                return false;
            }
            else
            {
                ErroProvider1.SetError(this.dateTimePicker_NgaySinh, String.Empty);
                return true;
            }
        }

        // Hàm kiểm tra giới tính hợp lệ
        private bool isGenderValid()
        {
            if (!checkBox_Nam.Checked && !checkBox_Nu.Checked)
            {
                ErroProvider1.SetError(this.label_Gender, "Chọn giới tính.");
                return false;
            }
            else
            {
                ErroProvider1.SetError(this.label_Gender, String.Empty);
                return true;
            }
        }

        // Hàm Enable các button truy xuất và set kiểu comboBox
        private void buttonEnable()
        {
            buttonShow.Enabled = true;
            buttonAdd.Enabled = true;
            buttonEdit.Enabled = true;
            buttonDelete.Enabled = true;
            button_Save.Enabled = false;
            button_Cancel.Enabled = false;
            comboBox_QueQuan.DropDownStyle = ComboBoxStyle.DropDown;
            comboBox_Khoa.DropDownStyle = ComboBoxStyle.DropDown;
            comboBox_Lop.DropDownStyle = ComboBoxStyle.DropDown;
        }

        // Hàm Disable các button truy xuất và set kiểu comboBox
        private void buttonDisable()
        {
            buttonShow.Enabled = false;
            buttonAdd.Enabled = false;
            buttonEdit.Enabled = false;
            buttonDelete.Enabled = false;
            button_Save.Enabled = false;
            button_Cancel.Enabled = true;
            comboBox_QueQuan.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_Khoa.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_Lop.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private bool isContains(ComboBox comboBox)
        {
            foreach (DataRowView row in comboBox.Items)
            {
                if (row[0].ToString() == comboBox.Text)
                {
                    return true;
                }
            }
            return false;
        }

        // Hàm kiểm tra Khoa nhập vào có tồn tại trong CSDL
        private bool isContainsKhoa(ComboBox comboBox)
        {
            DataTable row = DataAccess.SqlExecute("SELECT tenKhoa FROM KHOA WHERE tenKhoa = N'" + comboBox.Text.Trim() + "'");
            return row.Rows.Count > 0 ? true : false;
            
        }

        // Hàm hiển thị kết quả số sinh viên tìm được
        private void showResult(DataTable data)
        {
            if (data.Rows.Count > 0)
            {
                MessageBox.Show("Tìm được " + data.Rows.Count + " kết quả");
            }
            else
            {
                MessageBox.Show("Sinh viên không tồn tại!");
            }
        }

        // Hàm set màu của column
        private void setCellColor(string column)
        {
            dataGridView_SV.Columns[column].DefaultCellStyle.ForeColor = Color.Red;
        }
        //Hàm reset màu của column
        private void resetCellColor()
        {
            foreach (DataGridViewColumn column in dataGridView_SV.Columns)
            {
                column.DefaultCellStyle.ForeColor = Color.Black;
            }
        }

        //Hàm truyền dữ liệu vào comboBox
        private void SetDataComboBox(ComboBox comboBox, string sqlQuery, string displayMember, string valueMember)
        {
            comboBox.DisplayMember = displayMember;
            comboBox.ValueMember = valueMember;
            comboBox.DataSource = DataAccess.SqlExecute(sqlQuery);
            comboBox.Text = "";
        }

        // ===================================================================================================================

        private void QLSV_Load(object sender, EventArgs e)
        {
            dateTimePicker_NgaySinh.CustomFormat = "dd-MM-yyyy";
            SetDataComboBox(comboBox_Khoa, "SELECT * FROM KHOA", "tenKhoa", "tenKhoa");
            selectedRow = dataGridView_SV.SelectedRows;
        }

        // Hàm cho sự kiện chọn Khoa và đổ dữ liệu vào Lớp theo Khoa
        private void comboBox_Khoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetDataComboBox(comboBox_Lop, "SELECT LOP.tenLop FROM LOP INNER JOIN KHOA ON LOP.maKhoa = KHOA.maKhoa AND KHOA.tenKhoa = N'" + comboBox_Khoa.Text + "';", "tenLop", "tenLop");
        }

        // Tìm kiếm sinh viên 
        private void buttonShow_Click(object sender, EventArgs e)
        {
            DataTable getMinimunYear = DataAccess.SqlExecute("SELECT MIN(NgaySinh) as 'MIN' FROM SV");
            DataTable getMaximunYear = DataAccess.SqlExecute("SELECT MAX(NgaySinh) FROM SV");
            int MINIMUN_YEAR = Convert.ToDateTime(getMinimunYear.Rows[0][0].ToString()).Year;
            int MAXIMUN_YEAR = Convert.ToDateTime(getMaximunYear.Rows[0][0].ToString()).Year;
            if (textBox_MaSV.Text != "")
            {
                string sqlSelect = SqlSelectSV + "WHERE SV.maSV = '" + textBox_MaSV.Text.Trim() + "';";
                DataTable data = DataAccess.SqlExecute(sqlSelect);
                dataGridView_SV.DataSource = data;
                currentDataQuery = sqlSelect;
                showResult(data);
                resetCellColor();
                setCellColor("Mã SV");
            }
            else
            {
                List<string> filter = new List<string>();
                DataTable data = DataAccess.SqlExecute(SqlSelectSV);
                dataGridView_SV.DataSource = data;
                resetCellColor();
                if (textBox_HoTen.Text != "")
                {
                    filter.Add("SV.tenSV = N'" + textBox_HoTen.Text.Trim() + "'");
                    setCellColor("Họ tên");
                }
                if (dateTimePicker_NgaySinh.Value.Year >= MINIMUN_YEAR && dateTimePicker_NgaySinh.Value.Year <= MAXIMUN_YEAR)
                {
                    filter.Add("SV.ngaySinh = '" + dateTimePicker_NgaySinh.Value.Date.ToString() + "'");
                    setCellColor("Ngày sinh");
                }
                if (gioiTinh != "")
                {
                    filter.Add("SV.gioiTinh = N'" + gioiTinh + "'");
                    setCellColor("Giới tính");
                }
                if (comboBox_QueQuan.Text != "")
                {
                    filter.Add("SV.queQuan = N'" + comboBox_QueQuan.Text + "'");
                    setCellColor("Quê quán");
                }
                if (comboBox_Khoa.Text != "")
                {
                    filter.Add("KHOA.tenKhoa = N'" + comboBox_Khoa.Text + "'");
                    setCellColor("Khoa");
                }
                if (comboBox_Lop.Text != "")
                {
                    filter.Add("SV.tenLop = N'" + comboBox_Lop.Text + "'");
                    setCellColor("Lớp");
                }
                if (filter.Count == 0)
                {
                    data = DataAccess.SqlExecute(SqlSelectSV);
                    dataGridView_SV.DataSource = data;
                    showResult(data);
                    currentDataQuery = SqlSelectSV;
                }
                else
                {
                    string sqlFilterQuery = SqlSelectSV + " WHERE " + String.Join(" AND ", filter.ToArray());
                    data = DataAccess.SqlExecute(sqlFilterQuery);
                    dataGridView_SV.DataSource = data;
                    showResult(data);
                    currentDataQuery = sqlFilterQuery;
                }
            }
        }

        // Thêm sinh viên click
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            state = 0;
            comboBox_QueQuan.Text = comboBox_QueQuan.Items[0].ToString();
            buttonDisable();
            isAllValid();
            AddEventHander();
            dataGridView_SV.RowHeaderMouseClick -= dataGridView_SV_RowHeaderMouseClick;
        }

        // Sửa sinh viên click
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView_SV.SelectedRows.Count == 0)
            {
                MessageBox.Show("Chọn sinh viên cần sửa.");
            }
            else
            {
                state = 1;
                loadDataToInput();
                selectedRow = dataGridView_SV.SelectedRows;
                dataGridView_SV.RowHeaderMouseClick -= dataGridView_SV_RowHeaderMouseClick;
                buttonDisable();
                textBox_MaSV.Enabled = false;
                AddEventHander1();
            }
        }

        // Lưu thao tác
        private void button_Save_Click(object sender, EventArgs e)
        {
            // Thêm sinh viên
            if (state == 0)
            {
                if (isAllValid()
                && comboBox_QueQuan.Items.Contains(comboBox_QueQuan.Text)
                && isContainsKhoa(comboBox_Khoa)
                && isContains(comboBox_Lop))
                {
                    bool isSuccess = DataAccess.InsertIntoSV(textBox_MaSV, textBox_HoTen, dateTimePicker_NgaySinh, gioiTinh, comboBox_QueQuan, comboBox_Lop);
                    if (isSuccess)
                    {
                        MessageBox.Show("Thêm thành công");
                        buttonEnable();
                        RemoveEventHander();
                        removeErrorProvider();
                        DataTable data = DataAccess.SqlExecute(currentDataQuery);
                        dataGridView_SV.DataSource = data;
                        dataGridView_SV.Refresh();
                    }
                    else
                    {
                        MessageBox.Show("Thêm không thành công");
                        buttonEnable();
                        RemoveEventHander();
                        removeErrorProvider();
                    }
                }
                this.dataGridView_SV.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_SV_RowHeaderMouseClick);
            }
            // Sửa sinh viên
            if (state == 1)
            {
                if (isAllValid1())
                {
                    bool isSuccess = DataAccess.UpdateSV(textBox_MaSV, textBox_HoTen, dateTimePicker_NgaySinh, gioiTinh, comboBox_QueQuan, comboBox_Lop);
                    if (isSuccess)
                    {
                        MessageBox.Show("Updated");
                        buttonEnable();
                        RemoveEventHander1();
                        removeErrorProvider();
                        DataTable data = DataAccess.SqlExecute(currentDataQuery);
                        dataGridView_SV.DataSource = data;
                        dataGridView_SV.Refresh();
                        textBox_MaSV.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Error");
                        buttonEnable();
                        RemoveEventHander1();
                        removeErrorProvider();
                        dataGridView_SV.Refresh();
                        textBox_MaSV.Enabled = true;
                    }
                }
                // Thêm sự kiện rowHeaderClick
                this.dataGridView_SV.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_SV_RowHeaderMouseClick);
            }
        }

        // Hủy thao tác
        private void button_Cancel_Click(object sender, EventArgs e)
        {
            if (state == 0)
            {
                DialogResult result = MessageBox.Show("Bạn có muốn hủy thao tác này?","", MessageBoxButtons.YesNoCancel);
                if (DialogResult.Yes == result)
                {
                    buttonEnable();
                    RemoveEventHander();
                    removeErrorProvider();
                }
            }
            if (state == 1)
            {
                DialogResult result = MessageBox.Show("Bạn có muốn hủy thao tác này?", "", MessageBoxButtons.YesNoCancel);
                if (DialogResult.Yes == result)
                {
                    textBox_MaSV.Enabled = true;
                    buttonEnable();
                    RemoveEventHander();
                    removeErrorProvider();
                    // Thêm sự kiện rowHeaderClick
                    this.dataGridView_SV.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_SV_RowHeaderMouseClick);
                }
            }
        }

        // Các hàm cho sự kiện value change để kiểm tra dữ liệu khi input
        private void textBox_MaSV_TextChanged(object sender, EventArgs e)
        {
            button_Save.Enabled = isAllValid() ? true : false;
        }
        private void textBox_HoTen_TextChanged(object sender, EventArgs e)
        {
            button_Save.Enabled = isAllValid() ? true : false;
        }
        private void textBox_HoTen_TextChanged1(object sender, EventArgs e)
        {
            button_Save.Enabled = isAllValid1() ? true : false;
        }
        private void dateTimePicker_NgaySinh_ValueChanged(object sender, EventArgs e)
        {
            button_Save.Enabled = isAllValid() ? true : false;
        }
        private void dateTimePicker_NgaySinh_ValueChanged1(object sender, EventArgs e)
        {
            button_Save.Enabled = isAllValid1() ? true : false;
        }
        private void checkBox_Nam_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Nam.Checked)
            {
                checkBox_Nu.Checked = false;
                gioiTinh = "Nam";
            }
            else
            {
                gioiTinh = "";
            }
        }

        private void checkBox_Nu_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Nu.Checked)
            {
                checkBox_Nam.Checked = false;
                gioiTinh = "Nữ";
            }
            else
            {
                gioiTinh = "";
            }
        }
        private void checkBox_Nam_CheckedChanged1(object sender, EventArgs e)
        {
            button_Save.Enabled = isAllValid() ? true : false;
        }
        private void checkBox_Nam_CheckedChanged2(object sender, EventArgs e)
        {
            button_Save.Enabled = isAllValid1() ? true : false;
        }
        private void checkBox_Nu_CheckedChanged1(object sender, EventArgs e)
        {
            button_Save.Enabled = isAllValid() ? true : false;
        }
        private void checkBox_Nu_CheckedChanged2(object sender, EventArgs e)
        {
            button_Save.Enabled = isAllValid1() ? true : false;
        }

        // Sửa thông tin sinh viên

        private void loadDataToInput()
        {
            if (!String.IsNullOrEmpty(dataGridView_SV[0, dataGridView_SV.CurrentRow.Index].Value.ToString()))
            {
                DataGridViewSelectedRowCollection rows = dataGridView_SV.SelectedRows;
                textBox_MaSV.Text = rows[0].Cells[0].Value.ToString();
                textBox_HoTen.Text = rows[0].Cells[1].Value.ToString();
                dateTimePicker_NgaySinh.Value = Convert.ToDateTime(rows[0].Cells[2].Value.ToString());
                if (rows[0].Cells[3].Value.ToString() == "Nam")
                {
                    checkBox_Nam.Checked = true;
                }
                else
                {
                    checkBox_Nu.Checked = true;
                }
                comboBox_QueQuan.Text = rows[0].Cells[4].Value.ToString();
                comboBox_Khoa.Text = rows[0].Cells[6].Value.ToString();
                comboBox_Lop.Text = rows[0].Cells[5].Value.ToString();
            }
        }
        // Hàm cho sự kiện click vào sinh viên trong dataGridView truyền dữ liệu lên input
        private void dataGridView_SV_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            loadDataToInput();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView_SV.SelectedRows.Count == 0)
            {
                MessageBox.Show("Chọn sinh viên để xóa!");
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn có muốn sinh viên này không ?", "Xác nhận xóa", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        DataAccess.SqlExecute("DELETE FROM SV where maSV = '" + textBox_MaSV.Text + "';");

                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Xóa không thành công.");
                        return;
                    }
                    MessageBox.Show("Xóa thành công.");
                    DataTable data = DataAccess.SqlExecute(currentDataQuery);
                    dataGridView_SV.DataSource = data;                  
                }
            }
        }
    }
}
