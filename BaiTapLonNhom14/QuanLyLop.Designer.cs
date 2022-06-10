namespace BaiTapLonNhom14
{
    partial class QuanLyLop
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
            this.comboBoxKhoa = new System.Windows.Forms.ComboBox();
            this.buttonADD = new System.Windows.Forms.Button();
            this.buttonEDIT = new System.Windows.Forms.Button();
            this.buttonDELETE = new System.Windows.Forms.Button();
            this.dataGridViewLop = new System.Windows.Forms.DataGridView();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxLop = new System.Windows.Forms.TextBox();
            this.labelWarning = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLop)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(457, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Khoa";
            // 
            // comboBoxKhoa
            // 
            this.comboBoxKhoa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBoxKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxKhoa.FormattingEnabled = true;
            this.comboBoxKhoa.Location = new System.Drawing.Point(592, 53);
            this.comboBoxKhoa.Name = "comboBoxKhoa";
            this.comboBoxKhoa.Size = new System.Drawing.Size(322, 69);
            this.comboBoxKhoa.TabIndex = 2;
            this.comboBoxKhoa.SelectedIndexChanged += new System.EventHandler(this.comboBoxKhoa_SelectedIndexChanged);
            // 
            // buttonADD
            // 
            this.buttonADD.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonADD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonADD.Location = new System.Drawing.Point(426, 202);
            this.buttonADD.Name = "buttonADD";
            this.buttonADD.Size = new System.Drawing.Size(148, 64);
            this.buttonADD.TabIndex = 3;
            this.buttonADD.Text = "Thêm";
            this.buttonADD.UseVisualStyleBackColor = true;
            this.buttonADD.Click += new System.EventHandler(this.buttonADD_Click);
            // 
            // buttonEDIT
            // 
            this.buttonEDIT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonEDIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEDIT.Location = new System.Drawing.Point(615, 201);
            this.buttonEDIT.Name = "buttonEDIT";
            this.buttonEDIT.Size = new System.Drawing.Size(148, 64);
            this.buttonEDIT.TabIndex = 3;
            this.buttonEDIT.Text = "Sửa";
            this.buttonEDIT.UseVisualStyleBackColor = true;
            this.buttonEDIT.Click += new System.EventHandler(this.buttonEDIT_Click);
            // 
            // buttonDELETE
            // 
            this.buttonDELETE.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonDELETE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDELETE.Location = new System.Drawing.Point(797, 201);
            this.buttonDELETE.Name = "buttonDELETE";
            this.buttonDELETE.Size = new System.Drawing.Size(148, 64);
            this.buttonDELETE.TabIndex = 3;
            this.buttonDELETE.Text = "Xóa";
            this.buttonDELETE.UseVisualStyleBackColor = true;
            this.buttonDELETE.Click += new System.EventHandler(this.buttonDELETE_Click);
            // 
            // dataGridViewLop
            // 
            this.dataGridViewLop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewLop.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLop.Location = new System.Drawing.Point(14, 294);
            this.dataGridViewLop.Name = "dataGridViewLop";
            this.dataGridViewLop.RowTemplate.Height = 33;
            this.dataGridViewLop.Size = new System.Drawing.Size(1342, 431);
            this.dataGridViewLop.TabIndex = 4;
            this.dataGridViewLop.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewLop_RowHeaderMouseClick);
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.Enabled = false;
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.Location = new System.Drawing.Point(1080, 761);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(134, 50);
            this.buttonSave.TabIndex = 5;
            this.buttonSave.Text = "Lưu";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.Enabled = false;
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(1221, 761);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(134, 50);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Hủy";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(462, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Lớp";
            // 
            // textBoxLop
            // 
            this.textBoxLop.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLop.Location = new System.Drawing.Point(592, 129);
            this.textBoxLop.Name = "textBoxLop";
            this.textBoxLop.Size = new System.Drawing.Size(322, 67);
            this.textBoxLop.TabIndex = 7;
            // 
            // labelWarning
            // 
            this.labelWarning.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelWarning.AutoSize = true;
            this.labelWarning.ForeColor = System.Drawing.Color.Red;
            this.labelWarning.Location = new System.Drawing.Point(587, 166);
            this.labelWarning.Name = "labelWarning";
            this.labelWarning.Size = new System.Drawing.Size(0, 29);
            this.labelWarning.TabIndex = 6;
            // 
            // QuanLyLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 825);
            this.Controls.Add(this.textBoxLop);
            this.Controls.Add(this.labelWarning);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.dataGridViewLop);
            this.Controls.Add(this.buttonDELETE);
            this.Controls.Add(this.buttonEDIT);
            this.Controls.Add(this.buttonADD);
            this.Controls.Add(this.comboBoxKhoa);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "QuanLyLop";
            this.Text = "QuanLyLop";
            this.Load += new System.EventHandler(this.QuanLyLop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxKhoa;
        private System.Windows.Forms.Button buttonADD;
        private System.Windows.Forms.Button buttonEDIT;
        private System.Windows.Forms.Button buttonDELETE;
        private System.Windows.Forms.DataGridView dataGridViewLop;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxLop;
        private System.Windows.Forms.Label labelWarning;
    }
}