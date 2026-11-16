using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace QLBanVeMayBay.Forms
{
    // Form dùng chung để xem các báo cáo Crystal Report
    public partial class frmBaoCao : Form
    {
        private ReportDocument baoCao;

        public frmBaoCao()
        {
            InitializeComponent();
        }

        // tenFile: tên file .rpt trong thư mục Reports, duLieu: dữ liệu lấy từ stored procedure
        public frmBaoCao(string tenFile, DataTable duLieu) : this()
        {
            baoCao = new ReportDocument();
            baoCao.Load(Path.Combine(Application.StartupPath, "Reports", tenFile));
            baoCao.Database.Tables[0].SetDataSource(duLieu);
            crvBaoCao.ReportSource = baoCao;
        }

        private void frmBaoCao_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (baoCao != null)
            {
                baoCao.Close();
                baoCao.Dispose();
            }
        }
    }
}
