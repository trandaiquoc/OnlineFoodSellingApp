using System.Data;
using System.Data.SqlClient;
namespace HQTCSDL
{
    public partial class KHACHHANG_TK : Form
    {
        public static string makh = string.Empty;
        public static string matk = string.Empty;
        public static string data = string.Empty;
        SqlConnection ketnoi = new SqlConnection(data);
        SqlCommand? command = null;
        public KHACHHANG_TK()
        {
            InitializeComponent();
            ketnoi.Open();
        }

        private void KHACHHANG_TK_Load(object sender, EventArgs e)
        {
            LoadAccountSide();
            LoadInforSide();
        }

        void LoadAccountSide()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("select * from TAIKHOAN WHERE MATK = '" + matk + "'", ketnoi);

            DataTable table = new DataTable();
            adapter.Fill(table);
            cbbTDN.ValueMember = "MATK";
            cbbMK.ValueMember = "MATK";
            cbbXNMK.ValueMember = "MATK";
            cbbTDN.DisplayMember = "TENTK";
            cbbMK.DisplayMember = "MATKHAU";
            cbbXNMK.DisplayMember = "MATKHAU";
            cbbTDN.DataSource = table;
            cbbMK.DataSource = table;
            cbbXNMK.DataSource = table;
        }

        void LoadInforSide()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("select * from KHACHHANG WHERE makh = '" + makh + "'", ketnoi);

            DataTable table = new DataTable();
            adapter.Fill(table);
            cbbHT.ValueMember = "MAKH";
            Email.ValueMember = "MAKH";
            DC.ValueMember = "MAKH";
            SDT.ValueMember = "MAKH";
           
            cbbHT.DisplayMember = "TEN";
            DC.DisplayMember = "DIACHI";
            SDT.DisplayMember = "SDT";
            Email.DisplayMember = "EMAIL";

            cbbHT.DataSource = table;
            DC.DataSource = table;
            SDT.DataSource = table;
            Email.DataSource = table;
        }
        private void Luutttk_Click(object sender, EventArgs e)
        {
            command = new SqlCommand("SP_CAPNHATTAIKHOAN", ketnoi);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@MATK", SqlDbType.VarChar).Value = matk;
            command.Parameters.Add("@USERID", SqlDbType.VarChar).Value = cbbTDN.Text;
            command.Parameters.Add("@PASSWORD", SqlDbType.VarChar).Value = cbbMK.Text;
            command.Parameters.Add("@PASSWORDCHECK", SqlDbType.VarChar).Value = cbbXNMK.Text;
            int n = command.ExecuteNonQuery();
            if (n > 0)
            {
                MessageBox.Show("Cập Nhật Thành Công");
            }
            else MessageBox.Show("Cập Nhật Thất Bại");
            LoadAccountSide();
        }
        private void luuttct_Click(object sender, EventArgs e)
        {
            command = new SqlCommand("SP_CAPNHATKHACHHANG", ketnoi);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@TEN", SqlDbType.NVarChar).Value = cbbHT.Text;
            command.Parameters.Add("@SDT", SqlDbType.VarChar).Value = SDT.Text;
            command.Parameters.Add("@DC", SqlDbType.NVarChar).Value = DC.Text;
            command.Parameters.Add("@EMAIL", SqlDbType.VarChar).Value = Email.Text;
            int n = command.ExecuteNonQuery();
            if (n > 0)
            {
                MessageBox.Show("Cập Nhật Thành Công");
            }
            else MessageBox.Show("Cập Nhật Thất Bại");
            LoadInforSide();
        }
    }
}
