using System.Data;
using System.Data.SqlClient;

namespace HQTCSDL
{
    public partial class DOITAC_CTDH : Form
    {
        public static string data = string.Empty;
        SqlConnection ketnoi = new SqlConnection(data);
        SqlCommand? command = null;
        public static string madt = string.Empty;
        public static string madh = string.Empty;
        public DOITAC_CTDH()
        {
            InitializeComponent();
            ketnoi.Open();
        }

        private void DOITAC_CTDH_Load(object sender, EventArgs e)
        {
            command = new SqlCommand("SP_DT_XEMCHITIETDON", ketnoi);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MADH", SqlDbType.VarChar).Value = madh;
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable table = new DataTable();
            adapter.Fill(table);
            DATA.DataSource = table;
        }

        private void buttonQL_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DATA_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cbbT.DataBindings.Clear();
            cbbT.DataBindings.Add("text", DATA.DataSource, "TENMONAN");
            cbbSL.DataBindings.Clear();
            cbbSL.DataBindings.Add("text", DATA.DataSource, "SLMON");
        }
    }
}
