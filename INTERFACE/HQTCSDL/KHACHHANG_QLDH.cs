using System;
using System.Data;
using System.Data.SqlClient;

namespace HQTCSDL
{
    public partial class KHACHHANG_QLDH : Form
    {
        public static string makh = string.Empty;
        public static string data = string.Empty;
        SqlConnection ketnoi = new SqlConnection(data);
        SqlCommand? command = null;
        public KHACHHANG_QLDH()
        {
            InitializeComponent();
            ketnoi.Open();
        }
        private void KHACHHANG_QLDH_Load(object sender, EventArgs e)
        {
            MDH.Enabled = false;
            NM.Enabled = false;
            TTDH.Enabled = false;
            TT.Enabled = false;
            HTTT.Enabled = false;
            LoadData();
        }
        void LoadData()
        {
            command = new SqlCommand("SP_KH_XEMDONHANG", ketnoi);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@MAKH", SqlDbType.VarChar).Value = makh;

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable table = new DataTable();
            adapter.Fill(table);
            DATA.DataSource = table;
        }
        private void buttonHD_Click(object sender, EventArgs e)
        {
            command = new SqlCommand("SP_KH_HUYDON", ketnoi);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@MADH", SqlDbType.VarChar).Value = MDH.Text;
            int n = command.ExecuteNonQuery();
            if (n > 0)
            {
                MessageBox.Show("Huỷ đơn thành công");
            }
            else MessageBox.Show("Đơn được nhận rồi");
            LoadData();
        }

        private void buttonXMA_Click(object sender, EventArgs e)
        {
            if (MDH == null)
            {
                buttonXMA.Enabled = false;
            }
            else
            {
                buttonXMA.Enabled = true;
                KHACHHANG_CTDH.madh = (MDH.Text).ToString();
                KHACHHANG_CTDH A = new KHACHHANG_CTDH();
                A.ShowDialog();
            }
        }

        private void DATA_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MDH.DataBindings.Clear();
            MDH.DataBindings.Add("text", DATA.DataSource, "MADH");
            HTTT.DataBindings.Clear();
            HTTT.DataBindings.Add("text", DATA.DataSource, "HINHTHUCTHANHTOAN");
            TTDH.DataBindings.Clear();
            TTDH.DataBindings.Add("text", DATA.DataSource, "TINHTRANG");
            TT.DataBindings.Clear();
            TT.DataBindings.Add("text", DATA.DataSource, "TONGTIEN");
            NM.DataBindings.Clear();
            NM.DataBindings.Add("text", DATA.DataSource, "THOIGIAN");
            if (TTDH.Text == "Chờ Nhận")
            {
                buttonHD.Enabled = true;
            }
            else buttonHD.Enabled = false;
            if (TTDH.Text == "Đang Đặt" || TTDH.Text == "Đã Huỷ")
            {
                buttonXD.Enabled = true;
            }
            else buttonXD.Enabled = false;
        }

        private void buttonXD_Click(object sender, EventArgs e)
        {
            command = new SqlCommand("SP_KH_XOADON", ketnoi);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@MADH", SqlDbType.VarChar).Value = MDH.Text;
            int n = command.ExecuteNonQuery();
            if (n > 0)
            {
                MessageBox.Show("Xoá đơn thành công");
            }
            else MessageBox.Show("Không xoá được");
            LoadData();
        }
    }
}
