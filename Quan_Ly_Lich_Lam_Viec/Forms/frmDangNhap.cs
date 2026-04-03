using Quan_Ly_Lich_Lam_Viec.Data;

namespace Quan_Ly_Lich_Lam_Viec.Forms
{
    public partial class frmDangNhap : Form
    {
        Quan_Li_Lich_Lam_DbContext context = new Quan_Li_Lich_Lam_DbContext();
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void txtMatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDangNhap_Click(sender, e);
            }
        }

        public string TenDangNhap
        {
            get { return txtTenDangNhap.Text.Trim(); }
        }

        public string MatKhau
        {
            get { return txtMatKhau.Text.Trim(); }
        }

    }
}
