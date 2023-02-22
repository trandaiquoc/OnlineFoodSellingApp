using System.Data;
using System.Data.SqlClient;

namespace HQTCSDL
{
    public partial class ADMIN_TK : Form
    {
        public static string manv = string.Empty;
        public static string matk = string.Empty;
        public static string data = string.Empty;
        SqlConnection ketnoi = new SqlConnection(data);
        SqlCommand? command = null;
        public ADMIN_TK()
        {
            InitializeComponent();
            ketnoi.Open();
        }

        private void ADMIN_TK_Load(object sender, EventArgs e)
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
            SqlDataAdapter adapter = new SqlDataAdapter("select * from NHANVIEN WHERE MANV = '" + manv + "'", ketnoi);

            DataTable table = new DataTable();
            adapter.Fill(table);
            cbbT.ValueMember = "MATX";
            cbbSDT.ValueMember = "MATX";
            cbbE.ValueMember = "MATX";

            cbbT.DisplayMember = "TEN";
            cbbSDT.DisplayMember = "SDT";
            cbbE.DisplayMember = "EMAIL";

            cbbT.DataSource = table;
            cbbSDT.DataSource = table;
            cbbE.DataSource = table;
        }
        private void button1_Click(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            command = new SqlCommand("SP_AD_NV_CAPNHATTHONGTINCHITIET", ketnoi);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@MANV", SqlDbType.VarChar).Value = manv;
            command.Parameters.Add("@TEN", SqlDbType.NVarChar).Value = cbbT.Text;
            command.Parameters.Add("@SDT", SqlDbType.VarChar).Value = cbbSDT.Text;
            command.Parameters.Add("@EMAIL", SqlDbType.VarChar).Value = cbbE.Text;
            command.Parameters.Add("@AD", SqlDbType.Bit).Value = 1;
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
