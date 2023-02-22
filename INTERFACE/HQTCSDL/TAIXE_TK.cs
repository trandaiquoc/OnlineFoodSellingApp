using System.Data;
using System.Data.SqlClient;

namespace HQTCSDL
{
    public partial class TAIXE_TK : Form
    {
        public static string matx = string.Empty;
        public static string matk = string.Empty;
        public static string data = string.Empty;
        SqlConnection ketnoi = new SqlConnection(data);
        SqlCommand? command = null;
        public TAIXE_TK()
        {
            InitializeComponent();
            ketnoi.Open();

        }

        private void TAIXE_TK_Load(object sender, EventArgs e)
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
            SqlDataAdapter adapter = new SqlDataAdapter("select * from TAIXE WHERE MATX = '" + matx + "'", ketnoi);

            DataTable table = new DataTable();
            adapter.Fill(table);
            cbbHT.ValueMember = "MATX";
            cbbCMND.ValueMember = "MATX";
            cbbDC.ValueMember = "MATX";
            cbbSDT.ValueMember = "MATX";
            cbbE.ValueMember = "MATX";
            cbbBSX.ValueMember = "MATX";
            cbbSTK.ValueMember = "MATX";
            cbbNH.ValueMember = "MATX";
            cbbCNNH.ValueMember = "MATX";
            cbbKVHD.ValueMember = "MATX";

            cbbHT.DisplayMember = "TEN";
            cbbCMND.DisplayMember = "CMND";
            cbbDC.DisplayMember = "DIACHI";
            cbbSDT.DisplayMember = "SDT";
            cbbE.DisplayMember = "EMAIL";
            cbbBSX.DisplayMember = "BIENSOXE";
            cbbSTK.DisplayMember = "SOTAIKHOAN";
            cbbNH.DisplayMember = "NGANHANG";
            cbbCNNH.DisplayMember = "CHINHANHNGANHANG";
            cbbKVHD.DisplayMember = "KHUVUCHOATDONG";

            cbbHT.DataSource = table;
            cbbCMND.DataSource = table;
            cbbDC.DataSource = table;
            cbbSDT.DataSource = table;
            cbbE.DataSource = table;
            cbbBSX.DataSource = table;
            cbbSTK.DataSource = table;
            cbbNH.DataSource = table;
            cbbCNNH.DataSource = table;
            cbbKVHD.DataSource = table;
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
            command = new SqlCommand("USP_TX_CAPNHATCHITIET", ketnoi);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@MATX", SqlDbType.VarChar).Value = matx;
            command.Parameters.Add("@TEN", SqlDbType.NVarChar).Value = cbbHT.Text;
            command.Parameters.Add("@SDT", SqlDbType.VarChar).Value = cbbSDT.Text;
            command.Parameters.Add("@DC", SqlDbType.NVarChar).Value = cbbDC.Text;
            command.Parameters.Add("@CMND", SqlDbType.VarChar).Value = cbbCMND.Text;
            command.Parameters.Add("@BSX", SqlDbType.Char).Value = cbbBSX.Text;
            command.Parameters.Add("@KHUVUCHD", SqlDbType.NVarChar).Value = cbbKVHD.Text;
            command.Parameters.Add("@STK", SqlDbType.VarChar).Value = cbbSTK.Text;
            command.Parameters.Add("@NH", SqlDbType.VarChar).Value = cbbNH.Text;
            command.Parameters.Add("@EMAIL", SqlDbType.VarChar).Value = cbbE.Text;
            command.Parameters.Add("@CNNH", SqlDbType.VarChar).Value = cbbCNNH.Text;
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
