namespace BaiTapLonNhom14
{
    partial class dangNhap
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
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPassWord = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_SignIn = new System.Windows.Forms.Button();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUserName.Location = new System.Drawing.Point(345, 79);
            this.textBoxUserName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(380, 67);
            this.textBoxUserName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 83);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên đăng nhập";
            // 
            // textBoxPassWord
            // 
            this.textBoxPassWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassWord.Location = new System.Drawing.Point(345, 188);
            this.textBoxPassWord.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxPassWord.Name = "textBoxPassWord";
            this.textBoxPassWord.PasswordChar = '●';
            this.textBoxPassWord.Size = new System.Drawing.Size(380, 67);
            this.textBoxPassWord.TabIndex = 1;
            this.textBoxPassWord.Click += new System.EventHandler(this.textBoxPassWord_Enter);
            this.textBoxPassWord.Enter += new System.EventHandler(this.textBoxPassWord_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 192);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu";
            // 
            // button_SignIn
            // 
            this.button_SignIn.Location = new System.Drawing.Point(328, 303);
            this.button_SignIn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_SignIn.Name = "button_SignIn";
            this.button_SignIn.Size = new System.Drawing.Size(199, 71);
            this.button_SignIn.TabIndex = 2;
            this.button_SignIn.Text = "Đăng nhập";
            this.button_SignIn.UseVisualStyleBackColor = true;
            this.button_SignIn.Click += new System.EventHandler(this.button_SignIn_Click);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 40;
            this.iconPictureBox1.Location = new System.Drawing.Point(39, 273);
            this.iconPictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(43, 40);
            this.iconPictureBox1.TabIndex = 3;
            this.iconPictureBox1.TabStop = false;
            // 
            // dangNhap
            // 
            this.AcceptButton = this.button_SignIn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 413);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.button_SignIn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPassWord);
            this.Controls.Add(this.textBoxUserName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "dangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.dangNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPassWord;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_SignIn;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
    }
}