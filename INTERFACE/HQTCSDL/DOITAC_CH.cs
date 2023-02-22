using System.Data;
using System.Data.SqlClient;

namespace HQTCSDL
{
    public partial class DOITAC_CH : Form
    {
        public static string data = string.Empty;
        SqlConnection ketnoi = new SqlConnection(data);
        SqlCommand? command = null;
        public static string madt = string.Empty;
        public DOITAC_CH()
        {
            InitializeComponent();
            ketnoi.Open();
        }

        private void DOITAC_CH_Load(object sender, EventArgs e)
        {
            cbbTT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            LoadData();
        }

        void LoadData()
        {
            command = new SqlCommand("SP_DT_XEMTHONGTINCUAHANG", ketnoi);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MADT", SqlDbType.VarChar).Value = madt;
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable table = new DataTable();
            adapter.Fill(table);
            DATA.DataSource = table;
        }

        private void DATA_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = DATA.Rows[e.RowIndex];
            cbbSTT.Text = Convert.ToString(row.Cells["STT"].Value);
            cbbT.Text = Convert.ToString(row.Cells["TEN"].Value);
            var tt = Convert.ToString(row.Cells["TINHTRANG"].Value);
            if (tt == "1")
                cbbTT.Text = "Bình Thường";
            else cbbTT.Text = "Tạm Nghỉ";
            cbbTGMC.Text = Convert.ToString(row.Cells["THOIGIANMOCUA"].Value);
            cbbTGDC.Text = Convert.ToString(row.Cells["THOIGIANDONGCUA"].Value);
            cbbDC.Text = Convert.ToString(row.Cells["DIACHI"].Value);
        }

        private void buttonT_Click(object sender, EventArgs e)
        {
            command = new SqlCommand("SP_DT_THEMCUAHANG", ketnoi);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MADT", SqlDbType.VarChar).Value = madt;
            command.Parameters.Add("@STT", SqlDbType.NVarChar).Value = cbbSTT.Text;
            command.Parameters.Add("@TENMOI", SqlDbType.NVarChar).Value = cbbT.Text;
            command.Parameters.Add("@DIACHI", SqlDbType.NVarChar).Value = cbbDC.Text;
            command.Parameters.Add("@THOIGIANMOCUA", SqlDbType.Time).Value = cbbTGMC.Text;
            command.Parameters.Add("@THOIGIANDONGCUA", SqlDbType.Time).Value = cbbTGDC.Text;
            if(cbbTT.Text == "Bình Thường")
            {
                command.Parameters.Add("@TINHTRANG", SqlDbType.Bit).Value = true;
            }
            else command.Parameters.Add("@TINHTRANG", SqlDbType.Bit).Value = false;
            int n = command.ExecuteNonQuery();
            if (n > 0)
            {
                MessageBox.Show("Thêm cửa hàng thành công");
            }    
            else
            {
                MessageBox.Show("Thêm cửa hàng thất bại");
            }
            LoadData();

        }

        private void buttonX_Click(object sender, EventArgs e)
        {
            command = new SqlCommand("SP_DT_XOACUAHANG", ketnoi);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MADT", SqlDbType.VarChar).Value = madt;
            command.Parameters.Add("@STT", SqlDbType.NVarChar).Value = cbbSTT.Text;
            int n = command.ExecuteNonQuery();
            if (n > 0)
            {
                MessageBox.Show("Xoá cửa hàng thành công");
            }
            else
            {
                MessageBox.Show("Xoá cửa hàng thất bại");
            }
            LoadData();
        }

        private void buttonS_Click(object sender, EventArgs e)
        {
            command = new SqlCommand("SP_DT_CAPNHATTHONGTINCUAHANG", ketnoi);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MADT", SqlDbType.VarChar).Value = madt;
            command.Parameters.Add("@STT", SqlDbType.NVarChar).Value = cbbSTT.Text;
            command.Parameters.Add("@TENMOI", SqlDbType.NVarChar).Value = cbbT.Text;
            command.Parameters.Add("@DIACHI", SqlDbType.NVarChar).Value = cbbDC.Text;
            command.Parameters.Add("@THOIGIANMOCUA", SqlDbType.Time).Value = cbbTGMC.Text;
            command.Parameters.Add("@THOIGIANDONGCUA", SqlDbType.Time).Value = cbbTGDC.Text;
            if (cbbTT.Text == "Bình Thường")
            {
                command.Parameters.Add("@TINHTRANG", SqlDbType.Bit).Value = true;
            }
            else command.Parameters.Add("@TINHTRANG", SqlDbType.Bit).Value = false;
            int n = command.ExecuteNonQuery();
            if (n > 0)
            {
                MessageBox.Show("Sửa thông tin cửa hàng thành công");
            }
            else
            {
                MessageBox.Show("Sửa thông tin cửa hàng thất bại");
            }
            LoadData();
        }
    }
}
