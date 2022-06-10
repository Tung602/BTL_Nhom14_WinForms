namespace BaiTapLonNhom14
{
    partial class QuanLyMonHoc
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
            this.labelKhoa = new System.Windows.Forms.Label();
            this.comboBoxKhoa = new System.Windows.Forms.ComboBox();
            this.textBoxMaMonHoc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxTenMonHoc = new System.Windows.Forms.TextBox();
            this.dataGridViewMonHoc = new System.Windows.Forms.DataGridView();
            this.buttonThem = new System.Windows.Forms.Button();
            this.buttonSua = new System.Windows.Forms.Button();
            this.buttonXoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMonHoc)).BeginInit();
            this.SuspendLayout();
            // 
            // labelKhoa
            // 
            this.labelKhoa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelKhoa.AutoSize = true;
            this.labelKhoa.Location = new System.Drawing.Point(343, 42);
            this.labelKhoa.Name = "labelKhoa";
            this.labelKhoa.Size = new System.Drawing.Size(69, 29);
            this.labelKhoa.TabIndex = 0;
            this.labelKhoa.Text = "Khoa";
            // 
            // comboBoxKhoa
            // 
            this.comboBoxKhoa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBoxKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxKhoa.FormattingEnabled = true;
            this.comboBoxKhoa.Location = new System.Drawing.Point(428, 42);
            this.comboBoxKhoa.Name = "comboBoxKhoa";
            this.comboBoxKhoa.Size = new System.Drawing.Size(392, 69);
            this.comboBoxKhoa.TabIndex = 1;
            this.comboBoxKhoa.SelectedIndexChanged += new System.EventHandler(this.comboBoxKhoa_SelectedIndexChanged);
            // 
            // textBoxMaMonHoc
            // 
            this.textBoxMaMonHoc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxMaMonHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMaMonHoc.Location = new System.Drawing.Point(428, 115);
            this.textBoxMaMonHoc.Name = "textBoxMaMonHoc";
            this.textBoxMaMonHoc.Size = new System.Drawing.Size(392, 67);
            this.textBoxMaMonHoc.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(268, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã môn học";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(258, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên môn học";
            // 
            // textBoxTenMonHoc
            // 
            this.textBoxTenMonHoc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxTenMonHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTenMonHoc.Location = new System.Drawing.Point(428, 186);
            this.textBoxTenMonHoc.Name = "textBoxTenMonHoc";
            this.textBoxTenMonHoc.Size = new System.Drawing.Size(392, 67);
            this.textBoxTenMonHoc.TabIndex = 2;
            // 
            // dataGridViewMonHoc
            // 
            this.dataGridViewMonHoc.AllowUserToAddRows = false;
            this.dataGridViewMonHoc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewMonHoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMonHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMonHoc.Location = new System.Drawing.Point(12, 368);
            this.dataGridViewMonHoc.Name = "dataGridViewMonHoc";
            this.dataGridViewMonHoc.RowTemplate.Height = 33;
            this.dataGridViewMonHoc.Size = new System.Drawing.Size(1134, 542);
            this.dataGridViewMonHoc.TabIndex = 4;
            this.dataGridViewMonHoc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMonHoc_CellContentClick);
            this.dataGridViewMonHoc.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewMonHoc_RowHeaderMouseClick);
            // 
            // buttonThem
            // 
            this.buttonThem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonThem.Location = new System.Drawing.Point(389, 272);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(119, 47);
            this.buttonThem.TabIndex = 5;
            this.buttonThem.Text = "Thêm";
            this.buttonThem.UseVisualStyleBackColor = true;
            this.buttonThem.Click += new System.EventHandler(this.buttonThem_Click);
            // 
            // buttonSua
            // 
            this.buttonSua.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonSua.Location = new System.Drawing.Point(520, 272);
            this.buttonSua.Name = "buttonSua";
            this.buttonSua.Size = new System.Drawing.Size(119, 47);
            this.buttonSua.TabIndex = 5;
            this.buttonSua.Text = "Sửa";
            this.buttonSua.UseVisualStyleBackColor = true;
            this.buttonSua.Click += new System.EventHandler(this.buttonSua_Click);
            // 
            // buttonXoa
            // 
            this.buttonXoa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonXoa.Location = new System.Drawing.Point(651, 272);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(119, 47);
            this.buttonXoa.TabIndex = 5;
            this.buttonXoa.Text = "Xóa";
            this.buttonXoa.UseVisualStyleBackColor = true;
            this.buttonXoa.Click += new System.EventHandler(this.buttonXoa_Click);
            // 
            // QuanLyMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 922);
            this.Controls.Add(this.buttonXoa);
            this.Controls.Add(this.buttonSua);
            this.Controls.Add(this.buttonThem);
            this.Controls.Add(this.dataGridViewMonHoc);
            this.Controls.Add(this.textBoxTenMonHoc);
            this.Controls.Add(this.textBoxMaMonHoc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxKhoa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelKhoa);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "QuanLyMonHoc";
            this.Text = "QuanLyMonHoc";
            this.Load += new System.EventHandler(this.QuanLyMonHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMonHoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelKhoa;
        private System.Windows.Forms.ComboBox comboBoxKhoa;
        private System.Windows.Forms.TextBox textBoxMaMonHoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxTenMonHoc;
        private System.Windows.Forms.DataGridView dataGridViewMonHoc;
        private System.Windows.Forms.Button buttonThem;
        private System.Windows.Forms.Button buttonSua;
        private System.Windows.Forms.Button buttonXoa;
    }
}