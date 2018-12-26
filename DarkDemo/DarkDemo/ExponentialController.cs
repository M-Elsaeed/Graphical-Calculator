using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DarkDemo
{
    class ExponentialController
    {
        public void exp(Button button, TextBox equationTxtBox)
        {
            switch (button.Text)
            {
                case "Square Root":
                    ExponentialForm exponentialForm = new ExponentialForm();
                    exponentialForm.ShowDialog();
                    equationTxtBox.Text = equationTxtBox.Text + "√" + number;
                    eqnToEvaluate = eqnToEvaluate + "" + number + "^ 0.5";
                    break;
                case "Log":
                    exponentialForm = new ExponentialForm();
                    exponentialForm.ShowDialog();
                    equationTxtBox.Text = equationTxtBox.Text + "log(" + number + ")";
                    eqnToEvaluate = eqnToEvaluate + "log(" + number + ")";
                    break;
                case "Ln":
                    exponentialForm = new ExponentialForm();
                    exponentialForm.ShowDialog();
                    equationTxtBox.Text = equationTxtBox.Text + "ln(" + number + ")";
                    eqnToEvaluate = eqnToEvaluate + "Log(" + number + ") / Log(e)";
                    break;
            }
        }
    }
}
