using System;
using System.Windows.Forms;
using LoreSoft.MathExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarkDemo
{
    class ArithmeticController
    {
        public ArithmaticTrignometryForm arithmaticTrignometryForm = new ArithmaticTrignometryForm();
        public ExponentialForm exponentialForm = new ExponentialForm();
        public ArithmeticForm arithmetic;
        public string angle  = "";
        public string number = "";
        string eqnToEvaluate = "";

        public ArithmeticController()
        {
            arithmaticTrignometryForm = new ArithmaticTrignometryForm();
        }

        public void showForm()
        {
            Program.home.Hide();
            arithmetic = new ArithmeticForm();
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

        public void writeSimpleArithmatic(Button button, TextBox equationTxtBox)
        {
            equationTxtBox.Text = equationTxtBox.Text + button.Text;
            eqnToEvaluate = eqnToEvaluate + button.Text;
        }

        public void equals(TextBox equationTxtBox)
        {
            MathEvaluator me = new MathEvaluator();
            equationTxtBox.Text = me.Evaluate(eqnToEvaluate) + "";
        }

        public void clear(TextBox equationTxtBox)
        {
            equationTxtBox.Text = "";
            eqnToEvaluate = "";
        }

        public void trignometry(Button button, TextBox equationTxtBox)
        {
            switch (button.Text)
            {
                case "sin":
                    ArithmaticTrignometryForm arithmaticTrignometryForm = new ArithmaticTrignometryForm();
                    arithmaticTrignometryForm.ShowDialog();
                    equationTxtBox.Text = equationTxtBox.Text + "sin(" + angle + ")";
                    eqnToEvaluate = eqnToEvaluate + "(sin(" + angle + "))";
                    break;
                case "cos":
                    arithmaticTrignometryForm = new ArithmaticTrignometryForm();
                    arithmaticTrignometryForm.ShowDialog();
                    equationTxtBox.Text = equationTxtBox.Text + "cos(" + angle + ")";
                    eqnToEvaluate = eqnToEvaluate + "(cos(" + angle + "))";
                    break;
                case "tan":
                    arithmaticTrignometryForm = new ArithmaticTrignometryForm();
                    arithmaticTrignometryForm.ShowDialog();
                    equationTxtBox.Text = equationTxtBox.Text + "tan(" + angle + ")";
                    eqnToEvaluate = eqnToEvaluate + "(tan(" + angle + "))";
                    break;
                case "sin-1":
                    arithmaticTrignometryForm = new ArithmaticTrignometryForm();
                    arithmaticTrignometryForm.ShowDialog();
                    equationTxtBox.Text = equationTxtBox.Text + "sin-1(" + angle + ")";
                    eqnToEvaluate = eqnToEvaluate + "(asin(" + angle + "))";
                    break;
                case "cos-1":
                    arithmaticTrignometryForm = new ArithmaticTrignometryForm();
                    arithmaticTrignometryForm.ShowDialog();
                    equationTxtBox.Text = equationTxtBox.Text + "cos-1(" + angle + ")";
                    eqnToEvaluate = eqnToEvaluate + "(acos(" + angle + "))";
                    break;
                case "tan-1":
                    arithmaticTrignometryForm = new ArithmaticTrignometryForm();
                    arithmaticTrignometryForm.ShowDialog();
                    equationTxtBox.Text = equationTxtBox.Text + "tan-1(" + angle + ")";
                    eqnToEvaluate = eqnToEvaluate + "(atan(" + angle + "))";
                    break;
                case "sec":
                    arithmaticTrignometryForm = new ArithmaticTrignometryForm();
                    arithmaticTrignometryForm.ShowDialog();
                    equationTxtBox.Text = equationTxtBox.Text + "sec(" + angle + ")";
                    eqnToEvaluate = eqnToEvaluate + "(1 / cos(" + angle + "))";
                    break;
                case "cosec":
                    arithmaticTrignometryForm = new ArithmaticTrignometryForm();
                    arithmaticTrignometryForm.ShowDialog();
                    equationTxtBox.Text = equationTxtBox.Text + "sec(" + angle + ")";
                    eqnToEvaluate = eqnToEvaluate + "(1 / sin(" + angle + "))";
                    break;
                case "cotan":
                    arithmaticTrignometryForm = new ArithmaticTrignometryForm();
                    arithmaticTrignometryForm.ShowDialog();
                    equationTxtBox.Text = equationTxtBox.Text + "cotan(" + angle + ")";
                    eqnToEvaluate = eqnToEvaluate + "(1 / tan(" + angle + "))";
                    break;
                case "sec-1":
                    arithmaticTrignometryForm = new ArithmaticTrignometryForm();
                    arithmaticTrignometryForm.ShowDialog();
                    equationTxtBox.Text = equationTxtBox.Text + "sec-1(" + angle + ")";
                    eqnToEvaluate = eqnToEvaluate + "(acos(1/" + angle + "))";
                    break;
                case "cosec-1":
                    arithmaticTrignometryForm = new ArithmaticTrignometryForm();
                    arithmaticTrignometryForm.ShowDialog();
                    equationTxtBox.Text = equationTxtBox.Text + "sec(" + angle + ")";
                    eqnToEvaluate = eqnToEvaluate + "(asin(1/" + angle + "))";
                    break;
                case "cotan-1":
                    arithmaticTrignometryForm = new ArithmaticTrignometryForm();
                    arithmaticTrignometryForm.ShowDialog();
                    equationTxtBox.Text = equationTxtBox.Text + "sec(" + angle + ")";
                    eqnToEvaluate = eqnToEvaluate + "(atan(1/" + angle + "))";
                    break;
                case "sinh":
                    arithmaticTrignometryForm = new ArithmaticTrignometryForm();
                    arithmaticTrignometryForm.ShowDialog();
                    equationTxtBox.Text = equationTxtBox.Text + "sinh(" + angle + ")";
                    eqnToEvaluate = eqnToEvaluate + "(((Exp(" + angle + ") - Exp(" + "-" + angle + ")) / 2))";
                    break;
                case "cosh":
                    arithmaticTrignometryForm = new ArithmaticTrignometryForm();
                    arithmaticTrignometryForm.ShowDialog();
                    equationTxtBox.Text = equationTxtBox.Text + "cosh(" + angle + ")";
                    eqnToEvaluate = eqnToEvaluate + "(((Exp(" + angle + ") + Exp(" + "-" + angle + ")) / 2))";
                    break;
                case "tanh":
                    arithmaticTrignometryForm = new ArithmaticTrignometryForm();
                    arithmaticTrignometryForm.ShowDialog();
                    equationTxtBox.Text = equationTxtBox.Text + "tanh(" + angle + ")";
                    eqnToEvaluate = eqnToEvaluate + "(((Exp(" + angle + ") - Exp(" + "-" + angle + ")) / ((Exp(" + angle + ") + Exp(" + "-" + angle + ")))))";
                    break;
                case "sech":
                    arithmaticTrignometryForm = new ArithmaticTrignometryForm();
                    arithmaticTrignometryForm.ShowDialog();
                    equationTxtBox.Text = equationTxtBox.Text + "sech(" + angle + ")";
                    eqnToEvaluate = eqnToEvaluate + "((2 / (Exp(" + angle + ") + Exp(" + "-" + angle + "))))";
                    break;
                case "cosech":
                    arithmaticTrignometryForm = new ArithmaticTrignometryForm();
                    arithmaticTrignometryForm.ShowDialog();
                    equationTxtBox.Text = equationTxtBox.Text + "cosech(" + angle + ")";
                    eqnToEvaluate = eqnToEvaluate + "((2 / (Exp(" + angle + ") - Exp(" + "-" + angle + "))))";
                    break;
                case "cotanh":
                    arithmaticTrignometryForm = new ArithmaticTrignometryForm();
                    arithmaticTrignometryForm.ShowDialog();
                    equationTxtBox.Text = equationTxtBox.Text + "tanh(" + angle + ")";
                    eqnToEvaluate = eqnToEvaluate + "((2 / (Exp(" + angle + ") + Exp(" + "-" + angle + "))) / (2 / (Exp(" + angle + ") - Exp(" + "-" + angle + "))))";
                    break;
                case "sinh-1":
                    arithmaticTrignometryForm = new ArithmaticTrignometryForm();
                    arithmaticTrignometryForm.ShowDialog();
                    equationTxtBox.Text = equationTxtBox.Text + "sinh-1(" + angle + ")";
                    eqnToEvaluate = eqnToEvaluate + "(Log(" + angle + " + ((" + angle + " * " + angle + " + 1)^0.5))) ";
                    break;
                case "cosh-1":
                    arithmaticTrignometryForm = new ArithmaticTrignometryForm();
                    arithmaticTrignometryForm.ShowDialog();
                    equationTxtBox.Text = equationTxtBox.Text + "cosh-1(" + angle + ")";
                    eqnToEvaluate = eqnToEvaluate + "(Log(" + angle + " + ((" + angle + " * " + angle + " - 1)^0.5))) ";
                    break;
                case "tanh-1":
                    arithmaticTrignometryForm = new ArithmaticTrignometryForm();
                    arithmaticTrignometryForm.ShowDialog();
                    equationTxtBox.Text = equationTxtBox.Text + "tanh-1(" + angle + ")";
                    eqnToEvaluate = eqnToEvaluate + "((Log((1 + " + angle + ") / (1 - " + angle + ")) / 2 ))";
                    break;
                case "sech-1":
                    arithmaticTrignometryForm = new ArithmaticTrignometryForm();
                    arithmaticTrignometryForm.ShowDialog();
                    equationTxtBox.Text = equationTxtBox.Text + "sech-1(" + angle + ")";
                    eqnToEvaluate = eqnToEvaluate + "(Log((((-" + angle + " * " + angle + " + 1)^0.5) + 1) / " + angle + "))";
                    break;
                case "cosech-1":
                    arithmaticTrignometryForm = new ArithmaticTrignometryForm();
                    arithmaticTrignometryForm.ShowDialog();
                    equationTxtBox.Text = equationTxtBox.Text + "cosech-1(" + angle + ")";
                    eqnToEvaluate = eqnToEvaluate + "(Log((" + Math.Sign(Convert.ToInt16(angle)) + " * ((" + angle + " * " + angle + " + 1)^0.5) + 1) / " + angle + "))";
                    break;
                case "cotanh-1":
                    arithmaticTrignometryForm = new ArithmaticTrignometryForm();
                    arithmaticTrignometryForm.ShowDialog();
                    equationTxtBox.Text = equationTxtBox.Text + "cotanh-1(" + angle + ")";
                    eqnToEvaluate = eqnToEvaluate + "((Log((" + angle + " + 1) / (" + angle + " - 1)) / 2))";
                    break;
            }
        }

        public void exp(Button button, TextBox equationTxtBox)
        {
            switch (button.Text)
            {
                case "Square Root":
                    ExponentialForm exponentialForm = new ExponentialForm();
                    exponentialForm.ShowDialog();
                    equationTxtBox.Text = equationTxtBox.Text + "√"+number;
                    eqnToEvaluate = eqnToEvaluate + ""+number+"^ 0.5";
                    break;
                case "Log":
                    exponentialForm = new ExponentialForm();
                    exponentialForm.ShowDialog();
                    equationTxtBox.Text = equationTxtBox.Text + "log("+number+")";
                    eqnToEvaluate = eqnToEvaluate + "log(" + number + ")";
                    break;
                case "Ln":
                    exponentialForm = new ExponentialForm();
                    exponentialForm.ShowDialog();
                    equationTxtBox.Text = equationTxtBox.Text + "ln(" + number + ")";
                    eqnToEvaluate = eqnToEvaluate + "Log("+number+") / Log(e)";
                    break;
            }
        }
    }
}
