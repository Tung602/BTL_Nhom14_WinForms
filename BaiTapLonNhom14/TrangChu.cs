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
    public partial class TrangChu : Form
    {
        private IconButton currentButton;
        private Panel BorderButton;
        private Form CurrentChildForm;
        QLSV FormQLSV;
        public TrangChu()
        {
            InitializeComponent();
            BorderButton = new Panel();
            BorderButton.Size = new Size(8, 109);
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
            BorderButton.Location = new Point(0, currentButton.Location.Y + 178);
            BorderButton.Visible = true;
            BorderButton.BringToFront();
            // Thay đổi bar icon 
            iconPictureBoxBarIcon.IconChar = currentButton.IconChar;
            labelBarTitle.Text = currentButton.Text;
        }
        private void ActivateDefaultButton()
        {
            currentButton = iconButtonTrangChu;
            currentButton.BackColor = Color.FromArgb(35, 36, 81);
            currentButton.ForeColor = Color.MediumPurple;
            currentButton.IconColor = Color.MediumPurple;
            // Thêm left border cho button
            BorderButton.BackColor = Color.MediumPurple;
            BorderButton.Location = new Point(0, currentButton.Location.Y + 178);
            BorderButton.Visible = true;
            BorderButton.BringToFront();
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
            ActivateButton(sender);
        }

        private void TrangChu_Load(object sender, EventArgs e)
        {
            ActivateDefaultButton();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ActivateButton(iconButtonTrangChu);
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

    }
}
