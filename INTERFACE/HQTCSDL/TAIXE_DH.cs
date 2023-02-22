using System.Data;
using System.Data.SqlClient;


namespace HQTCSDL
{

    public partial class TAIXE_DH : Form
    {
        public static string matx = string.Empty;
        public static string data = string.Empty;
        SqlConnection ketnoi = new SqlConnection(data);
        SqlCommand? command = null;
        public TAIXE_DH()
        {
            InitializeComponent();
            ketnoi.Open();
        }

        private void TAIXE_DH_Load(object sender, EventArgs e)
        {
            CBBMDH.Enabled = false;
            CBBTKH.Enabled = false;
            CBBDC.Enabled = false;
            CBBHTTT.Enabled = false;
            CBBPVC.Enabled = false;
            CBBSDT.Enabled = false;
            CBBTT.Enabled = false;
            CBBTTDH.Enabled = false;
            LoadData();
        }
        void LoadData()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT MADH,TINHTRANG,NGUOIDAT,PHIVANCHUYEN,TONGTIEN, HINHTHUCTHANHTOAN FROM DONDATHANG " +
                "WHERE (TINHTRANG = N'Chờ Nhận') OR (NGUOIGIAO = '" + matx + "' AND (TINHTRANG <> N'Chờ Nhận' AND TINHTRANG <> N'Đã Hoàn Thành Đơn'))", ketnoi);

            DataTable table = new DataTable();
            adapter.Fill(table);
            DATA.DataSource = table;
        }
        private void buttonXMA_Click(object sender, EventArgs e)
        {
            if (CBBMDH.Text == null)
            {
                buttonXMA.Enabled = false;
            }
            else
            {
                buttonXMA.Enabled = true;
                TAIXE_CTDH.madh = (CBBMDH.Text).ToString();
                TAIXE_CTDH A = new TAIXE_CTDH();
                A.ShowDialog();
            }
        }

        private void buttonND_Click(object sender, EventArgs e)
        {
            command = new SqlCommand("USP_TX_NHANDON", ketnoi);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@MADH", SqlDbType.VarChar).Value = CBBMDH.Text;
            command.Parameters.Add("@MATX", SqlDbType.VarChar).Value = matx;
            int n = command.ExecuteNonQuery();
            if (n > 0)
            {
                MessageBox.Show("Nhận Đơn Thành Công");
            }
            else MessageBox.Show("Nhận Đơn Thất Bại");
            LoadData();
        }

        private void buttonHTD_Click(object sender, EventArgs e)
        {
            command = new SqlCommand("USP_TX_HOANTHANHDON", ketnoi);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@MADH", SqlDbType.VarChar).Value = CBBMDH.Text;
            int n = command.ExecuteNonQuery();
            if (n > 0)
            {
                MessageBox.Show("Đơn Đã Hoàn Thành");
            }
            else MessageBox.Show("Hình Như Có Gì Không Ổn Rồi ><!!");
            LoadData();
        }

        private void DATA_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CBBMDH.DataBindings.Clear();
            CBBMDH.DataBindings.Add("text", DATA.DataSource, "MADH");
            command = new SqlCommand("USP_TX_XEMDONHANG", ketnoi);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@MADH", SqlDbType.VarChar).Value = CBBMDH.Text;
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                CBBTKH.Text = reader["TEN"].ToString();
                CBBSDT.Text = reader["SDT"].ToString();
                CBBPVC.Text = reader["PHIVANCHUYEN"].ToString();
                CBBDC.Text = reader["DIACHI"].ToString();
                CBBHTTT.Text = reader["HINHTHUCTHANHTOAN"].ToString();
                CBBTT.Text = reader["TINHTRANG"].ToString();
                CBBTTDH.Text = reader["TONGTIEN"].ToString();
            }
            reader.Close();
            if (CBBTT.Text == "Chờ Nhận")
            {
                buttonHTD.Enabled = false;
            }
            else buttonHTD.Enabled = true;
            if (CBBTT.Text == "Đang Giao")
            {
                buttonND.Enabled = false;
            }
            else buttonND.Enabled = true;
        }
    }
}
