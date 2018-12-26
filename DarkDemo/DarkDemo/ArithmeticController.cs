using System;
using System.Windows.Forms;
using LoreSoft.MathExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarkDemo
{
    class ArithmeticController : Controller
    {
        public ArithmaticTrignometryForm arithmaticTrignometryForm = new ArithmaticTrignometryForm();
        public ExponentialForm exponentialForm = new ExponentialForm();
        public ArithmeticForm arithmetic;
        public static string angle  = "";
        public static string number = "";
        public static string eqnToEvaluate = "";

        public ArithmeticController()
        {
            arithmaticTrignometryForm = new ArithmaticTrignometryForm();
        }

        override public void showForm()
        {
            hideHome();
            arithmetic = new ArithmeticForm();
            arithmetic.Show();
        }

        override public void closeForm()
        {
            arithmetic.Close();
            showHome();
        }

        public void writeSimpleArithmatic(Button button, TextBox equationTxtBox)
        {
            equationTxtBox.Text = equationTxtBox.Text + button.Text;
            eqnToEvaluate = eqnToEvaluate + button.Text;
        }

        public void equals(TextBox equationTxtBox)
        {
            MathEvaluator me = new MathEvaluator();
            equationTxtBox.Text = me.Evaluate(eqnToEvaluate) + "";
            Program.historyController.addEquation(eqnToEvaluate);
            Program.historyController.addResult((float)me.Evaluate(eqnToEvaluate));
        }

        public void clear(TextBox equationTxtBox)
        {
            equationTxtBox.Text = "";
            eqnToEvaluate = "";
        }
    }
}
