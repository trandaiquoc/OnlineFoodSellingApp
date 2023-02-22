using System.Data;
using System.Data.SqlClient;

namespace HQTCSDL
{
    public partial class DANGNHAP : Form
    {
        public static string username = string.Empty;
        public static string password = string.Empty;
        public static string data = string.Empty;
        SqlConnection ketnoi = new SqlConnection(data);
        SqlCommand? command = null;
        public static string matk = string.Empty;
        public DANGNHAP()
        {
            InitializeComponent();
            ketnoi.Open();
            
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

        private void DNbutton_Click(object sender, EventArgs e)
        {
            command = new SqlCommand("SP_DANGNHAP", ketnoi);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@USERID", SqlDbType.VarChar).Value = tbTK.Text;
            command.Parameters.Add("@PASSWORD", SqlDbType.VarChar).Value = tbMK.Text;
            var returnParameter = command.Parameters.Add("@ReturnVal", SqlDbType.Int);
            returnParameter.Direction = ParameterDirection.ReturnValue;
            command.ExecuteNonQuery();
            var n = returnParameter.Value.ToString();
            if (n == "1")
            {
                
                MessageBox.Show("Tài Khoản bị khoá rồi má. Xin vía, xin vía!");
            }
            else if (n == "2")
            {
                MessageBox.Show("Không nhập đầy đủ thông tin để đăng nhập");
            }
            else if (n == "3")
            {
                MessageBox.Show("Tên tài khoản không tồn tại");
            }
            else if (n == "4")
            {
                MessageBox.Show("Sai mật khẩu");
            }
            else
            {
                command = new SqlCommand("SELECT MATK,LOAITK FROM TAIKHOAN " +
                "WHERE TENTK = '" + tbTK.Text + "'", ketnoi);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    var TK = reader[0].ToString();
                    var LOAITK = reader[1].ToString();
                    if (TK != null && LOAITK != null)
                    {
                        matk = TK.ToString();
                        LOAITK = LOAITK.ToString();
                    }
                    if (LOAITK == "0" && LOAITK != null)
                    {
                        ADMIN.matk = matk;
                        ADMIN TX = new ADMIN();
                        this.Hide();
                        TX.Show();
                    }
                    else if (LOAITK == "1" && LOAITK != null)
                    {
                        NHANVIEN.matk = matk;
                        NHANVIEN TX = new NHANVIEN();
                        this.Hide();
                        TX.Show();
                    }
                    else if (LOAITK == "2" && LOAITK != null)
                    {
                        DOITAC.matk = matk;
                        DOITAC TX = new DOITAC();
                        this.Hide();
                        TX.Show();
                    }
                    else if (LOAITK == "3" && LOAITK != null)
                    {
                        KHACHHANG.matk = matk;
                        KHACHHANG TX = new KHACHHANG();
                        this.Hide();
                        TX.Show();
                    }
                    else
                    {
                        TAIXE.matk = matk;
                        TAIXE TX = new TAIXE();
                        this.Hide();
                        TX.Show();

                    }
                }
                reader.Close();
            }
        }

        private void exbutt_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có chắc muốn thoát chứ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void DKbutton_Click(object sender, EventArgs e)
        {
            DANGKY DK = new DANGKY();
            DK.ShowDialog();
        }

        public void LOGIN_Load(object sender, EventArgs e)
        {
            tbTK.Text = null;
            tbMK.Text = null;
            if (username != null && password != null)
            {
                tbTK.Text = username;
                tbMK.Text = password;
            }
        }

        private void tbMK_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                DNbutton_Click(sender, e);
            }
        }
    }
}
