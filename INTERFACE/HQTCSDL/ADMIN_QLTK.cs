using System;
using System.Data;
using System.Data.SqlClient;

namespace HQTCSDL
{
    public partial class ADMIN_QLTK : Form
    {
        public static string manv = string.Empty;
        public static string data = string.Empty;
        SqlConnection ketnoi = new SqlConnection(data);
        SqlCommand? command = null;
        public ADMIN_QLTK()
        {
            InitializeComponent();
            ketnoi.Open();
        }

        void LoadData()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM TAIKHOAN", ketnoi);

            DataTable table = new DataTable();
            adapter.Fill(table);
            DATA.DataSource = table;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ADMIN_DK dk = new ADMIN_DK();
            dk.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            command = new SqlCommand("SP_TX_XEMDONHANG", ketnoi);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MATK", SqlDbType.VarChar).Value = cbbMTK.Text;
            int n = command.ExecuteNonQuery();
            if (n > 0)
            {
                MessageBox.Show("Xoá thành công");
            }
            else MessageBox.Show("Xoá thất bại");
            
        }

        private void DATA_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = DATA.Rows[e.RowIndex];
            cbbMTK.Text = Convert.ToString(row.Cells["MATK"].Value);
            cbbTDN.Text = Convert.ToString(row.Cells["TENTK"].Value);
            cbbMK.Text = Convert.ToString(row.Cells["MATKHAU"].Value);
            cbbLTK.Text = Convert.ToString(row.Cells["LOAITK"].Value);
            if(cbbLTK.Text is not null)
            {
                if (cbbLTK.Text.ToString().Contains("1") || cbbLTK.Text.ToString().Contains("0"))
                {
                    button2.Enabled = true;
                }
                else button2.Enabled = false;
                command = new SqlCommand("SP_AD_XEMTAIKHOANDADUOCKICHHOAT", ketnoi);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@MATK", SqlDbType.VarChar).Value = cbbMTK.Text;
                var n = command.ExecuteScalar().ToString();
                if(n == "1")
                {
                    button4.Enabled = true;
                    button5.Enabled = false;
                }
                else
                {
                    button4.Enabled = false;
                    button5.Enabled = true;
                }
            }    
        }

        private void button4_Click(object sender, EventArgs e)
        {
            command = new SqlCommand("SP_AD_KHOA", ketnoi);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MATK", SqlDbType.VarChar).Value = cbbMTK.Text;
            int KHOA = command.ExecuteNonQuery();
            button4.Enabled = false;
            button5.Enabled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            command = new SqlCommand("SP_AD_KICHHOAT", ketnoi);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MATK", SqlDbType.VarChar).Value = cbbMTK.Text;
            int KICHHOAT = command.ExecuteNonQuery();
            button4.Enabled = true;
            button5.Enabled = false;
        }
    }
}
