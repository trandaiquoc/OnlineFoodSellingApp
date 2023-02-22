using System.Data;
using System.Data.SqlClient;

namespace HQTCSDL
{
    public partial class DOITAC_SP : Form
    {
        public static string data = string.Empty;
        SqlConnection ketnoi = new SqlConnection(data);
        SqlCommand? command = null;
        public static string madt = string.Empty;
        public DOITAC_SP()
        {
            InitializeComponent();
            ketnoi.Open();
        }
        void LoadData()
        {
            command = new SqlCommand("SP_DT_XEMMONAN", ketnoi);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MADT", SqlDbType.VarChar).Value = madt;
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable table = new DataTable();
            adapter.Fill(table);
            DATA.DataSource = table;
        }

        private void DOITAC_SP_Load(object sender, EventArgs e)
        {
            cbbMM.Enabled = false;
            cbbTT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            LoadData();
        }

        private void DATA_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = DATA.Rows[e.RowIndex];
            cbbMM.Text = Convert.ToString(row.Cells["MAMA"].Value);
            cbbT.Text = Convert.ToString(row.Cells["TENMONAN"].Value);
            cbbTT.Text = Convert.ToString(row.Cells["TINHTRANG"].Value);
            cbbG.Text = Convert.ToString(row.Cells["GIA"].Value);
            cbbTC.Text = Convert.ToString(row.Cells["TUYCHON"].Value);
            cbbMT.Text = Convert.ToString(row.Cells["MIEUTAMON"].Value);
        }

        private void buttonT_Click(object sender, EventArgs e)
        {
            command = new SqlCommand("SP_DT_THEMMONAN", ketnoi);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MADT", SqlDbType.VarChar).Value = madt;
            command.Parameters.Add("@TEN", SqlDbType.NVarChar).Value = cbbT.Text;
            command.Parameters.Add("@MIEUTAMON", SqlDbType.NVarChar).Value = cbbMT.Text;
            command.Parameters.Add("@TINHTRANG", SqlDbType.NVarChar).Value = cbbTT.Text;
            command.Parameters.Add("@TUYCHON", SqlDbType.NVarChar).Value = cbbTC.Text;
            command.Parameters.Add("@GIA", SqlDbType.Money).Value = cbbG.Text;
            int n = command.ExecuteNonQuery();
            if (n > 0)
            {
                MessageBox.Show("Thêm món ăn thành công");
            }
            else
            {
                MessageBox.Show("Thêm món ăn thất bại");
            }
            LoadData();
        }

        private void buttonX_Click(object sender, EventArgs e)
        {
            command = new SqlCommand("SP_DT_XOAMONAN", ketnoi);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MADT", SqlDbType.VarChar).Value = madt;
            command.Parameters.Add("@MAMA", SqlDbType.NVarChar).Value = cbbMM.Text;
            int n = command.ExecuteNonQuery();
            if (n > 0)
            {
                MessageBox.Show("Xoá món ăn thành công");
            }
            else
            {
                MessageBox.Show("Xoá món ăn thất bại");
            }
            LoadData();
        }

        private void buttonS_Click(object sender, EventArgs e)
        {
            command = new SqlCommand("SP_DT_CAPNHATTHONGTINMONAN", ketnoi);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MADT", SqlDbType.VarChar).Value = madt;
            command.Parameters.Add("@MAMA", SqlDbType.VarChar).Value = cbbMM.Text;
            command.Parameters.Add("@TENMONAN", SqlDbType.NVarChar).Value = cbbT.Text;
            command.Parameters.Add("@MIEUTAMON", SqlDbType.NVarChar).Value = cbbMT.Text;
            command.Parameters.Add("@TINHTRANG", SqlDbType.NVarChar).Value = cbbTT.Text;
            command.Parameters.Add("@TUYCHON", SqlDbType.NVarChar).Value = cbbTC.Text;
            command.Parameters.Add("@GIA", SqlDbType.Money).Value = cbbG.Text;
            int n = command.ExecuteNonQuery();
            if (n > 0)
            {
                MessageBox.Show("Sửa thông tin món ăn thành công");
            }
            else
            {
                MessageBox.Show("Sửa thông tin món ăn thất bại");
            }
            LoadData();
        }
    }
}
