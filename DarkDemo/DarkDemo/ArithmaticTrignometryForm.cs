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
    public partial class ArithmaticTrignometryForm : Form
    {
        public ArithmaticTrignometryForm()
        {
            InitializeComponent();
        }

        private void donebtn_Click(object sender, EventArgs e)
        {
            Program.arithmeticController.angle = angleTxtBox.Text;
            this.Close();
        }

        private void ArithmaticTrignometryForm_Load(object sender, EventArgs e)
        {
            this.Location = new System.Drawing.Point(625, 400);
            this.donebtn.Enabled = false;
        }

        private void angleTxtBox_TextChanged(object sender, EventArgs e)
        {
            donebtn.Enabled = true;
            if (angleTxtBox.Text == "")
            {
                donebtn.Enabled = false;
            }
        }
    }
}
