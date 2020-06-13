using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

        /// The main entry point for the application.
        /// </summary>
namespace Hotel_Management
{
    static class Program
    {
        /// <summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new GUI_DangKi());
            //Application.Run(new GUI_DangNhap());
        }
    }
}
