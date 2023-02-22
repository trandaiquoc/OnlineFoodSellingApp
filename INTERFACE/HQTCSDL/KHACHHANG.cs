using System.Data;
using System.Data.SqlClient;

namespace HQTCSDL
{
    public partial class KHACHHANG : Form
    {
        public static string data = string.Empty;
        SqlConnection ketnoi = new SqlConnection(data);
        SqlCommand? command = null;
        public static string matk = string.Empty;
        public KHACHHANG()
        {
            InitializeComponent();
            ketnoi.Open();
        }
        private Form? currentChildForm = null;

        private void openChildForm(Form child)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = child;
            child.TopLevel = false;
            child.FormBorderStyle = FormBorderStyle.None;
            child.Dock = DockStyle.Fill;
            panel_body.Controls.Add(child);
            panel_body.Tag = child;
            child.BringToFront();
            child.Show();
        }
        private void KHACHHANG_Load(object sender, EventArgs e)
        {
            command = new SqlCommand("SELECT MAKH FROM KHACHHANG WHERE MATK = '" + matk + "'", ketnoi);
            var n = command.ExecuteScalar();
            if (n != null)
            {
                USER.Text = n.ToString();
            }
        }

        private void button_DH_Click(object sender, EventArgs e)
        {
            KHACHHANG_DH.makh = USER.Text.ToString();
            openChildForm(new KHACHHANG_DH());
        }

        private void buttonQLDH_Click(object sender, EventArgs e)
        {
            KHACHHANG_QLDH.makh = USER.Text.ToString();
            openChildForm(new KHACHHANG_QLDH());
        }

        private void button_TK_Click(object sender, EventArgs e)
        {
            KHACHHANG_TK.makh = USER.Text.ToString();
            KHACHHANG_TK.matk = matk.ToString();
            openChildForm(new KHACHHANG_TK());
        }

        private void button_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có chắc muốn thoát chứ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button_DX_Click(object sender, EventArgs e)
        {
            this.Close();
            DANGNHAP L = new DANGNHAP();
            L.Show();
        }
    }
}

