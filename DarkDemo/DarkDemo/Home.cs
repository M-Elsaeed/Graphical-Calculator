using System;
using System.Windows.Forms;
using LoreSoft.MathExpressions;

namespace DarkDemo
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void matrixBtn_Click(object sender, EventArgs e)
        {
            Program.matrixContoller.showForm(); 
        }

        private void graphBtn_Click(object sender, EventArgs e)
        {
            Program.graphController.showForm();
        }

        private void calculusBtn_Click(object sender, EventArgs e)
        {
            Program.calculusController.showForm();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            this.Location=new System.Drawing.Point(200,100);
        }
    }
}
