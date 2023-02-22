using System.Data;
using System.Data.SqlClient;

namespace HQTCSDL
{

    public partial class ADMIN_DK : Form
    {
        public static int loaitk = -1;
        public static string data = string.Empty;
        SqlConnection ketnoi = new SqlConnection(data);
        SqlCommand? command = null;
        public ADMIN_DK()
        {
            InitializeComponent();
            ketnoi.Open();
        }

        private void exbutt_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có chắc muốn thoát chứ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                ketnoi.Close();
                this.Close();
            }
        }

        private void cbA_CheckedChanged(object sender, EventArgs e)
        {
            if (cbA.Checked == true)
            {
                loaitk = 0;
            }
        }

        private void cbNV_CheckedChanged(object sender, EventArgs e)
        {
            if (cbNV.Checked == true)
            {
                loaitk = 1;
            }
        }

        private void AnMK_Click(object sender, EventArgs e)
        {
            if (tbMK.PasswordChar == '*')
            {
                hienMK.BringToFront();
                tbMK.PasswordChar = '\0';
            }
        }

        private void hienMK_Click(object sender, EventArgs e)
        {
            if (tbMK.PasswordChar == '\0')
            {
                AnMK.BringToFront();
                tbMK.PasswordChar = '*';
            }
        }

        private void ANXNMK_Click(object sender, EventArgs e)
        {
            if (tbXN.PasswordChar == '*')
            {
                HIENXNMK.BringToFront();
                tbXN.PasswordChar = '\0';
            }
        }

        private void HIENXNMK_Click(object sender, EventArgs e)
        {
            if (tbXN.PasswordChar == '\0')
            {
                ANXNMK.BringToFront();
                tbXN.PasswordChar = '*';
            }
        }

        private void DKbutton_Click(object sender, EventArgs e)
        {
            command = new SqlCommand("SP_AD_DANGKYNHANVIEN", ketnoi);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@USERID", SqlDbType.VarChar).Value = tbTK.Text;
            command.Parameters.Add("@PASSWORD", SqlDbType.VarChar).Value = tbMK.Text;
            command.Parameters.Add("@PASSWORDCHECK", SqlDbType.VarChar).Value = tbXN.Text;
            command.Parameters.Add("@LOAITK", SqlDbType.Int).Value = loaitk;
            int n = command.ExecuteNonQuery();
            if (n > 0)
            {
                MessageBox.Show("Đăng ký thành công");
            }
            else
            {
                MessageBox.Show("Đăng ký không thành công");
            }
        }
    }
}
