using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Input;

namespace HQTCSDL
{
    public partial class GIOHANG : Form
    {
        public static string data = string.Empty;
        SqlConnection ketnoi = new SqlConnection(data);
        SqlCommand? command = null;
        public static string madh = string.Empty;
        public static string makh = string.Empty;
        public static string madt = string.Empty;
        public GIOHANG()
        {
            InitializeComponent();
            ketnoi.Open();
        }

        private void buttonT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonM_Click(object sender, EventArgs e)
        {
            command = new SqlCommand("SP_KH_HOANTHANHDONHANG", ketnoi);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MADH", SqlDbType.VarChar).Value = madh;
            command.Parameters.Add("@HINHTHUCTHANHTOAN", SqlDbType.NVarChar).Value = cbbHTTT.Text;
            command.Parameters.Add("@MAKH", SqlDbType.VarChar).Value = makh;
            int n = command.ExecuteNonQuery();
            if (n > 0)
            {
                MessageBox.Show("Chốt đơn<3");
                this.Close();
            }
            else MessageBox.Show("Thiếu hình thức thanh toán kìa má!!!");
        }

        private void GIOHANG_Load(object sender, EventArgs e)
        {
            cbbHTTT.Text = null;
            cbbMMA.Hide();
            LOAD();
        }

        void LOAD()
        {
            command = new SqlCommand("SP_KH_XEMGIOHANG", ketnoi);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@MADH", SqlDbType.VarChar).Value = madh;
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable table = new DataTable();
            adapter.Fill(table);
            DATA.DataSource = table;
        }

        private void buttonX_Click(object sender, EventArgs e)
        {
            command = new SqlCommand("SP_KH_XOAMON", ketnoi);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MADH", SqlDbType.VarChar).Value = madh;
            command.Parameters.Add("@MAMA", SqlDbType.NVarChar).Value = cbbMMA.Text;
            command.Parameters.Add("@MADT", SqlDbType.VarChar).Value = madt;
            int n = command.ExecuteNonQuery();
            if (n > 0)
            {
                MessageBox.Show("Xoá thành công");
            }
            else MessageBox.Show("Xoá không thành công");
            LOAD();
        }

        private void DATA_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cbbMMA.DataBindings.Clear();
            cbbMMA.DataBindings.Add("text", DATA.DataSource, "MAMA");
        }
    }
}
