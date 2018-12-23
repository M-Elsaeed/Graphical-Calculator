using System;
using System.Windows.Forms;

namespace DarkDemo
{
    static class Program
    {
        public static Home home;

        //intialize controllers
        public static matrixContoller matrixContoller;
        public static GraphForm graph;
        [STAThread]

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            matrixContoller = new matrixContoller();
            graph = new GraphForm();

            home = new Home();
            Application.Run(new GraphForm());
        }
    }
}
