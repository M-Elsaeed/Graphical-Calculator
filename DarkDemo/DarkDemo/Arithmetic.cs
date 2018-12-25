using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DarkDemo
{
    public partial class Arithmetic : Form
    {
        public Arithmetic()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Program.arithmeticController.closeApplication();
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            Program.arithmeticController.closeForm();
        }

        private void Arithmetic_Load(object sender, EventArgs e)
        {
            this.Location = new System.Drawing.Point(200, 100);
        }
    }
}
