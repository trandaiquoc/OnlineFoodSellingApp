using System.Data;
using System.Data.SqlClient;

namespace HQTCSDL
{
    public partial class DOITAC_DH : Form
    {
        public static string data = string.Empty;
        SqlConnection ketnoi = new SqlConnection(data);
        SqlCommand? command = null;
        public static string madt = string.Empty;
        public DOITAC_DH()
        {
            InitializeComponent();
            ketnoi.Open();
        }

        private Form? currentChildForm = null;

        private void openChildForm(Form child, Panel panel)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = child;
            child.TopLevel = false;
            child.FormBorderStyle = FormBorderStyle.None;
            child.Dock = DockStyle.Fill;
            panel.Controls.Add(child);
            panel.Tag = child;
            child.BringToFront();
            child.Show();
        }

        private void DOITAC_DH_Load(object sender, EventArgs e)
        {
            cbbMDH.Hide();
            LoadLEFTData();
            LoadRIGHTData();
        }

        void LoadLEFTData()
        {
            command = new SqlCommand("SP_DT_XEMDONHANGCHUAXULY", ketnoi);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MADT", SqlDbType.VarChar).Value = madt;
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable table = new DataTable();
            adapter.Fill(table);
            DATA1.DataSource = table;
        }
        void LoadRIGHTData()
        {
            command = new SqlCommand("SP_DT_XEMDONHANGDAXULY", ketnoi);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MADT", SqlDbType.VarChar).Value = madt;
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable table = new DataTable();
            adapter.Fill(table);
            DATA2.DataSource = table;
        }

        private void DATA1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cbbMDH.DataBindings.Clear();
            cbbMDH.DataBindings.Add("text", DATA1.DataSource, "MADH");
        }

        private void buttonS_Click(object sender, EventArgs e)
        {
            command = new SqlCommand("SP_DT_HOANTATCHUANBI", ketnoi);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MADT", SqlDbType.VarChar).Value = madt;
            command.Parameters.Add("@MADH", SqlDbType.NVarChar).Value = cbbMDH.Text;
            int n = command.ExecuteNonQuery();
            if (n > 0)
            {
                MessageBox.Show("Món ăn trong đơn đang giao");
            }
            else
            {
                MessageBox.Show("Lỗi rồi");
            }
            LoadLEFTData();
        }

        private void DATA2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cbbMDH.DataBindings.Clear();
            cbbMDH.DataBindings.Add("text", DATA1.DataSource, "MADH");
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            DOITAC_CTDH.madt = madt;
            DOITAC_CTDH.madh = cbbMDH.Text;
            openChildForm(new DOITAC_CTDH(), panel_left);
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            DOITAC_CTDH.madt = madt;
            DOITAC_CTDH.madh = cbbMDH.Text;
            openChildForm(new DOITAC_CTDH(), panel_right);
        }
    }
}
