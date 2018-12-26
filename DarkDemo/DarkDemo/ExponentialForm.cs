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
    public partial class ExponentialForm : Form
    {
        public ExponentialForm()
        {
            InitializeComponent();
        }

        private void donebtn_Click_1(object sender, EventArgs e)
        {
            ArithmeticController.number = angleTxtBox.Text;
            this.Close();
        }

        private void ExponentialForm_Load(object sender, EventArgs e)
        {
            this.Location = new System.Drawing.Point(625, 400);
            this.donebtn.Enabled = false;
        }

        private void angleTxtBox_TextChanged_1(object sender, EventArgs e)
        {
            donebtn.Enabled = true;
            if (angleTxtBox.Text == "")
            {
                donebtn.Enabled = false;
            }
        }
    }
}
