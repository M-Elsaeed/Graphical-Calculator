using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoreSoft.MathExpressions;

namespace DarkDemo
{
    class CalculusController
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

        public void Differentiate(TextBox eqnTextBox,TextBox limitTxtBox,Label resultLbl)
        {
            string eqn = eqnTextBox.Text;

            MathEvaluator me = new MathEvaluator();

            double limit = double.Parse(limitTxtBox.Text);

            double limitX1 = limit - 0.0001;
            double limitX2 = limit + 0.0001;

            string xString1 = eqn.Replace("x", ("(" + limitX1 + ")"));
            xString1 = xString1.Replace("X", ("(" + limitX1 + ")"));

            double y1 = me.Evaluate(xString1);

            string xString2 = eqn.Replace("x", ("(" + limitX2 + ")"));
            xString2 = xString2.Replace("X", ("(" + limitX2 + ")"));

            float y2 = (float)me.Evaluate(xString2);

            resultLbl.Text = (y1 - y2) / (limitX1 - limitX2) + "";
        }

        public void Integrate(TextBox eqnTextBox, TextBox fromTxtBox, TextBox toTxtBox, Label resultLbl)
        {
            MathEvaluator me = new MathEvaluator();
            string eqn = eqnTextBox.Text;
            double area = 0;
            double from = double.Parse(fromTxtBox.Text);
            double to = double.Parse(toTxtBox.Text);

            double sliceWidth = 0.01;

            List<double> ys = new List<double>();

            while (to>=from)
            {
                string xString = eqn.Replace("x", ("(" + from + ")"));
                xString = xString.Replace("X", ("(" + from + ")"));

                ys.Add(me.Evaluate(xString));

                from = from + sliceWidth;
            }

            for (int i = 0; i < ys.Count-1; i++)
            {
                area = area + 0.5 * (ys[i] + ys[i + 1])*(sliceWidth);
            }
            resultLbl.Text = area + "";
        }
    }
}
