using System.Data;
using System.Data.SqlClient;

namespace HQTCSDL
{
    public partial class TAIXE_CTDH : Form
    {
        public static string data = string.Empty;
        SqlConnection ketnoi = new SqlConnection(data);
        SqlCommand? command = null;
        public static string madh = string.Empty;
        public TAIXE_CTDH()
        {
            InitializeComponent();
            ketnoi.Open();
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            cbbDC.Enabled = false;
            cbbG.Enabled = false;
            cbbSL.Enabled = false;
            cbbT.Enabled = false;
            cbbTQ.Enabled = false;
            LoadData();
        }
        void LoadData()
        {
            command = new SqlCommand("USP_TX_XEMCHITIETDON", ketnoi);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@MADH", SqlDbType.VarChar).Value = madh;
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable table = new DataTable();
            adapter.Fill(table);
            DATA.DataSource = table;
        }
        private void QUAYLAI_Click(object sender, EventArgs e)
        {
            ketnoi.Close();
            this.Close();
        }

        private void DATA_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = DATA.Rows[e.RowIndex];
            cbbT.Text = Convert.ToString(row.Cells["TENMONAN"].Value);
            cbbSL.Text = Convert.ToString(row.Cells["SLMON"].Value);
            cbbG.Text = Convert.ToString(row.Cells["GIA"].Value);
            cbbTQ.Text = Convert.ToString(row.Cells["TEN"].Value);
            cbbDC.Text = Convert.ToString(row.Cells["DIACHI"].Value);
        }
    }
}
