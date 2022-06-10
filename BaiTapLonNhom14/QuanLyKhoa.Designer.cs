namespace BaiTapLonNhom14
{
    partial class QuanLyKhoa
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTenKhoa = new System.Windows.Forms.TextBox();
            this.dataGridViewKhoa = new System.Windows.Forms.DataGridView();
            this.buttonThem = new System.Windows.Forms.Button();
            this.buttonSua = new System.Windows.Forms.Button();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxMaKhoa = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKhoa)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(297, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên khoa";
            // 
            // textBoxTenKhoa
            // 
            this.textBoxTenKhoa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxTenKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTenKhoa.Location = new System.Drawing.Point(433, 162);
            this.textBoxTenKhoa.Name = "textBoxTenKhoa";
            this.textBoxTenKhoa.Size = new System.Drawing.Size(394, 67);
            this.textBoxTenKhoa.TabIndex = 1;
            // 
            // dataGridViewKhoa
            // 
            this.dataGridViewKhoa.AllowUserToAddRows = false;
            this.dataGridViewKhoa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewKhoa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewKhoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKhoa.Location = new System.Drawing.Point(15, 380);
            this.dataGridViewKhoa.Name = "dataGridViewKhoa";
            this.dataGridViewKhoa.RowTemplate.Height = 33;
            this.dataGridViewKhoa.Size = new System.Drawing.Size(1098, 486);
            this.dataGridViewKhoa.TabIndex = 2;
            this.dataGridViewKhoa.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewKhoa_RowHeaderMouseClick);
            // 
            // buttonThem
            // 
            this.buttonThem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonThem.Location = new System.Drawing.Point(301, 267);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(146, 71);
            this.buttonThem.TabIndex = 3;
            this.buttonThem.Text = "Thêm ";
            this.buttonThem.UseVisualStyleBackColor = true;
            this.buttonThem.Click += new System.EventHandler(this.buttonThem_Click);
            // 
            // buttonSua
            // 
            this.buttonSua.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonSua.Location = new System.Drawing.Point(489, 267);
            this.buttonSua.Name = "buttonSua";
            this.buttonSua.Size = new System.Drawing.Size(146, 71);
            this.buttonSua.TabIndex = 3;
            this.buttonSua.Text = "Sửa";
            this.buttonSua.UseVisualStyleBackColor = true;
            this.buttonSua.Click += new System.EventHandler(this.buttonSua_Click);
            // 
            // buttonXoa
            // 
            this.buttonXoa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonXoa.Location = new System.Drawing.Point(677, 267);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(146, 71);
            this.buttonXoa.TabIndex = 3;
            this.buttonXoa.Text = "Xóa";
            this.buttonXoa.UseVisualStyleBackColor = true;
            this.buttonXoa.Click += new System.EventHandler(this.buttonXoa_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(297, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã khoa";
            // 
            // textBoxMaKhoa
            // 
            this.textBoxMaKhoa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxMaKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMaKhoa.Location = new System.Drawing.Point(433, 93);
            this.textBoxMaKhoa.Name = "textBoxMaKhoa";
            this.textBoxMaKhoa.Size = new System.Drawing.Size(394, 67);
            this.textBoxMaKhoa.TabIndex = 1;
            // 
            // QuanLyKhoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 878);
            this.Controls.Add(this.buttonXoa);
            this.Controls.Add(this.buttonSua);
            this.Controls.Add(this.buttonThem);
            this.Controls.Add(this.dataGridViewKhoa);
            this.Controls.Add(this.textBoxMaKhoa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxTenKhoa);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "QuanLyKhoa";
            this.Text = "QuanLyKhoa";
            this.Load += new System.EventHandler(this.QuanLyKhoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKhoa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTenKhoa;
        private System.Windows.Forms.DataGridView dataGridViewKhoa;
        private System.Windows.Forms.Button buttonThem;
        private System.Windows.Forms.Button buttonSua;
        private System.Windows.Forms.Button buttonXoa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxMaKhoa;
    }
}