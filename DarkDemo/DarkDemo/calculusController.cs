using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarkDemo
{
    class calculusController
    {
        public CalculusForm calculusForm;

        public void showForm()
        {
            Program.home.Hide();
            calculusForm = new CalculusForm();
            calculusForm.Show();
        }

        public void closeForm()
        {
            calculusForm.Close();
            Program.home.Show();
        }

        public void closeApplication()
        {
            Application.Exit();
        }
    }
}
