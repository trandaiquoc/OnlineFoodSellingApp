using HQTCSDL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HQTCSDL
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            String data = "Data Source=QUOC;Initial Catalog=QLBH;Integrated Security=True";
            inputData(data);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new DANGNHAP());
            
        }

        private static void inputData(String data)
        {
            //DUNG CHUNG
            DANGNHAP.data = data;
            DANGKY.data = data;
            //ADMIN
            ADMIN.data = data;
            ADMIN_DK.data = data;
            ADMIN_QLTK.data = data;
            ADMIN_TK.data = data;
            //NHANVIEN
            NHANVIEN.data = data;
            NHANVIEN_HDCD.data = data;
            NHANVIEN_HDDD.data = data;
            NHANVIEN_TK.data = data;
            //KHACHHANG
            KHACHHANG.data = data;
            KHACHHANG_CTDH.data = data;
            KHACHHANG_DH.data = data;
            KHACHHANG_MA.data = data;
            KHACHHANG_QLDH.data = data;
            KHACHHANG_TK.data = data;
            GIOHANG.data = data;
            //TAIXE
            TAIXE.data = data;
            TAIXE_CTDH.data = data;
            TAIXE_DH.data = data;
            TAIXE_TK.data = data;
            TAIXE_TN.data = data;
            //DOITAC
            DOITAC.data = data;
            DOITAC_HD.data = data;
            DOITAC_TK.data = data;
            DOITAC_THD.data = data;
            DOITAC_CH.data = data;
            DOITAC_SP.data = data;
            DOITAC_DH.data = data;
            DOITAC_CTDH.data = data;
        }
    }
}
