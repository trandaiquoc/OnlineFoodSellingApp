using Microsoft.VisualBasic.ApplicationServices;
using System.Data;
using System.Data.SqlClient;

namespace HQTCSDL
{
    public partial class NHANVIEN : Form
    {
        public static string data = string.Empty;
        SqlConnection ketnoi = new SqlConnection(data);
        SqlCommand? command = null;
        public static string matk = string.Empty;
        public NHANVIEN()
        {
            InitializeComponent();
            ketnoi.Open();
        }
        private Form currentChildForm;

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

        private void buttonHDDD_Click(object sender, EventArgs e)
        {
            NHANVIEN_HDDD.manv = USER.Text.ToString();
            openChildForm(new NHANVIEN_HDDD());
        }

        private void buttonHDCD_Click(object sender, EventArgs e)
        {
            NHANVIEN_HDCD.manv = USER.Text.ToString();
            openChildForm(new NHANVIEN_HDCD());
        }

        private void buttonTK_Click(object sender, EventArgs e)
        {
            NHANVIEN_TK.manv = USER.Text.ToString();
            NHANVIEN_TK.matk = matk;
            openChildForm(new NHANVIEN_TK());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có chắc muốn thoát chứ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            DANGNHAP L = new DANGNHAP();
            L.Show();
        }

        private void NHANVIEN_Load(object sender, EventArgs e)
        {
            command = new SqlCommand("SELECT MANV FROM NHANVIEN WHERE MATK = '" + matk + "'", ketnoi);
            var n = command.ExecuteScalar();
            if (n != null)
            {
                USER.Text = n.ToString();
            }
        }
    }
}
