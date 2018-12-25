using System;
using System.Windows.Forms;

namespace DarkDemo
{
    static class Program
    {
        public static Home home;

        //Define Controllers
        public static MatrixContoller      matrixContoller;
        public static GraphController      graphController;
        public static CalculusController   calculusController;
        public static ArithmeticController arithmeticController;

        [STAThread]

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Initialize Controllers
            matrixContoller      = new MatrixContoller();
            graphController      = new GraphController();
            calculusController   = new CalculusController();
            arithmeticController = new ArithmeticController();

            //Load Main Form
            home = new Home();
            Application.Run(home);
        }
    }
}
