using System;
using System.Data;
using System.Data.SqlClient;


namespace HQTCSDL
{
    public partial class KHACHHANG_DH : Form
    {
        public static string data = string.Empty;
        SqlConnection ketnoi = new SqlConnection(data);
        SqlCommand? command = null;
        public static string makh = string.Empty;
        public KHACHHANG_DH()
        {
            InitializeComponent();
            ketnoi.Open();
        }
        void LoadData()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT MADT, TENQUAN, SDT, DIACHITRUSOCHINH, SLCUAHANG, LOAIAMTHUC, EMAIL FROM DOITAC", ketnoi);

            DataTable table = new DataTable();
            adapter.Fill(table);
            DATA.DataSource = table;
        }

        private void KHACHHANG_DH_Load(object sender, EventArgs e)
        {
            cbbDC.Enabled = false;
            cbbE.Enabled = false;
            cbbL.Enabled = false;
            cbbSDT.Enabled = false;
            cbbSL.Enabled = false;
            cbbT.Enabled = false;
            cbbMDT.Hide();
            LoadData();
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            command = new SqlCommand("SP_KH_KHOITAODON", ketnoi);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MAKH", SqlDbType.VarChar).Value = makh;
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                KHACHHANG_MA.makh = makh;
                KHACHHANG_MA.madh = reader[0].ToString();
                KHACHHANG_MA.madt = cbbMDT.Text;
                KHACHHANG_MA ma = new KHACHHANG_MA();
                ma.Show();
            }
            reader.Close();
        }

        private void DATA_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cbbMDT.DataBindings.Clear();
            cbbMDT.DataBindings.Add("text", DATA.DataSource, "MADT");
            cbbDC.DataBindings.Clear();
            cbbDC.DataBindings.Add("text", DATA.DataSource, "DIACHITRUSOCHINH");
            cbbE.DataBindings.Clear();
            cbbE.DataBindings.Add("text", DATA.DataSource, "EMAIL");
            cbbL.DataBindings.Clear();
            cbbL.DataBindings.Add("text", DATA.DataSource, "LOAIAMTHUC");
            cbbSDT.DataBindings.Clear();
            cbbSDT.DataBindings.Add("text", DATA.DataSource, "SDT");
            cbbSL.DataBindings.Clear();
            cbbSL.DataBindings.Add("text", DATA.DataSource, "SLCUAHANG");
            cbbT.DataBindings.Clear();
            cbbT.DataBindings.Add("text", DATA.DataSource, "TENQUAN");
        }
    }
}
