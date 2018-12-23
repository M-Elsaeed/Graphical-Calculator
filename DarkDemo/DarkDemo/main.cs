using System;
using System.Windows.Forms;

namespace DarkDemo
{
    static class Program
    {
        public static Home home;

        [STAThread]

        static void main()
        {
            

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            home = new Home();
            Application.Run(home);
        }
    }
}
