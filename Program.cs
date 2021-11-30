using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Cursovaya_Hostel__Kosinskiy_PZPI_20_10
{
    static class Cheking
    {
        public static bool Checked { get; set; } = false;
    }
    static class Program
    {
     
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new InventoryADD_Form());
            Application.Run(new MainForm());
        }
    }
}
