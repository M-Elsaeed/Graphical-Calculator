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
    public partial class MatrixForm : Form
    {
        List<List<TextBox>> textboxes;
        List<List<int>> matrix;

        int counter = 0;

        List<List<int>> matrix1;
        int rowM1 = 0;
        int columnM1 = 0;
        List<List<int>> matrix2;
        int rowM2 = 0;
        int columnM2 = 0;
        List<List<int>> matrix3;

        public MatrixForm()
        {
            InitializeComponent();
            saveBtn.Enabled = false;
            columnTxtBox.Text = "0";
            rowTxtBox.Text = "0";
            plusBtn.Enabled = false;
            minusBtn.Enabled = false;
            multiplyBtn.Enabled = false;
        }

        private void makeMatrix_Click(object sender, EventArgs e)
        {
            counter++;
            textboxes = new List<List<TextBox>>();

            for (int i = 0; i < Convert.ToInt16(columnTxtBox.Text); i++)
            {
                textboxes.Add(new List<TextBox>());
                for (int j = 0; j < Convert.ToInt16(rowTxtBox.Text); j++)
                {
                    textboxes[i].Add(new TextBox());
                    textboxes[i][j].Size = new Size(50, 50);
                    if (counter == 1)
                    {
                        textboxes[i][j].Location = new Point(250 + i * 75, 250 + j * 75);
                    }
                    else if (counter == 2)
                    {
                        textboxes[i][j].Location = new Point(650 + i * 75, 250 + j * 75);
                    }
                    else
                    {
                        textboxes[i][j].Location = new Point(450 + i * 75, 500 + j * 75);
                    }
                    textboxes[i][j].ForeColor = Color.FromArgb(192, 192, 0);
                    textboxes[i][j].BackColor = Color.FromArgb(41, 44, 51);
                    textboxes[i][j].Text = "0";
                    this.Controls.Add(textboxes[i][j]);
                }
            }

            saveBtn.Enabled = true;
            makeMatrix.Enabled = false;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            matrix = new List<List<int>>();
            for (int i = 0; i < Convert.ToInt16(columnTxtBox.Text); i++)
            {
                matrix.Add(new List<int>());
                for (int j = 0; j < Convert.ToInt16(rowTxtBox.Text); j++)
                {
                    matrix[i].Add(new int());
                    matrix[i][j] = Convert.ToInt16(textboxes[i][j].Text);
                }
            }

            if (counter == 1)
            {
                matrix1 = new List<List<int>>(matrix);
                makeMatrix.Enabled = true;
                rowM1 = Convert.ToInt16(rowTxtBox.Text);
                columnM1 = Convert.ToInt16(columnTxtBox.Text);
            }
            else
            {
                matrix2 = new List<List<int>>(matrix);
                makeMatrix.Enabled = false;
                rowM2 = Convert.ToInt16(rowTxtBox.Text);
                columnM2 = Convert.ToInt16(columnTxtBox.Text);
                if (rowM1 == rowM2 && columnM1 == columnM2)
                {
                    plusBtn.Enabled = true;
                    minusBtn.Enabled = true;
                }
                if (columnM1 == rowM2)
                {
                    multiplyBtn.Enabled = true;
                }
            }

            for (int i = 0; i < Convert.ToInt16(columnTxtBox.Text); i++)
            {
                for (int j = 0; j < Convert.ToInt16(rowTxtBox.Text); j++)
                {
                    textboxes[i][j].Enabled = false;
                }
            }

            saveBtn.Enabled = false;

        }

        public void print(List<List<int>> m)
        {
            for (int i = 0; i < Convert.ToInt16(columnTxtBox.Text); i++)
            {
                for (int j = 0; j < Convert.ToInt16(rowTxtBox.Text); j++)
                {
                    MessageBox.Show(m[i][j] + "");
                }
            }
        }

        private void plusBtn_Click(object sender, EventArgs e)
        {
            matrix3 = new List<List<int>>(matrix);

            for (int i = 0; i < Convert.ToInt16(columnTxtBox.Text); i++)
            {
                for (int j = 0; j < Convert.ToInt16(rowTxtBox.Text); j++)
                {
                    matrix3[i][j] = matrix1[i][j] + matrix2[i][j];
                }
            }

            makeMatrix_Click(sender, e);

            for (int i = 0; i < rowM1; i++)
            {
                for (int j = 0; j < columnM1; j++)
                {
                    textboxes[i][j].Text = matrix3[i][j] + "";
                }
            }


        }

        private void minusBtn_Click(object sender, EventArgs e)
        {
            matrix3 = new List<List<int>>(matrix);

            for (int i = 0; i < Convert.ToInt16(columnTxtBox.Text); i++)
            {
                for (int j = 0; j < Convert.ToInt16(rowTxtBox.Text); j++)
                {
                    matrix3[i][j] = matrix1[i][j] - matrix2[i][j];
                }
            }

            makeMatrix_Click(sender, e);

            for (int i = 0; i < rowM1; i++)
            {
                for (int j = 0; j < columnM1; j++)
                {
                    textboxes[i][j].Text = matrix3[i][j] + "";
                }
            }
        }

        private void multiplyBtn_Click(object sender, EventArgs e)
        {
            matrix3 = new List<List<int>>(matrix);

            if (rowM1==columnM2)
            {
                for (int i = 0; i < rowM1; i++)
                    for (int j = 0; j < rowM1; j++)
                        matrix3[i][j] = 0;

                for (int i = 0; i < rowM1 ; i++)
                {
                    for (int j = 0; j < rowM1; j++)
                    {
                        for (int k = 0; k < rowM1; k++)
                        {
                            matrix3[i][j] += matrix1[i][k] * matrix2[k][j];
                        }
                    }
                }
            }

            else
            {
                for (int i = 0; i < rowM1; i++)
                    for (int j = 0; j < columnM2; j++)
                    {// compute c[i][j]
                        int sum = 0;
                        for (int k = 0; k < rowM2; k++)
                            sum += matrix1[i][k] * matrix2[k][j];
                        matrix3[i][j] = sum;
                    }
            }

            counter++;
            textboxes = new List<List<TextBox>>();

            for (int i = 0; i < rowM1; i++)
            {
                textboxes.Add(new List<TextBox>());
                for (int j = 0; j < columnM2; j++)
                {
                    textboxes[i].Add(new TextBox());
                    textboxes[i][j].Size = new Size(50, 50);
                    if (counter == 1)
                    {
                        textboxes[i][j].Location = new Point(250 + i * 75, 250 + j * 75);
                    }
                    else if (counter == 2)
                    {
                        textboxes[i][j].Location = new Point(650 + i * 75, 250 + j * 75);
                    }
                    else
                    {
                        textboxes[i][j].Location = new Point(450 + i * 75, 500 + j * 75);
                    }
                    textboxes[i][j].ForeColor = Color.FromArgb(192, 192, 0);
                    textboxes[i][j].BackColor = Color.FromArgb(41, 44, 51);
                    textboxes[i][j].Text = "0";
                    this.Controls.Add(textboxes[i][j]);
                }
            }

            for (int i = 0; i < rowM1; i++)
            {
                for (int j = 0; j < columnM1; j++)
                {
                    textboxes[i][j].Text = matrix3[i][j] + "";
                }
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Program.matrixContoller.closeForm();
        }
    }
}
