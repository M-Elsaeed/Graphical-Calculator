using System;
using System.Windows.Forms;

namespace DarkDemo
{
    static class Program
    {
        public static Home home;

        //Define Controllers
        public static matrixContoller matrixContoller;
        public static GraphForm graph;

        [STAThread]

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Initialize Controllers
            matrixContoller = new matrixContoller();
            
            //Load Main Form
            home = new Home();
            Application.Run(home);
        }
    }
}
