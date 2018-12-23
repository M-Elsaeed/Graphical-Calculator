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
using LoreSoft.MathExpressions;

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
        private void drawGraph()
        {

            // Declaring 
            List<float> xs = new List<float>(), ys = new List<float>(), xss = new List<float>(), yss = new List<float>();
            //Getting Range
            float from = float.Parse(fromText.Text), to = float.Parse(toText.Text);
            //getting eqn
            string eqn = eqnText.Text;
            //Scaling Parameters
            float PANELX = graphPnl.Size.Width;
            float PANELY = graphPnl.Size.Height;
            float fMax = float.MinValue;
            float fMin = float.MaxValue;
            // Computing Points
            MathEvaluator me = new MathEvaluator();
            float j = from;
            while (j < to)
            {
                string xString = eqn.Replace("x", ("(" + j + ")"));
                xString = xString.Replace("X", ("(" + j + ")"));
                float y = (float)me.Evaluate(xString);
                float x = j;
                fMax = (y > fMax) ? y : fMax;
                fMin = (y < fMin) ? y : fMin;
                xs.Add(x);
                ys.Add(-(y));
                j += 0.001f;
            }
            // Scaling X values
            xss.Add(from);
            float factor = PANELX / (to - from);
            for (int i = 1; i < xs.Count; i++)
            {
                xss.Add(xss[i - 1] + (Math.Abs((xs[i] - xs[i - 1])) * factor));
                //xs[i] = xs[i - 2] + (Math.Abs((xs[i-1] - xs[i - 2])) * factor);
            }
            // Scaling Y values
            factor = PANELY / (fMax - fMin);
            for (int i = 0; i < ys.Count; i++)
            {
                ys[i] = ys[i] * factor;
            }
            // Drawing From Computed Data
            Pen blackpen = new Pen(Color.Red, 3);
            Graphics g = graphPnl.CreateGraphics();
            g.Clear(graphPnl.BackColor);
            for (int i = 1; i < xs.Count; i++)
            {
                g.DrawLine(blackpen, xss[i - 1] - from, ys[i - 1] + (fMax * factor), xss[i] - from, ys[i] + (fMax * factor));
            }
            g.Dispose();
        }
        private void graphBtn_Click(object sender, EventArgs e)
        {
            drawGraph();
        }
    }
}
