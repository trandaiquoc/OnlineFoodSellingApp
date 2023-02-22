using System.Data;
using System.Data.SqlClient;

namespace HQTCSDL
{
    public partial class DANGKY : Form
    {
        public static int loaitk = -1;
        public static string data = string.Empty;
        SqlConnection ketnoi = new SqlConnection(data);
        SqlCommand? command = null;
        public DANGKY()
        {
            InitializeComponent();
            ketnoi.Open();
        }

        private void exbutt_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có chắc muốn thoát chứ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                Application.Exit();
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
            command = new SqlCommand("SP_DANGKYTAIKHOAN", ketnoi);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@USERID", SqlDbType.VarChar).Value = tbTK.Text;
            command.Parameters.Add("@PASSWORD", SqlDbType.VarChar).Value = tbMK.Text;
            command.Parameters.Add("@PASSWORDCHECK", SqlDbType.VarChar).Value = tbXN.Text;
            command.Parameters.Add("@LOAITK", SqlDbType.Int).Value = loaitk;
            int n = command.ExecuteNonQuery();
            if (n > 0)
            {
                DNbutton_Click(sender, e);
            }
            else
            {
                MessageBox.Show(n.ToString());
            }
        }
        private void cbDT_CheckedChanged(object sender, EventArgs e)
        {
            if(cbDT.Checked == true)
            {
                loaitk = 2;
            }
        }

        private void cbKH_CheckedChanged(object sender, EventArgs e)
        {
            if (cbKH.Checked == true)
            {
                loaitk = 3;
            }
        }

        private void cbTX_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTX.Checked == true)
            {
                loaitk = 4;
            }
        }

        private void DNbutton_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn đăng nhập không?", "Đăng Ký Thành Công", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                DANGNHAP.username = tbTK.Text;
                DANGNHAP.password = tbMK.Text;
                this.Close();
            }
        }
    }
}
