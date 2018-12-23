using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarkDemo
{
    class graphController
    {
        public GraphForm graphForm;

        public void showForm()
        {
            Program.home.Hide();
            graphForm = new GraphForm();
            graphForm.Show();
        }

        public void closeForm()
        {
            graphForm.Close();
            Program.home.Show();
        }
    }
}