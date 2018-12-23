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
    }
}
