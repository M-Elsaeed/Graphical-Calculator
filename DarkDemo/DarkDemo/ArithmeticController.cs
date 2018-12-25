using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarkDemo
{
    class arithmeticController
    {
        public Arithmetic arithmetic;

        public void showForm()
        {
            Program.home.Hide();
            arithmetic = new Arithmetic();
            arithmetic.Show();
        }

        public void closeForm()
        {
            arithmetic.Close();
            Program.home.Show();
        }

        public void closeApplication()
        {
            Application.Exit();
        }
    }
}
