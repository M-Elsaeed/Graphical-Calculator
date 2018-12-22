using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace DarkDemo
{
    public partial class Graph : Form
    {
        public Graph()
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
            ArrayList ys = new ArrayList(), xs = new ArrayList();

        }

        private void Graph_Load(object sender, EventArgs e)
        {

        }
    }
}
