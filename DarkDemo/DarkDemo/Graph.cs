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
            ArrayList xs = new ArrayList(), ys = new ArrayList();
            float min = float.Parse(fromText.Text), max = float.Parse(toText.Text);
            min = -500;max = 500;
            float j = min;
            while (j < max)
            {
                xs.Add(j);
                ys.Add(-(j * j));
                j += 0.001f;

            }

            Pen blackpen = new Pen(Color.Red, 3);
            Graphics g = graphPnl.CreateGraphics();
            for (int i = 1; i < xs.Count; i++)
            {
                g.DrawLine(blackpen, (float)xs[i - 1] + 500, (float)ys[i - 1]+(500*500), (float)xs[i] + 500, (float)ys[i]+ (500 * 500));
            }
            g.Dispose();

        }

        private void Graph_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
