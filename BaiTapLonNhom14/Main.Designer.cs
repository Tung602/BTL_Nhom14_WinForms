namespace BaiTapLonNhom14
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconButtonQLK = new FontAwesome.Sharp.IconButton();
            this.iconButtonQLL = new FontAwesome.Sharp.IconButton();
            this.iconButtonQLMH = new FontAwesome.Sharp.IconButton();
            this.iconButtonQLD = new FontAwesome.Sharp.IconButton();
            this.iconButtonQLSV = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panelBar = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.iconPictureBoxBarIcon = new FontAwesome.Sharp.IconPictureBox();
            this.labelBarTitle = new System.Windows.Forms.Label();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.panelBar.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxBarIcon)).BeginInit();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(340, 1529);
            this.panelMenu.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.iconButtonQLK);
            this.panel1.Controls.Add(this.iconButtonQLL);
            this.panel1.Controls.Add(this.iconButtonQLMH);
            this.panel1.Controls.Add(this.iconButtonQLD);
            this.panel1.Controls.Add(this.iconButtonQLSV);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 214);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(340, 684);
            this.panel1.TabIndex = 1;
            // 
            // iconButtonQLK
            // 
            this.iconButtonQLK.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonQLK.FlatAppearance.BorderSize = 0;
            this.iconButtonQLK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonQLK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonQLK.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButtonQLK.IconChar = FontAwesome.Sharp.IconChar.Building;
            this.iconButtonQLK.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButtonQLK.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonQLK.IconSize = 60;
            this.iconButtonQLK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonQLK.Location = new System.Drawing.Point(0, 436);
            this.iconButtonQLK.Name = "iconButtonQLK";
            this.iconButtonQLK.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.iconButtonQLK.Size = new System.Drawing.Size(340, 109);
            this.iconButtonQLK.TabIndex = 5;
            this.iconButtonQLK.Text = "Quản lý khoa";
            this.iconButtonQLK.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonQLK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonQLK.UseVisualStyleBackColor = true;
            this.iconButtonQLK.Click += new System.EventHandler(this.iconButtonQLK_Click);
            // 
            // iconButtonQLL
            // 
            this.iconButtonQLL.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonQLL.FlatAppearance.BorderSize = 0;
            this.iconButtonQLL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonQLL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonQLL.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButtonQLL.IconChar = FontAwesome.Sharp.IconChar.School;
            this.iconButtonQLL.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButtonQLL.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonQLL.IconSize = 60;
            this.iconButtonQLL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonQLL.Location = new System.Drawing.Point(0, 327);
            this.iconButtonQLL.Name = "iconButtonQLL";
            this.iconButtonQLL.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.iconButtonQLL.Size = new System.Drawing.Size(340, 109);
            this.iconButtonQLL.TabIndex = 4;
            this.iconButtonQLL.Text = "Quản lý lớp";
            this.iconButtonQLL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonQLL.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonQLL.UseVisualStyleBackColor = true;
            this.iconButtonQLL.Click += new System.EventHandler(this.iconButtonQLL_Click);
            // 
            // iconButtonQLMH
            // 
            this.iconButtonQLMH.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonQLMH.FlatAppearance.BorderSize = 0;
            this.iconButtonQLMH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonQLMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonQLMH.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButtonQLMH.IconChar = FontAwesome.Sharp.IconChar.BookOpen;
            this.iconButtonQLMH.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButtonQLMH.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonQLMH.IconSize = 60;
            this.iconButtonQLMH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonQLMH.Location = new System.Drawing.Point(0, 218);
            this.iconButtonQLMH.Name = "iconButtonQLMH";
            this.iconButtonQLMH.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.iconButtonQLMH.Size = new System.Drawing.Size(340, 109);
            this.iconButtonQLMH.TabIndex = 3;
            this.iconButtonQLMH.Text = "Quản lý môn học";
            this.iconButtonQLMH.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonQLMH.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonQLMH.UseVisualStyleBackColor = true;
            this.iconButtonQLMH.Click += new System.EventHandler(this.iconButtonQLMH_Click);
            // 
            // iconButtonQLD
            // 
            this.iconButtonQLD.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonQLD.FlatAppearance.BorderSize = 0;
            this.iconButtonQLD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonQLD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonQLD.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButtonQLD.IconChar = FontAwesome.Sharp.IconChar.PenSquare;
            this.iconButtonQLD.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButtonQLD.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonQLD.IconSize = 60;
            this.iconButtonQLD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonQLD.Location = new System.Drawing.Point(0, 109);
            this.iconButtonQLD.Name = "iconButtonQLD";
            this.iconButtonQLD.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.iconButtonQLD.Size = new System.Drawing.Size(340, 109);
            this.iconButtonQLD.TabIndex = 2;
            this.iconButtonQLD.Text = "Quản lý điểm";
            this.iconButtonQLD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonQLD.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonQLD.UseVisualStyleBackColor = true;
            this.iconButtonQLD.Click += new System.EventHandler(this.iconButtonQLD_Click);
            // 
            // iconButtonQLSV
            // 
            this.iconButtonQLSV.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonQLSV.FlatAppearance.BorderSize = 0;
            this.iconButtonQLSV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonQLSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonQLSV.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButtonQLSV.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.iconButtonQLSV.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButtonQLSV.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonQLSV.IconSize = 60;
            this.iconButtonQLSV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonQLSV.Location = new System.Drawing.Point(0, 0);
            this.iconButtonQLSV.Name = "iconButtonQLSV";
            this.iconButtonQLSV.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.iconButtonQLSV.Size = new System.Drawing.Size(340, 109);
            this.iconButtonQLSV.TabIndex = 1;
            this.iconButtonQLSV.Text = "Quản lý sinh viên";
            this.iconButtonQLSV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonQLSV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonQLSV.UseVisualStyleBackColor = true;
            this.iconButtonQLSV.Click += new System.EventHandler(this.iconButtonQLSV_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelLogo.Controls.Add(this.pictureBoxLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(340, 214);
            this.panelLogo.TabIndex = 0;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(65, 11);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(211, 156);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // panelBar
            // 
            this.panelBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(74)))));
            this.panelBar.Controls.Add(this.button1);
            this.panelBar.Controls.Add(this.panel3);
            this.panelBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBar.Location = new System.Drawing.Point(340, 0);
            this.panelBar.Name = "panelBar";
            this.panelBar.Size = new System.Drawing.Size(2194, 100);
            this.panelBar.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(25)))), ((int)(((byte)(66)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(25)))), ((int)(((byte)(66)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(25)))), ((int)(((byte)(66)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Gainsboro;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.ImageIndex = 0;
            this.button1.ImageList = this.imageList1;
            this.button1.Location = new System.Drawing.Point(1960, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(234, 52);
            this.button1.TabIndex = 3;
            this.button1.Text = "Đăng xuất";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "logout.png");
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.iconPictureBoxBarIcon);
            this.panel3.Controls.Add(this.labelBarTitle);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(454, 100);
            this.panel3.TabIndex = 2;
            // 
            // iconPictureBoxBarIcon
            // 
            this.iconPictureBoxBarIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(74)))));
            this.iconPictureBoxBarIcon.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconPictureBoxBarIcon.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconPictureBoxBarIcon.IconColor = System.Drawing.Color.Gainsboro;
            this.iconPictureBoxBarIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBoxBarIcon.IconSize = 68;
            this.iconPictureBoxBarIcon.Location = new System.Drawing.Point(47, 22);
            this.iconPictureBoxBarIcon.Name = "iconPictureBoxBarIcon";
            this.iconPictureBoxBarIcon.Size = new System.Drawing.Size(68, 68);
            this.iconPictureBoxBarIcon.TabIndex = 0;
            this.iconPictureBoxBarIcon.TabStop = false;
            // 
            // labelBarTitle
            // 
            this.labelBarTitle.AutoSize = true;
            this.labelBarTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBarTitle.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelBarTitle.Location = new System.Drawing.Point(121, 35);
            this.labelBarTitle.Name = "labelBarTitle";
            this.labelBarTitle.Size = new System.Drawing.Size(121, 29);
            this.labelBarTitle.TabIndex = 1;
            this.labelBarTitle.Text = "Trang chủ";
            this.labelBarTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelDesktop
            // 
            this.panelDesktop.Controls.Add(this.label1);
            this.panelDesktop.Controls.Add(this.pictureBox1);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(340, 100);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(2194, 1429);
            this.panelDesktop.TabIndex = 2;
            this.panelDesktop.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDesktop_Paint);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label1.Location = new System.Drawing.Point(855, 968);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(485, 73);
            this.label1.TabIndex = 2;
            this.label1.Text = "Đại học thủy lợi";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(654, 344);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(887, 583);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2534, 1529);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelBar);
            this.Controls.Add(this.panelMenu);
            this.MinimumSize = new System.Drawing.Size(1900, 1080);
            this.Name = "Main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.panelMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.panelBar.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxBarIcon)).EndInit();
            this.panelDesktop.ResumeLayout(false);
            this.panelDesktop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelBar;
        private FontAwesome.Sharp.IconPictureBox iconPictureBoxBarIcon;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelBarTitle;
        private FontAwesome.Sharp.IconButton iconButtonQLK;
        private FontAwesome.Sharp.IconButton iconButtonQLL;
        private FontAwesome.Sharp.IconButton iconButtonQLMH;
        private FontAwesome.Sharp.IconButton iconButtonQLD;
        private FontAwesome.Sharp.IconButton iconButtonQLSV;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}