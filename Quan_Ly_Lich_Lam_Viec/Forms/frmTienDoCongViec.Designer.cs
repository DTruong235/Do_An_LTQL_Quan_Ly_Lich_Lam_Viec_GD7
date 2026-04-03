namespace Quan_Ly_Lich_Lam_Viec.Forms
{
    partial class frmTienDoCongViec
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            groupBox1 = new GroupBox();
            txtGhiChu = new TextBox();
            btnThoat = new Button();
            btnHuyBo = new Button();
            btnXoa = new Button();
            btnLuu = new Button();
            btnSua = new Button();
            btnThem = new Button();
            lblTrangThai = new Label();
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            progressBar = new ProgressBar();
            cboTenLich = new ComboBox();
            groupBox2 = new GroupBox();
            dataGridView = new DataGridView();
            MaTienDo = new DataGridViewTextBoxColumn();
            MaLich = new DataGridViewTextBoxColumn();
            PhanTramHoanThanh = new DataGridViewTextBoxColumn();
            GhiChu = new DataGridViewTextBoxColumn();
            NgayCapNhat = new DataGridViewTextBoxColumn();
            checkedListBox = new CheckedListBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtGhiChu);
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(btnHuyBo);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(lblTrangThai);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(progressBar);
            groupBox1.Controls.Add(cboTenLich);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(982, 173);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin công việc";
            // 
            // txtGhiChu
            // 
            txtGhiChu.Location = new Point(156, 126);
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new Size(411, 27);
            txtGhiChu.TabIndex = 21;
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Segoe UI", 10.2F);
            btnThoat.Location = new Point(831, 121);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(106, 35);
            btnThoat.TabIndex = 15;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnHuyBo
            // 
            btnHuyBo.Font = new Font("Segoe UI", 10.2F);
            btnHuyBo.Location = new Point(713, 121);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(106, 35);
            btnHuyBo.TabIndex = 16;
            btnHuyBo.Text = "Hủy bỏ";
            btnHuyBo.UseVisualStyleBackColor = true;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Segoe UI", 10.2F);
            btnXoa.ForeColor = Color.Red;
            btnXoa.Location = new Point(831, 71);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(106, 35);
            btnXoa.TabIndex = 17;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnLuu
            // 
            btnLuu.Font = new Font("Segoe UI", 10.2F);
            btnLuu.ForeColor = Color.FromArgb(0, 192, 0);
            btnLuu.Location = new Point(713, 71);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(106, 35);
            btnLuu.TabIndex = 18;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click_1;
            // 
            // btnSua
            // 
            btnSua.Font = new Font("Segoe UI", 10.2F);
            btnSua.Location = new Point(597, 121);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(106, 35);
            btnSua.TabIndex = 19;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Segoe UI", 10.2F);
            btnThem.Location = new Point(597, 71);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(106, 35);
            btnThem.TabIndex = 20;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // lblTrangThai
            // 
            lblTrangThai.AutoSize = true;
            lblTrangThai.Location = new Point(393, 38);
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(84, 20);
            lblTrangThai.TabIndex = 3;
            lblTrangThai.Text = "Trạng thái...";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(325, 38);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 2;
            label2.Text = "Tiến độ:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 129);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 2;
            label3.Text = "Ghi chú: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 40);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 2;
            label1.Text = "Tên lịch:";
            // 
            // progressBar
            // 
            progressBar.Location = new Point(325, 69);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(242, 29);
            progressBar.TabIndex = 1;
            // 
            // cboTenLich
            // 
            cboTenLich.FormattingEnabled = true;
            cboTenLich.Location = new Point(50, 69);
            cboTenLich.Name = "cboTenLich";
            cboTenLich.Size = new Size(242, 28);
            cboTenLich.TabIndex = 0;
            cboTenLich.SelectedIndexChanged += cboTenLich_SelectedIndexChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView);
            groupBox2.Controls.Add(checkedListBox);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 173);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(982, 277);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách công việc";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { MaTienDo, MaLich, PhanTramHoanThanh, GhiChu, NgayCapNhat });
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(276, 23);
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(703, 251);
            dataGridView.TabIndex = 1;
            dataGridView.CellFormatting += dataGridView_CellFormatting;
            dataGridView.SelectionChanged += dataGridView_SelectionChanged;
            // 
            // MaTienDo
            // 
            MaTienDo.DataPropertyName = "MaTienDo";
            MaTienDo.FillWeight = 40.70932F;
            MaTienDo.HeaderText = "Mã tiến độ";
            MaTienDo.MinimumWidth = 6;
            MaTienDo.Name = "MaTienDo";
            MaTienDo.ReadOnly = true;
            // 
            // MaLich
            // 
            MaLich.DataPropertyName = "MaLich";
            MaLich.FillWeight = 91.23346F;
            MaLich.HeaderText = "Tên lịch";
            MaLich.MinimumWidth = 6;
            MaLich.Name = "MaLich";
            MaLich.ReadOnly = true;
            // 
            // PhanTramHoanThanh
            // 
            PhanTramHoanThanh.DataPropertyName = "PhanTramHoanThanh";
            PhanTramHoanThanh.FillWeight = 89.0347443F;
            PhanTramHoanThanh.HeaderText = "Phần trăm hoàn thành";
            PhanTramHoanThanh.MinimumWidth = 6;
            PhanTramHoanThanh.Name = "PhanTramHoanThanh";
            PhanTramHoanThanh.ReadOnly = true;
            // 
            // GhiChu
            // 
            GhiChu.DataPropertyName = "GhiChu";
            GhiChu.FillWeight = 172.070572F;
            GhiChu.HeaderText = "Ghi chú";
            GhiChu.MinimumWidth = 6;
            GhiChu.Name = "GhiChu";
            GhiChu.ReadOnly = true;
            // 
            // NgayCapNhat
            // 
            NgayCapNhat.DataPropertyName = "NgayCapNhat";
            NgayCapNhat.FillWeight = 106.951859F;
            NgayCapNhat.HeaderText = "Ngày cập nhật";
            NgayCapNhat.MinimumWidth = 6;
            NgayCapNhat.Name = "NgayCapNhat";
            NgayCapNhat.ReadOnly = true;
            // 
            // checkedListBox
            // 
            checkedListBox.Dock = DockStyle.Left;
            checkedListBox.FormattingEnabled = true;
            checkedListBox.Location = new Point(3, 23);
            checkedListBox.Name = "checkedListBox";
            checkedListBox.Size = new Size(273, 251);
            checkedListBox.TabIndex = 0;
            checkedListBox.ItemCheck += checkedListBox_ItemCheck;
            // 
            // frmTienDoCongViec
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmTienDoCongViec";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tiến độ công việc";
            Load += frmTienDoCongViec_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ProgressBar progressBar;
        private ComboBox cboTenLich;
        private GroupBox groupBox2;
        private Label lblTrangThai;
        private Label label2;
        private Label label1;
        private CheckedListBox checkedListBox;
        private DataGridView dataGridView;
        private Button btnThoat;
        private Button btnHuyBo;
        private Button btnXoa;
        private Button btnLuu;
        private Button btnSua;
        private Button btnThem;
        private TextBox txtGhiChu;
        private Label label3;
        private DataGridViewTextBoxColumn MaTienDo;
        private DataGridViewTextBoxColumn MaLich;
        private DataGridViewTextBoxColumn PhanTramHoanThanh;
        private DataGridViewTextBoxColumn GhiChu;
        private DataGridViewTextBoxColumn NgayCapNhat;
    }
}