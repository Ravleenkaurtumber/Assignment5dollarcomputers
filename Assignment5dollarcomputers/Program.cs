using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment5dollarcomputers
{
    
    static class Program
    {
        public static SplashScreen splashscreen;
        public static StartForm startform;
        public static SelectForm selectform;
        public static ProductInfoForm productinfoform;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            splashscreen = new SplashScreen();
            startform = new StartForm();
            selectform = new SelectForm();
            productinfoform = new ProductInfoForm();

            Application.Run(new SplashScreen());
        }
    }
}
