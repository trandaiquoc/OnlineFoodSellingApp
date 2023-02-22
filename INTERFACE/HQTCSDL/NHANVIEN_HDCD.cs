using System.Data;
using System.Data.SqlClient;

namespace HQTCSDL
{
    public partial class NHANVIEN_HDCD : Form
    {
        public static string data = string.Empty;
        SqlConnection ketnoi = new SqlConnection(data);
        SqlCommand? command = null;
        public static string manv = string.Empty;

        public NHANVIEN_HDCD()
        {
            InitializeComponent();
            ketnoi.Open();
        }

        private void NHANVIEN_HDCD_Load(object sender, EventArgs e)
        {
            cbbLAT.Enabled = false;
            cbbMDT.Enabled = false;
            cbbMHD.Enabled = false;
            cbbNDD.Enabled = false;
            cbbSL.Enabled = false;
            cbbTDT.Enabled = false;
            LoadData();
        }
        void LoadData()
        {
            command = new SqlCommand("SP_NV_XEMHOPDONGCHUADUYET", ketnoi);
            command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable table = new DataTable();
            adapter.Fill(table);
            DATA.DataSource = table;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            command = new SqlCommand("SP_NV_DUYETHOPDONG", ketnoi);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@MANV", SqlDbType.VarChar).Value = manv;
            command.Parameters.Add("@MAHD", SqlDbType.VarChar).Value = cbbMHD.Text;
            int n = command.ExecuteNonQuery();
            if (n > 0)
            {
                MessageBox.Show("Duyệt thành công");
            }
            else
                MessageBox.Show("Duyệt không thành công");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            command = new SqlCommand("SP_NV_XOAHOPDONG", ketnoi);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@MAHD", SqlDbType.VarChar).Value = cbbMHD.Text;
            int n = command.ExecuteNonQuery();
            if (n > 0)
            {
                MessageBox.Show("Xoá thành công");
            }
            else
                MessageBox.Show("Xoá không thành công");
        }

        private void DATA_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = DATA.Rows[e.RowIndex];
            cbbLAT.Text = Convert.ToString(row.Cells["LOAIAMTHUC"].Value);
            cbbMDT.Text = Convert.ToString(row.Cells["MADT"].Value);
            cbbMHD.Text = Convert.ToString(row.Cells["MAHD"].Value);
            cbbNDD.Text = Convert.ToString(row.Cells["NGUOIDAIDIEN"].Value);
            cbbSL.Text = Convert.ToString(row.Cells["SLCUAHANG"].Value);
            cbbTDT.Text = Convert.ToString(row.Cells["TENQUAN"].Value);
        }
    }
}
