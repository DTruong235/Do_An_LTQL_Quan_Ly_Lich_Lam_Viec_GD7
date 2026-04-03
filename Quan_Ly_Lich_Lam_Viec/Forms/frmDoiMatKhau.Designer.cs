namespace Quan_Ly_Lich_Lam_Viec.Forms
{
    partial class frmDoiMatKhau
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
            btnHuyBo = new Button();
            btnDoiMatKhau = new Button();
            txtMatKhauMoi = new TextBox();
            txtMatKhauCu = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            txtXacNhanMatKhau = new TextBox();
            SuspendLayout();
            // 
            // btnHuyBo
            // 
            btnHuyBo.Location = new Point(172, 273);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(106, 29);
            btnHuyBo.TabIndex = 8;
            btnHuyBo.Text = "Hủy bỏ";
            btnHuyBo.UseVisualStyleBackColor = true;
            // 
            // btnDoiMatKhau
            // 
            btnDoiMatKhau.Location = new Point(43, 273);
            btnDoiMatKhau.Name = "btnDoiMatKhau";
            btnDoiMatKhau.Size = new Size(110, 29);
            btnDoiMatKhau.TabIndex = 9;
            btnDoiMatKhau.Text = "Đổi mật khẩu";
            btnDoiMatKhau.UseVisualStyleBackColor = true;
            btnDoiMatKhau.Click += btnDoiMatKhau_Click;
            // 
            // txtMatKhauMoi
            // 
            txtMatKhauMoi.Location = new Point(43, 162);
            txtMatKhauMoi.Name = "txtMatKhauMoi";
            txtMatKhauMoi.Size = new Size(235, 27);
            txtMatKhauMoi.TabIndex = 6;
            txtMatKhauMoi.UseSystemPasswordChar = true;
            // 
            // txtMatKhauCu
            // 
            txtMatKhauCu.Location = new Point(43, 96);
            txtMatKhauCu.Name = "txtMatKhauCu";
            txtMatKhauCu.Size = new Size(235, 27);
            txtMatKhauCu.TabIndex = 7;
            txtMatKhauCu.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 139);
            label3.Name = "label3";
            label3.Size = new Size(103, 20);
            label3.TabIndex = 4;
            label3.Text = "Mật khẩu mới:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 73);
            label2.Name = "label2";
            label2.Size = new Size(92, 20);
            label2.TabIndex = 5;
            label2.Text = "Mật khẩu cũ:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(52, 29);
            label1.Name = "label1";
            label1.Size = new Size(226, 38);
            label1.TabIndex = 10;
            label1.Text = "ĐỔI MẬT KHẨU";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(43, 204);
            label4.Name = "label4";
            label4.Size = new Size(167, 20);
            label4.TabIndex = 4;
            label4.Text = "Xác nhận mật khẩu mới:";
            // 
            // txtXacNhanMatKhau
            // 
            txtXacNhanMatKhau.Location = new Point(43, 227);
            txtXacNhanMatKhau.Name = "txtXacNhanMatKhau";
            txtXacNhanMatKhau.Size = new Size(235, 27);
            txtXacNhanMatKhau.TabIndex = 6;
            txtXacNhanMatKhau.UseSystemPasswordChar = true;
            // 
            // frmDoiMatKhau
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(325, 323);
            Controls.Add(label1);
            Controls.Add(btnHuyBo);
            Controls.Add(btnDoiMatKhau);
            Controls.Add(txtXacNhanMatKhau);
            Controls.Add(txtMatKhauMoi);
            Controls.Add(label4);
            Controls.Add(txtMatKhauCu);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "frmDoiMatKhau";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đổi mật khẩu";
            Load += frmDoiMatKhau_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnHuyBo;
        private Button btnDoiMatKhau;
        private TextBox txtMatKhauMoi;
        private TextBox txtMatKhauCu;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private TextBox txtXacNhanMatKhau;
    }
}