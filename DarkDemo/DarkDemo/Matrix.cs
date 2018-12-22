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
    public partial class Matrix : Form
    {
        List<List<TextBox>> textBox;
        List<List<int>>     matrix;

        bool firstOrSecond = false;
        List<List<int>> matrix1;
        List<List<int>> matrix2;

        public Matrix()
        {
            InitializeComponent();
            saveBtn.Enabled = false;
        }

        private void makeMatrix_Click(object sender, EventArgs e)
        {
            textBox = new List<List<TextBox>>();
            for (int i = 0; i < Convert.ToInt16(rowTxtBox.Text); i++)
            {
                textBox.Add(new List<TextBox>());
                for (int j = 0; j < Convert.ToInt16(columnTxtBox.Text); j++)
                {
                    textBox[i].Add(new TextBox());
                    textBox[i][j].Size = new Size(50, 50);
                    if (!firstOrSecond)
                    {
                        textBox[i][j].Location = new Point(250 + i * 75, 250 + j * 75);
                    }
                    else
                    {
                        textBox[i][j].Location = new Point(650 + i * 75, 250 + j * 75);
                    }
                    textBox[i][j].ForeColor = Color.FromArgb(192, 192, 0);
                    textBox[i][j].BackColor = Color.FromArgb(41, 44, 51);
                    textBox[i][j].Text = "0";
                    this.Controls.Add(textBox[i][j]);
                }
            }
            saveBtn.Enabled = true;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            matrix = new List<List<int>>();
            for (int i = 0; i < Convert.ToInt16(rowTxtBox.Text); i++)
            {
                matrix.Add(new List<int>());
                for (int j = 0; j < Convert.ToInt16(columnTxtBox.Text); j++)
                {
                    matrix[i].Add(new int());
                    matrix[i][j] = Convert.ToInt16(textBox[i][j].Text);
                }
            }

            if (firstOrSecond)
            {
                matrix1 = new List<List<int>>(matrix);
            }
            else
            {
                matrix2 = new List<List<int>>(matrix);
            }

            for (int i = 0; i < Convert.ToInt16(rowTxtBox.Text); i++)
            {
                for (int j = 0; j < Convert.ToInt16(columnTxtBox.Text); j++)
                {
                    textBox[i][j].Enabled=false;
                }
            }

            saveBtn.Enabled = false;
            firstOrSecond = true;
        }
    }
}
