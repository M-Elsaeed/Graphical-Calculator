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
            List<float> xs = new List<float>(), ys = new List<float>();
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
            float factorX = PANELX / (to - from);
            for (int i = 0; i < xs.Count; i++)
            {
                xs[i] = xs[i] * factorX;
            }
            // Scaling Y values
            float factorY = PANELY / (fMax - fMin);
            for (int i = 0; i < ys.Count; i++)
            {
                ys[i] = ys[i] * factorY;
            }
            // Drawing From Computed Data
            Pen graphPen = new Pen(Color.Red, 3);
            Pen axisPen = new Pen(Color.White, 3);
            Graphics g = graphPnl.CreateGraphics();
            g.Clear(graphPnl.BackColor);
            //Draw X axis
            g.DrawLine(axisPen, 0, (fMax * factorY), PANELX, (fMax * factorY));
            //Drawing Y axix
            g.DrawLine(axisPen, -(from * factorX), 0, -(from * factorX), PANELY);
            //Drawing Graph
            for (int i = 1; i < xs.Count; i++)
            {
                g.DrawLine(graphPen, xs[i - 1] - (from * factorX), ys[i - 1] + (fMax * factorY), xs[i] - (from * factorX), ys[i] + (fMax * factorY));
            }
            g.Dispose();
        }
        private void graphBtn_Click(object sender, EventArgs e)
        {
            drawGraph();
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
