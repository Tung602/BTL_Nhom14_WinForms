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
    public partial class QuanLyLop : Form
    {
        private int status;
        private bool isValidate;
        private string currentDataQuery;
        private string selectedClass;
        private DataGridViewSelectedRowCollection selectedRow;
        public QuanLyLop()
        {
            InitializeComponent();
        }

        private void QuanLyLop_Load(object sender, EventArgs e)
        {
            SetDataComboBox(comboBoxKhoa, "SELECT * FROM KHOA", "tenKhoa", "tenKhoa");
        }

        private void SetDataComboBox(ComboBox comboBox, string sqlQuery, string displayMember, string valueMember)
        {
            comboBox.DisplayMember = displayMember;
            comboBox.ValueMember = valueMember;
            comboBox.DataSource = DataAccess.SqlExecute(sqlQuery);
            comboBox.Text = "";
        }

        private bool isContainsKhoa()
        {
            DataTable row = DataAccess.SqlExecute("SELECT tenKhoa FROM KHOA WHERE tenKhoa = N'" + comboBoxKhoa.Text.Trim() + "'");
            return row.Rows.Count > 0 ? true : false;

        } 

        private void comboBoxKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "SELECT LOP.tenLop as N'Tên lớp', KHOA.tenKhoa as 'Khoa' FROM LOP INNER JOIN KHOA ON LOP.maKhoa = KHOA.maKhoa AND KHOA.tenKhoa = N'" + comboBoxKhoa.Text + "';";
            dataGridViewLop.DataSource = DataAccess.SqlExecute(sql);
            currentDataQuery = sql;
        }

        private void disableButton()
        {
            buttonADD.Enabled = false;
            buttonEDIT.Enabled = false;
            buttonDELETE.Enabled = false;
            buttonSave.Enabled = true;
            buttonCancel.Enabled = true;
        }

        private void enableButton()
        {
            buttonADD.Enabled = true;
            buttonEDIT.Enabled = true;
            buttonDELETE.Enabled = true;
            buttonSave.Enabled = false;
            buttonCancel.Enabled = false;
        }

        private void buttonADD_Click(object sender, EventArgs e)
        {
            disableButton();
            if (textBoxLop.Text == "")
            {
                labelWarning.Text = "Vui lòng điền tên lớp.";
            }
            status = 0;
            textBoxLop.TextChanged += new EventHandler(textBoxLop_TextChanged);
        }

        private void textBoxLop_TextChanged(object sender, EventArgs e)
        {
            if (textBoxLop.Text == "")
            {
                labelWarning.Text = "Vui lòng điền tên lớp.";
                isValidate = false;
            }
            else if (DataAccess.SqlExecute("SELECT * FROM LOP WHERE tenLop = '" + textBoxLop.Text + "';").Rows.Count > 0)
            {
                labelWarning.Text = "Lớp đã tồn tại.";
                isValidate = false;
            }
            else
            {
                labelWarning.Text = "";
                isValidate = true;
            }
        }

        private void textBoxLop_TextChanged1(object sender, EventArgs e)
        {
            if (textBoxLop.Text == "")
            {
                labelWarning.Text = "Vui lòng điền tên lớp.";
                buttonSave.Enabled = false;
                isValidate = false;
            }
            else if (textBoxLop.Text == selectedClass || DataAccess.SqlExecute("SELECT * FROM LOP WHERE tenLop = '" + textBoxLop.Text + "';").Rows.Count > 0)
            {
                buttonSave.Enabled = false;
                labelWarning.Text = "";
                isValidate = false;
            }
            else
            {
                buttonSave.Enabled = true;
                labelWarning.Text = "";
                isValidate = true;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (status == 0 && isValidate)
            {
                DataRowView maKhoa = (DataRowView)comboBoxKhoa.SelectedItem;
                try
                {
                    DataAccess.SqlExecute("INSERT INTO LOP VALUES('" + textBoxLop.Text + "', '" + maKhoa[0].ToString() + "');");
                }catch(Exception){
                    MessageBox.Show("Thêm không thành công!");
                    return;
                }
                MessageBox.Show("Thêm thành công.");
                DataTable data = DataAccess.SqlExecute(currentDataQuery);
                dataGridViewLop.DataSource = data;
                dataGridViewLop.Refresh();
            }
            if (status == 1 && isValidate)
            {
                DataRowView maKhoa = (DataRowView)comboBoxKhoa.SelectedItem;
                try
                {
                    DataAccess.SqlExecute("DELETE FROM LOP WHERE tenLop = '" + selectedClass + "';");
                    DataAccess.SqlExecute("INSERT INTO LOP VALUES('" + textBoxLop.Text + "', '" + maKhoa[0].ToString() + "');");
                }
                catch (Exception)
                {
                    MessageBox.Show("Sửa không thành công!");
                    return;
                }
                MessageBox.Show("Sửa thành công.");
                DataTable data = DataAccess.SqlExecute(currentDataQuery);
                dataGridViewLop.DataSource = data;
                dataGridViewLop.Refresh();
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            if (status == 0)
            {
                enableButton();
                textBoxLop.Text = "";
                labelWarning.Text = "";
                textBoxLop.TextChanged -= textBoxLop_TextChanged;
            }
            if (status == 1)
            {
                enableButton();
                labelWarning.Text = "";
                textBoxLop.TextChanged -= textBoxLop_TextChanged1;
            }
        }

        private void dataGridViewLop_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (!String.IsNullOrEmpty(dataGridViewLop[0,dataGridViewLop.CurrentRow.Index].Value.ToString()))
            {
                selectedRow = dataGridViewLop.SelectedRows;
                comboBoxKhoa.SelectedValue = selectedRow[0].Cells[1].Value.ToString();
                textBoxLop.Text = selectedRow[0].Cells[0].Value.ToString();
            }
        }

        private void buttonEDIT_Click(object sender, EventArgs e)
        {
            if (dataGridViewLop.SelectedRows.Count == 0)
            {
                MessageBox.Show("Chọn lớp để chỉnh sửa!");
            }
            else
            {
                isValidate = false;
                disableButton();
                status = 1;
                selectedClass = dataGridViewLop.SelectedRows[0].Cells[0].Value.ToString();
                comboBoxKhoa.Enabled = false;
                buttonSave.Enabled = false;
                textBoxLop.TextChanged += new EventHandler(textBoxLop_TextChanged1);
            }
        }

        private void buttonDELETE_Click(object sender, EventArgs e)
        {
            if (dataGridViewLop.SelectedRows.Count == 0)
            {
                MessageBox.Show("Chọn lớp để xóa!");
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn có muốn xóa lớp " + textBoxLop.Text + " không ?", "Xác nhận xóa", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        DataAccess.SqlExecute("DELETE FROM LOP WHERE tenLop = '" + textBoxLop.Text + "';");
                        
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Xóa không thành công.");
                        return;
                    }
                    MessageBox.Show("Xóa lớp thành công.");
                    DataTable data = DataAccess.SqlExecute(currentDataQuery);
                    dataGridViewLop.DataSource = data;
                    dataGridViewLop.Refresh();
                }
            }
        }
    }
}
