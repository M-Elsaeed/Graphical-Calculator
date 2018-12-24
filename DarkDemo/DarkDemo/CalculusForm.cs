using System;
using System.Windows.Forms;


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

        private void differentiateBtn_Click(object sender, EventArgs e)
        {
            Program.calculusController.Differentiate(difeqnTextBox, limitTxtBox, resultLbl);
        }

        private void integrateBtn_Click(object sender, EventArgs e)
        {
            Program.calculusController.Integrate(intequTxtBox, fromTxtBox, toTxtBox, intResultLbl);
        }

        private void CalculusForm_Load(object sender, EventArgs e)
        {
            this.Location = new System.Drawing.Point(200, 100);
        }
    }
}
