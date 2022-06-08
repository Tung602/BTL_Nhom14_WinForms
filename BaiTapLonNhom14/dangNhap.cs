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
    public partial class dangNhap : Form
    {
        public dangNhap()
        {
            InitializeComponent();
        }

        private void button_SignIn_Click(object sender, EventArgs e)
        {
            DataTable data = DataAccess.SqlExecute("SELECT * FROM ACCOUNT WHERE userName = '" + this.textBoxUserName.Text + "' AND passWord = '" + this.textBoxPassWord.Text + "';");
            if (data.Rows.Count == 0)
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng.");
            }
            else
            {
                QLSV QLSV = new QLSV();
                MessageBox.Show("Đăng nhập thành công.");
                this.Hide();
                QLSV.Show();
            }
        }

        private void textBoxPassWord_Enter(object sender, EventArgs e)
        {
            textBoxPassWord.SelectionStart = 0;
            textBoxPassWord.SelectionLength = textBoxPassWord.Text.Length;
        }


    }
}
