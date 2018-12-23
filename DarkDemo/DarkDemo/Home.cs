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

        private void button9_Click(object sender, EventArgs e)
        {

            //DataTable dt = new DataTable();
            //var v = dt.Compute(exp.Text, "");
            //MessageBox.Show(v+"");

            //MathEvaluator me = new MathEvaluator();
            //MessageBox.Show(me.Evaluate(exp.Text)+"");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.matrixContoller.showForm();
            this.Hide();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }
    }
}
