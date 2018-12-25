using System;
using System.Windows.Forms;


namespace DarkDemo
{
    public partial class GraphForm : Form
    {
        public GraphForm()
        {
            InitializeComponent();
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            Program.home.Show();
            Close();
        }
       
        private void graphBtn_Click(object sender, EventArgs e)
        {
            Program.graphController.drawGraph(this.graphPnl,this.fromText,this.toText,this.eqnText);
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Program.graphController.closeForm();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void GraphForm_Load(object sender, EventArgs e)
        {
            this.Location = new System.Drawing.Point(200, 100);
        }

        private void homeBtn_Click_1(object sender, EventArgs e)
        {
            Program.graphController.closeForm();
        }
    }
}
