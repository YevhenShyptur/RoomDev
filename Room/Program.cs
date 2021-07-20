using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Room
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
#if DEBUG == false

            string dbPathMyDocs= Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
          string dbpath=  Path.Combine(dbPathMyDocs, "Room");
            AppDomain.CurrentDomain.SetData("DataDirectory", dbpath);
            
#endif
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
