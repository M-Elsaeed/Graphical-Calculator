using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarkDemo
{
    public class matrixContoller
    {
        public MatrixForm matrixForm;

        public matrixContoller()
        {
            
        }

        public void showForm()
        {
            Program.home.Hide();
            matrixForm = new MatrixForm();
            matrixForm.Show();
        }

        public void closeForm()
        {
            matrixForm.Close();
            Program.home.Show();
        }
    }
}
