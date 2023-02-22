using System;
using System.Data;
using System.Data.SqlClient;

namespace HQTCSDL
{

    public partial class KHACHHANG_MA : Form
    {
        public static string data = string.Empty;
        SqlConnection ketnoi = new SqlConnection(data);
        SqlCommand? command = null;
        public static string madt = string.Empty;
        public static string makh = string.Empty;
        public static string madh = string.Empty;
        public KHACHHANG_MA()
        {
            InitializeComponent();
            ketnoi.Open();
        }

        void LoadData()
        {
            command = new SqlCommand("SP_KH_XEMMONAN", ketnoi);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@MADT", SqlDbType.VarChar).Value = madt;
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

        private void KHACHHANG_MA_Load(object sender, EventArgs e)
        {
            cbbMMA.Hide();
            cbbG.Enabled = false;
            cbbMT.Enabled = false;
            cbbT.Enabled = false;
            cbbTT.Enabled = false;
            LoadData();
        }

        private void buttonM_Click(object sender, EventArgs e)
        {
            
            command = new SqlCommand("SP_KH_THEMMONVAOGIOHANG", ketnoi);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@MADH", SqlDbType.VarChar).Value = madh;
            command.Parameters.Add("@MAMA", SqlDbType.VarChar).Value = cbbMMA.Text;
            command.Parameters.Add("@MADT", SqlDbType.VarChar).Value = madt;
            int n = command.ExecuteNonQuery();
            if (n <= 0)
            {
                MessageBox.Show("Lỗi rồi TT");
            }
            else
            {
                MessageBox.Show("+1");
            }
            
        }

        private void DATA_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cbbT.DataBindings.Clear();
            cbbT.DataBindings.Add("text", DATA.DataSource, "TENMONAN");
            cbbG.DataBindings.Clear();
            cbbG.DataBindings.Add("text", DATA.DataSource, "GIA");
            cbbMT.DataBindings.Clear();
            cbbMT.DataBindings.Add("text", DATA.DataSource, "MIEUTAMON");
            cbbTT.DataBindings.Clear();
            cbbTT.DataBindings.Add("text", DATA.DataSource, "TINHTRANG");
            cbbMMA.DataBindings.Clear();
            cbbMMA.DataBindings.Add("text", DATA.DataSource, "MAMA");
        }

        private void buttonGH_Click(object sender, EventArgs e)
        {
                GIOHANG.madh = madh;
                GIOHANG.madt = madt;
                GIOHANG.makh = makh;
                GIOHANG g = new GIOHANG();
                g.ShowDialog();
        }
    }
}
