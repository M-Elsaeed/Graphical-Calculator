using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LoreSoft.MathExpressions;

namespace DarkDemo
{
    public partial class CalculusForm : Form
    {
        public CalculusForm()
        {
            InitializeComponent();
            differentiationPnl.Hide();
            integrationPnl.Hide();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Program.calculusController.closeApplication();
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            Program.calculusController.closeForm();
        }

        private void differentiationBtn_Click(object sender, EventArgs e)
        {
            differentiationPnl.Show();
            integrationPnl.Hide();
        }

        private void integrationBtn_Click(object sender, EventArgs e)
        {
            integrationPnl.Show();
            differentiationPnl.Hide();
        }

        private void integrateBtn_Click(object sender, EventArgs e)
        {

        }

        private void differentiateBtn_Click(object sender, EventArgs e)
        {
            string eqn = eqnTextBox.Text;

            MathEvaluator me = new MathEvaluator();

            double limit = double.Parse(limitTxtBox.Text);

            double limitX1 = limit - 0.1;
            double limitX2 = limit + 0.1;

            MessageBox.Show(limitX1 + "");
            MessageBox.Show(limitX2 + "");

            string xString1 = eqn.Replace("x", ("(" + limitX1 + ")"));
            xString1 = xString1.Replace("X", ("(" + limitX1 + ")"));

            MessageBox.Show(xString1 + "");

            double y1 = me.Evaluate(xString1);

            MessageBox.Show(y1 + "");

            string xString2 = eqn.Replace("x", ("(" + limitX2 + ")"));
            xString2 = xString2.Replace("X", ("(" + limitX2 + ")"));

            float y2 = (float)me.Evaluate(xString2);

            MessageBox.Show(y2 + "");

            resultLbl.Text = (y1 - y2) / (limitX1 - limitX2)+"";
        }
    }
}
