using System;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;
using QLBanVeMayBay.Forms;

namespace QLBanVeMayBay
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Hiển thị số theo kiểu Việt Nam: 1.500.000
            Thread.CurrentThread.CurrentCulture = new CultureInfo("vi-VN");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmDangNhap());
        }
    }
}
