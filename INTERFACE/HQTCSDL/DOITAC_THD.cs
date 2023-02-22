using System.Data;
using System.Data.SqlClient;

namespace HQTCSDL
{
    public partial class DOITAC_THD : Form
    {
        public static string data = string.Empty;
        SqlConnection ketnoi = new SqlConnection(data);
        SqlCommand? command = null;
        public static string madt = string.Empty;
        public DOITAC_THD()
        {
            InitializeComponent();
            ketnoi.Open();
        }

        private void buttonDK_Click(object sender, EventArgs e)
        {
            command = new SqlCommand("SP_DT_THEMHOPDONG", ketnoi);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@MADT", SqlDbType.VarChar).Value = madt;
            command.Parameters.Add("@STK", SqlDbType.VarChar).Value = cbbSTK.Text;
            command.Parameters.Add("@NH", SqlDbType.VarChar).Value = cbbNH.Text;
            command.Parameters.Add("@CNNH", SqlDbType.VarChar).Value = cbbCNNH.Text;
            int n = command.ExecuteNonQuery();
            if (n > 0)
            {
                MessageBox.Show("\tOke rồi nha\nĐợi tí nhân viên đang chạy deadline ^^!!");
            }
            else MessageBox.Show("Hình như thiếu thông tin rồi!!");
        }
    }
}
