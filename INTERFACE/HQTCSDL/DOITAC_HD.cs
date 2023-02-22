using System.Data;
using System.Data.SqlClient;

namespace HQTCSDL
{
    public partial class DOITAC_HD : Form
    {
        public static string data = string.Empty;
        SqlConnection ketnoi = new SqlConnection(data);
        SqlCommand? command = null;
        public static string madt = string.Empty;
        public DOITAC_HD()
        {
            InitializeComponent();
            ketnoi.Open();
        }

        private void DOITAC_HD_Load(object sender, EventArgs e)
        {
            cbbMHD.Enabled = false;
            cbbNBD.Enabled = false;
            cbbNKT.Enabled = false;
            cbbPTHH.Enabled = false;
            cbbTT.Enabled = false;
            cbbMST.Enabled = false;
            cbbSL.Enabled = false;
            cbbTDT.Enabled = false;
            LoadData();
        }

        void LoadData()
        {
            command = new SqlCommand("SP_DT_XEMHOPDONG", ketnoi);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@MADT", SqlDbType.VarChar).Value = madt;
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable table = new DataTable();
            adapter.Fill(table);
            DATA.DataSource = table;
        }

        private void buttonCNTT_Click(object sender, EventArgs e)
        {
            command = new SqlCommand("SP_DT_CAPNHATHOPDONG", ketnoi);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@MADT", SqlDbType.VarChar).Value = madt;
            command.Parameters.Add("@STK", SqlDbType.VarChar).Value = cbbSTK.Text;
            command.Parameters.Add("@NH", SqlDbType.VarChar).Value = cbbNH.Text;
            command.Parameters.Add("@CN", SqlDbType.VarChar).Value = cbbCNNH.Text;
            int n = command.ExecuteNonQuery();
            if (n > 0)
            {
                MessageBox.Show("Cập Nhật Thành Công!!");
            }
            else MessageBox.Show("Cập Nhật Thất Bại!!");
        }

        private void DATA_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cbbCNNH.DataBindings.Clear();
            cbbCNNH.DataBindings.Add("text", DATA.DataSource, "CHINHANHNGANHANG");
            cbbMHD.DataBindings.Clear();
            cbbMHD.DataBindings.Add("text", DATA.DataSource, "MAHD");
            cbbMST.DataBindings.Clear();
            cbbMST.DataBindings.Add("text", DATA.DataSource, "MASOTHUE");
            cbbNBD.DataBindings.Clear();
            cbbNBD.DataBindings.Add("text", DATA.DataSource, "NGAYBATDAU");
            cbbNDD.DataBindings.Clear();
            cbbNDD.DataBindings.Add("text", DATA.DataSource, "NGUOIDAIDIEN");
            cbbNH.DataBindings.Clear();
            cbbNH.DataBindings.Add("text", DATA.DataSource, "NGANHANG");
            cbbNKT.DataBindings.Clear();
            cbbNKT.DataBindings.Add("text", DATA.DataSource, "NGAYKETTHUC");
            cbbPTHH.DataBindings.Clear();
            cbbPTHH.DataBindings.Add("text", DATA.DataSource, "PHANTRAMHOAHONG");
            cbbSL.DataBindings.Clear();
            cbbSL.DataBindings.Add("text", DATA.DataSource, "SLCUAHANG");
            cbbSTK.DataBindings.Clear();
            cbbSTK.DataBindings.Add("text", DATA.DataSource, "SOTAIKHOAN");
            cbbTDT.DataBindings.Clear();
            cbbTDT.DataBindings.Add("text", DATA.DataSource, "TENQUAN");
            cbbTT.DataBindings.Clear();
            cbbTT.DataBindings.Add("text", DATA.DataSource, "TINHTRANG");
        }
    }
}
