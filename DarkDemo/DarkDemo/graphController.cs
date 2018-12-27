using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using LoreSoft.MathExpressions;

namespace DarkDemo
{
    class GraphController : Controller
    {
        public GraphForm graphForm;

        override public void showForm()
        {
            hideHome();
            graphForm = new GraphForm();
            graphForm.Show();
        }

        override public void closeForm()
        {
            graphForm.Close();
            showHome();
        }

        public void drawGraph(Panel graphPnl, TextBox fromText, TextBox toText, TextBox eqnText)
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
            if (from > 0)
                from = 0;
            if (to < 0)
                to = 0;
            if (fMax < 0)
                fMax = 0;
            if (fMin > 0)
                fMin = 0;
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
    }
}