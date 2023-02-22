using System.Data;
using System.Data.SqlClient;
namespace HQTCSDL
{
    public partial class TAIXE : Form
    {
        public static string data = string.Empty;
        SqlConnection ketnoi = new SqlConnection(data);
        SqlCommand? command = null;
        public static string matk = string.Empty;
        public TAIXE()
        {
            InitializeComponent();
            ketnoi.Open();
        }
        private Form? currentChildForm = null;

        private void openChildForm(Form child)
        {
            if(currentChildForm != null)
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
        private void buttonTK_Click(object sender, EventArgs e)
        {
            TAIXE_TK.matx = USER.Text.ToString();
            TAIXE_TK.matk = matk;
            openChildForm(new TAIXE_TK());
        }

        private void buttonDH_Click(object sender, EventArgs e)
        {
            TAIXE_DH.matx = USER.Text.ToString();
            openChildForm(new TAIXE_DH());
            
        }

        private void buttonTN_Click(object sender, EventArgs e)
        {
            TAIXE_TN.matx = USER.Text.ToString();
            openChildForm(new TAIXE_TN());
        }

        private void EXIT_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có chắc muốn thoát chứ?","Thông Báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(dg == DialogResult.Yes)
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
        private void TAIXE_Load(object sender, EventArgs e)
        {
            command = new SqlCommand("SELECT MATX FROM TAIXE WHERE MATK = '" + matk + "'", ketnoi);
            var n = command.ExecuteScalar();
            if(n != null)
            {
                USER.Text = n.ToString();
            }
        }
    }
}
