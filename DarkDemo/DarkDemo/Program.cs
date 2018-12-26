using System;
using System.Windows.Forms;

namespace DarkDemo
{
    static class Program
    {
        public static Home home;

        //Define Controllers
        public static MatrixContoller matrixContoller;
        public static GraphController graphController;
        public static HistoryController historyController;
        public static CalculusController calculusController;
        public static ArithmeticController arithmeticController;
        public static TrignometeryController trignometeryController;
        public static ExponentialController exponentialController;

        [STAThread]

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Forms Initialization
            matrixContoller = new MatrixContoller();
            graphController = new GraphController();
            historyController = new HistoryController();
            calculusController = new CalculusController();
            arithmeticController = new ArithmeticController();
            trignometeryController = new TrignometeryController();
            exponentialController = new ExponentialController();
            //Load Main Form
            home = new Home();
            Application.Run(home);
        }
    }
}
