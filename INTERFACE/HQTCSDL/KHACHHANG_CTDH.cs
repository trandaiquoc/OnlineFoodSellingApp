using System.Data;
using System.Data.SqlClient;

namespace HQTCSDL
{
    public partial class KHACHHANG_CTDH : Form
    {
        public static string data = string.Empty;
        SqlConnection ketnoi = new SqlConnection(data);
        SqlCommand? command = null;
        public static string madh = string.Empty;
        public KHACHHANG_CTDH()
        {
            InitializeComponent();
            ketnoi.Open();
        }

        void LoadData()
        {
            command = new SqlCommand("SP_KH_XEMCHITIETMONAN", ketnoi);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@MADH", SqlDbType.VarChar).Value = madh;
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable table = new DataTable();
            adapter.Fill(table);
            DATA.DataSource = table;
        }

        private void Quaylai_Click(object sender, EventArgs e)
        {
            ketnoi.Close();
            this.Close();
        }

        private void buttonDG_Click(object sender, EventArgs e)
        {
            command = new SqlCommand("SP_KH_DANHGIAMONAN", ketnoi);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@MADH", SqlDbType.VarChar).Value = madh;
            command.Parameters.Add("@TENMON", SqlDbType.NVarChar).Value = cbbTQ;
            command.Parameters.Add("@TENQUAN", SqlDbType.NVarChar).Value = cbbT;
            command.Parameters.Add("@DANHGIA", SqlDbType.NVarChar).Value = cbbDG;
        }

        private void KHACHHANG_CTDH_Load(object sender, EventArgs e)
        {
            cbbG.Enabled = false;
            cbbSL.Enabled = false;
            cbbT.Enabled = false;
            cbbTQ.Enabled = false;
            LoadData();
        }

        private void DATA_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cbbT.DataBindings.Clear();
            cbbT.DataBindings.Add("text", DATA.DataSource, "TENMONAN");
            cbbSL.DataBindings.Clear();
            cbbSL.DataBindings.Add("text", DATA.DataSource, "SLMON");
            cbbG.DataBindings.Clear();
            cbbG.DataBindings.Add("text", DATA.DataSource, "GIA");
            cbbTQ.DataBindings.Clear();
            cbbTQ.DataBindings.Add("text", DATA.DataSource, "TEN");
            cbbDG.DataBindings.Clear();
            cbbDG.DataBindings.Add("text", DATA.DataSource, "DANHGIA");
        }

        private void Quaylai_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
