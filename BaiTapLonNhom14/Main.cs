using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace BaiTapLonNhom14
{
    public partial class Main : Form
    {
        private IconButton currentButton;
        private Panel BorderButton;
        private Form CurrentChildForm;
        QLSV FormQLSV;
        QuanLyLop FormQuanLyLop;
        QuanLyMonHoc FormQuanLyMonHoc;
        QuanLyKhoa FormQuanLyKhoa;
        QuanLyDiem FormQuanLyDiem;
        dangNhap FormDangNhap;
        public Main(dangNhap login)
        {
            FormDangNhap = login;
            InitializeComponent();
            BorderButton = new Panel();
            currentButton = new IconButton();
            BorderButton.Size = new Size(7, iconButtonQLD.Size.Height);
            panelMenu.Controls.Add(BorderButton);
        }
        private void OpenChildForm(Form childForm)
        {
            if (CurrentChildForm != null)
            {
                CurrentChildForm.Hide();
            }
            CurrentChildForm = childForm;
            CurrentChildForm.TopLevel = false;
            CurrentChildForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            CurrentChildForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(CurrentChildForm);
            CurrentChildForm.BringToFront();
            CurrentChildForm.Show();
        }
        private void ActivateButton(object sender)
        {
            InactivateButton();
            // Chỉnh màu menu button khi click chuột
            currentButton = (IconButton)sender;
            currentButton.BackColor = Color.FromArgb(35, 36, 81);
            currentButton.ForeColor = Color.MediumPurple;
            currentButton.IconColor = Color.MediumPurple;
            // Thêm left border cho button
            BorderButton.BackColor = Color.MediumPurple;
            BorderButton.Location = new Point(0, currentButton.Location.Y + panelLogo.Size.Height);
            BorderButton.Visible = true;
            BorderButton.BringToFront();
            // Thay đổi bar icon 
            iconPictureBoxBarIcon.IconChar = currentButton.IconChar;
            labelBarTitle.Text = currentButton.Text;
        }
        private void InactivateButton()
        {
            // Reset màu button khi out click
            currentButton.BackColor = Color.FromArgb(31, 30, 68);
            currentButton.ForeColor = Color.Gainsboro;
            currentButton.IconColor = Color.Gainsboro;
        }

        private void iconButtonTrangChu_Click(object sender, EventArgs e)
        {

        }

        private void iconButtonQLSV_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            if (FormQLSV == null)
            {
                FormQLSV = new QLSV();
            }
            OpenChildForm(FormQLSV);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panelDesktop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButtonQLL_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            if (FormQuanLyLop == null)
            {
                FormQuanLyLop = new QuanLyLop();
            }
            OpenChildForm(FormQuanLyLop);
        }

        private void iconButtonQLMH_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            if (FormQuanLyMonHoc == null)
            {
                FormQuanLyMonHoc = new QuanLyMonHoc();
            }
            OpenChildForm(FormQuanLyMonHoc);
        }

        private void iconButtonQLK_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            if (FormQuanLyKhoa == null)
            {
                FormQuanLyKhoa = new QuanLyKhoa();
            }
            OpenChildForm(FormQuanLyKhoa);
        }

        private void iconButtonQLD_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            if (FormQuanLyDiem == null)
            {
                FormQuanLyDiem = new QuanLyDiem();
            }
            OpenChildForm(FormQuanLyDiem);
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn đăng xuất?", "Sign Out", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                FormDangNhap.Show();
                this.Hide();
            }
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Do you really want to exit?", "Exit?", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Environment.Exit(0);
                }
                else
                {
                    e.Cancel = true;
                }
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
