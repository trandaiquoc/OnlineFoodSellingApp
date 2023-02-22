using System.Data;
using System.Data.SqlClient;

namespace HQTCSDL
{
    public partial class DOITAC : Form
    {
        public static string data = string.Empty;
        SqlConnection ketnoi = new SqlConnection(data);
        SqlCommand? command = null;
        public static string matk = string.Empty;
        public DOITAC()
        {
            InitializeComponent();
            ketnoi.Open();
        }
        private Form? currentChildForm = null;

        private void openChildForm(Form child)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = child;
            child.TopLevel = false;
            child.FormBorderStyle = FormBorderStyle.None;
            child.Dock = DockStyle.Fill;
            panel_body.Controls.Add(child);
            panel_body.Tag = child;
            child.BringToFront();
            child.Show();
        }

        private void THOAT_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có chắc muốn thoát chứ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void buttonDX_Click(object sender, EventArgs e)
        {
            this.Close();
            DANGNHAP L = new DANGNHAP();
            L.Show();
        }

        private void buttonTK_Click(object sender, EventArgs e)
        {
            DOITAC_TK.madt = USER.Text.ToString();
            DOITAC_TK.matk = matk;
            openChildForm(new DOITAC_TK());
        }

        private void DOITAC_Load(object sender, EventArgs e)
        {
            command = new SqlCommand("SELECT MADT FROM DOITAC WHERE MATK = '" + matk + "'", ketnoi);
            var n = command.ExecuteScalar();
            if (n != null)
            {
                USER.Text = n.ToString();
            }
        }

        private void buttonTHD_Click(object sender, EventArgs e)
        {
            DOITAC_THD.madt = USER.Text.ToString();
            openChildForm(new DOITAC_THD());
        }

        private void buttonHD_Click(object sender, EventArgs e)
        {
            DOITAC_HD.madt = USER.Text.ToString();
            openChildForm(new DOITAC_HD());
        }

        private void buttonCH_Click(object sender, EventArgs e)
        {
            DOITAC_CH.madt = USER.Text.ToString();
            openChildForm(new DOITAC_CH());
        }

        private void buttonSP_Click(object sender, EventArgs e)
        {
            DOITAC_SP.madt = USER.Text.ToString();
            openChildForm(new DOITAC_SP());
        }

        private void buttonDH_Click(object sender, EventArgs e)
        {
            DOITAC_DH.madt = USER.Text.ToString();
            openChildForm(new DOITAC_DH());
        }
    }
}
