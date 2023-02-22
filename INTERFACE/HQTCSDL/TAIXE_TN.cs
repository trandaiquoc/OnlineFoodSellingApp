using System.Data;
using System.Data.SqlClient;

namespace HQTCSDL
{

    public partial class TAIXE_TN : Form
    {
        public static string matx = string.Empty;
        public static string data = string.Empty;
        SqlConnection ketnoi = new SqlConnection(data);
        SqlCommand? command = null;
        public TAIXE_TN()
        {
            InitializeComponent();
            ketnoi.Open();
        }
        private void TAIXE_TN_Load(object sender, EventArgs e)
        {
            cbbMDH.Enabled = false;
            cbbPVC.Enabled = false;
            cbbTDT.Enabled = false;
            cbbTG.Enabled = false;
            LoadData();
        }

        void LoadData()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT MADH,PHIVANCHUYEN FROM DONDATHANG " +
                                                        "WHERE NGUOIGIAO = '" + matx + "' AND TINHTRANG = N'Đã Hoàn Thành Đơn'", ketnoi);

            DataTable table = new DataTable();
            adapter.Fill(table);
            DATA.DataSource = table;
        }

        private void DATA_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cbbMDH.DataBindings.Clear();
            cbbMDH.DataBindings.Add("text", DATA.DataSource, "MADH");
            command = new SqlCommand("USP_TX_XEMCHITIETTHUNHAP", ketnoi);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@MADH", SqlDbType.VarChar).Value = cbbMDH.Text;
            command.Parameters.Add("@MATX", SqlDbType.VarChar).Value = matx;
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                cbbPVC.Text = reader["PHIVANCHUYEN"].ToString();
                cbbTG.Text = reader["THOIGIAN"].ToString();
                cbbTDT.Text = reader["TONGTHUNHAP"].ToString();
            }
            reader.Close();
        }
    }
}
