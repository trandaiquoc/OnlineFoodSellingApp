using System.Data;
using System.Data.SqlClient;

namespace HQTCSDL
{
    
    public partial class NHANVIEN_HDDD : Form
    {
        public static string data = string.Empty;
        SqlConnection ketnoi = new SqlConnection(data);
        SqlCommand? command = null;
        public static string manv = string.Empty;
        public NHANVIEN_HDDD()
        {
            InitializeComponent();
            ketnoi.Open();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            cbbCNNH.Enabled = false;
            cbbMHD.Enabled = false;
            cbbMST.Enabled = false;
            cbbNDD.Enabled = false;
            cbbNH.Enabled = false;
            cbbSL.Enabled = false;
            cbbSTK.Enabled = false;
            cbbTDT.Enabled = false;
            LoadData();
        }
        void LoadData()
        {
            command = new SqlCommand("SP_NV_XEMHOPDONGDADUYET", ketnoi);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@MANV", SqlDbType.VarChar).Value = manv;
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable table = new DataTable();
            adapter.Fill(table);
            DATA.DataSource = table;
        }

        private void buttonCN_Click(object sender, EventArgs e)
        {
            command = new SqlCommand("SP_NV_CAPNHATHOPDONG", ketnoi);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@MANV", SqlDbType.VarChar).Value = manv;
            command.Parameters.Add("@MAHD", SqlDbType.VarChar).Value = cbbMHD.Text;
            command.Parameters.Add("@TINHTRANG", SqlDbType.NVarChar).Value = cbbTT.Text;
            command.Parameters.Add("@NBD", SqlDbType.Date).Value = cbbNBD.Text;
            command.Parameters.Add("@NKT", SqlDbType.Date).Value = cbbNKT.Text;
            command.Parameters.Add("@PTHH", SqlDbType.Float).Value = cbbPTHH.Text;
            int n = command.ExecuteNonQuery();
            if(n > 0)
            {
                MessageBox.Show("Cập nhật tình trạng thành công");
            }
            else
                MessageBox.Show("Cập nhật tình trạng không thành công");
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

        private void buttonTK_Click(object sender, EventArgs e)
        {
            command = new SqlCommand("SP_NV_TAIKYHOPDONG", ketnoi);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@MANV", SqlDbType.VarChar).Value = manv;
            command.Parameters.Add("@MAHD", SqlDbType.VarChar).Value = cbbMHD.Text;
            int n = command.ExecuteNonQuery();
            if (n > 0)
            {
                MessageBox.Show("Tái ký thành công");
            }
            else
                MessageBox.Show("Tái ký không thành công");
        }
    }
}
