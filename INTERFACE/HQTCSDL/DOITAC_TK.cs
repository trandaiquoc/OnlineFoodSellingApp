using System;
using System.Data;
using System.Data.SqlClient;

namespace HQTCSDL
{

    public partial class DOITAC_TK : Form
    {
        public static string madt = string.Empty;
        public static string matk = string.Empty;
        public static string data = string.Empty;
        SqlConnection ketnoi = new SqlConnection(data);
        SqlCommand? command = null;
        public DOITAC_TK()
        {
            InitializeComponent();
            ketnoi.Open();
        }

        private void DOITAC_TK_Load(object sender, EventArgs e)
        {
            cbbDSB.Enabled = false;

            LoadDSB();
            LoadAccountSide();
            LoadInforSide();     
        }

        private void LoadDSB()
        {
            command = new SqlCommand("SP_DT_DOANHSOBAN", ketnoi);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MADT", SqlDbType.VarChar).Value = madt;
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
            SqlDataAdapter adapter = new SqlDataAdapter("select * from DOITAC WHERE MADT = '" + madt + "'", ketnoi);

            DataTable table = new DataTable();
            adapter.Fill(table);
            cbbDC.ValueMember = "MADT";
            cbbDSB.ValueMember = "MADT";
            cbbE.ValueMember = "MADT";
            cbbLAT.ValueMember = "MADT";
            cbbNDD.ValueMember = "MADT";
            cbbMST.ValueMember = "MADT";
            cbbSLCH.ValueMember = "MADT";
            cbbSLD.ValueMember = "MADT";
            cbbTQ.ValueMember = "MADT";
            cbbSDT.ValueMember = "MADT";

            cbbDC.DisplayMember = "DIACHITRUSOCHINH";
            cbbDSB.DisplayMember = "DOANHSOBAN";
            cbbE.DisplayMember = "EMAIL";
            cbbLAT.DisplayMember = "LOAIAMTHUC";
            cbbSLCH.DisplayMember = "SLCUAHANG";
            cbbNDD.DisplayMember = "NGUOIĐAIIEN";
            cbbMST.DisplayMember = "MASOTHUE";
            cbbSLD.DisplayMember = "SLDONMOINGAY";
            cbbTQ.DisplayMember = "TENQUAN";
            cbbSDT.DisplayMember = "SDT";

            cbbDC.DataSource = table;
            cbbDSB.DataSource = table;
            cbbE.DataSource = table;
            cbbLAT.DataSource = table;
            cbbSLCH.DataSource = table;
            cbbNDD.DataSource = table;
            cbbMST.DataSource = table;
            cbbSLD.DataSource = table;
            cbbTQ.DataSource = table;
            cbbSDT.DataSource = table;
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
            command = new SqlCommand("SP_DT_CAPNHATCHITIET", ketnoi);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@MADT", SqlDbType.VarChar).Value = madt;
            command.Parameters.Add("@TENQUAN", SqlDbType.NVarChar).Value = cbbTQ.Text;
            command.Parameters.Add("@SDT", SqlDbType.VarChar).Value = cbbSDT.Text;
            command.Parameters.Add("@DIACHITRUSOCHINH", SqlDbType.NVarChar).Value = cbbDC.Text;
            command.Parameters.Add("@SLCUAHANG", SqlDbType.Int).Value = cbbSLCH.Text;
            command.Parameters.Add("@SLDONMOINGAY", SqlDbType.Char).Value = cbbSLD.Text;
            command.Parameters.Add("@LOAIAMTHUC", SqlDbType.NVarChar).Value = cbbLAT.Text;
            command.Parameters.Add("@MASOTHUE", SqlDbType.VarChar).Value = cbbMST.Text;
            command.Parameters.Add("@EMAIL", SqlDbType.VarChar).Value = cbbE.Text;
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
