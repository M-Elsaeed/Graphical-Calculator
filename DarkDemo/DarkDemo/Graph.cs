﻿using System;
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
            List<float> xs = new List<float>(), ys = new List<float>();
            float from = float.Parse(fromText.Text), to = float.Parse(toText.Text);
            float PANELX = graphPnl.Size.Width;
            float PANELY = graphPnl.Size.Height;
            float fMax = float.MinValue;
            float fMin = float.MaxValue;
            float j = from;
            while (j < to)
            {
                float y = j*j*j*j;
                float x = j;
                fMax = (y > fMax) ? y : fMax;
                fMin = (y < fMin) ? y : fMin;
                xs.Add(x);
                ys.Add(-(y));
                j += 0.001f;
            }
            List<float> xss = new List<float>(), yss = new List<float>();
            xss.Add(from);
            float factor = PANELX / (to - from);
            for (int i = 1; i < xs.Count; i++)
            {
                xss.Add(xss[i - 1] + (Math.Abs((xs[i] - xs[i - 1])) * factor));
            }
            factor = PANELY / (fMax - fMin);
            for (int i = 0; i < ys.Count; i++)
            {                
                ys[i] = ys[i] * factor;                
            }            
            Pen blackpen = new Pen(Color.Red, 3);
            Graphics g = graphPnl.CreateGraphics();
            g.Clear(graphPnl.BackColor);
            for (int i = 1; i < xs.Count; i++)
            {
                g.DrawLine(blackpen, xss[i - 1] - from, ys[i - 1] + (fMax*factor), xss[i] - from, ys[i] + (fMax*factor));
            }
            g.Dispose();
        }
    }
}
