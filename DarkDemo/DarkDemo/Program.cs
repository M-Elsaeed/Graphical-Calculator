﻿using System;
using System.Windows.Forms;

namespace DarkDemo
{
    static class Program
    {
        public static Home home;

        //Define Controllers
        public static matrixContoller      matrixContoller;
        public static graphController      graphController;
        public static calculusController   calculusController;
        public static arithmeticController arithmeticController;

        [STAThread]

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Initialize Controllers
            matrixContoller      = new matrixContoller();
            graphController      = new graphController();
            calculusController   = new calculusController();
            arithmeticController = new arithmeticController();

            //Load Main Form
            home = new Home();
            Application.Run(home);
        }
    }
}
