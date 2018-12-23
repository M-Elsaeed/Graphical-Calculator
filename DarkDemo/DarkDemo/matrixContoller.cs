using System;
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
            matrixForm = new MatrixForm();
        }

        public void showForm()
        {
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
