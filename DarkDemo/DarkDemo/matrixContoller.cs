using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;

namespace DarkDemo
{
    public class MatrixContoller : Controller
    {
        public MatrixForm matrixForm;

        List<List<TextBox>> textboxes;
        List<List<int>> matrix;
        List<List<int>> matrix1;
        List<List<int>> matrix2;
        List<List<int>> matrix3;

        int rowM1 = 0;
        int columnM1 = 0;
        int rowM2 = 0;
        int columnM2 = 0;

        int counter = 0;

        override public void showForm()
        {
            hideHome();
            matrixForm = new MatrixForm();
            matrixForm.Show();
            reset();
        }
        override public void closeForm()
        {
            matrixForm.Close();
            showHome();
            reset();
        }

        public void reset()
        {
            counter = 0;
        }

        public void makeMatrix(int column, int row, Form form, Button makeMatrixBtn, Button saveBtn,TextBox columnTxtBox,TextBox rowTxtBox, Button transposeBtn)
        {
            counter++;
            textboxes = new List<List<TextBox>>();

            for (int i = 0; i < row; i++)
            {
                textboxes.Add(new List<TextBox>());

                for (int j = 0; j < column; j++)
                {
                    textboxes[i].Add(new TextBox());
                    textboxes[i][j].Size = new Size(50, 50);

                    if (counter == 1)
                    {
                        textboxes[i][j].Location = new Point(250 + j * 75, 250 + i * 75);
                    }
                    else if (counter == 2)
                    {
                        textboxes[i][j].Location = new Point(650 + j * 75, 250 + i * 75);
                        transposeBtn.Enabled = false;
                    }
                    else
                    {
                        textboxes[i][j].Location = new Point(450 + j * 75, 500 + i * 75);
                    }

                    textboxes[i][j].ForeColor = Color.FromArgb(192, 192, 0);
                    textboxes[i][j].BackColor = Color.FromArgb(41, 44, 51);
                    textboxes[i][j].Text = "0";
                    form.Controls.Add(textboxes[i][j]);
                }
            }

            saveBtn.Enabled = true;
            makeMatrixBtn.Enabled = false;
            columnTxtBox.Enabled = false;
            rowTxtBox.Enabled = false;
        }

        public void saveMatrix(int column, int row, Form form, Button makeMatrixBtn, Button plusBtn, Button minusBtn, Button multiplyBtn, Button saveBtn,TextBox columnTxtBox, TextBox rowTxtBox,Button transposeBtn)
        {
            matrix = new List<List<int>>();
            for (int i = 0; i < row; i++)
            {
                matrix.Add(new List<int>());
                for (int j = 0; j < column; j++)
                {
                    matrix[i].Add(new int());
                    matrix[i][j] = Convert.ToInt16(textboxes[i][j].Text);
                }
            }

            if (counter == 1)
            {
                matrix1 = new List<List<int>>(matrix);
                makeMatrixBtn.Enabled = true;
                transposeBtn.Enabled = true;
                rowM1 = row;
                columnM1 = column;
            }
            else if(counter == 2)
            {
                matrix2 = new List<List<int>>(matrix);
                makeMatrixBtn.Enabled = false;
                rowM2 = row;
                columnM2 = column;
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

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    textboxes[i][j].Enabled = false;
                }
            }

            saveBtn.Enabled = false;

            columnTxtBox.Enabled = true;
            rowTxtBox.Enabled = true;
            
        }

        public void matrixAddition(Form form, Button makeMatrixBtn, Button saveBtn, TextBox columnTxtBox, TextBox rowTxtBox, Button transposeBtn)
        {
            matrix3 = new List<List<int>>(matrix);
            for (int i = 0; i < rowM1; i++)
            {
                for (int j = 0; j < columnM2; j++)
                {
                    matrix3[i][j] = matrix1[i][j] + matrix2[i][j];
                }
            }

            makeMatrix(columnM1, rowM1, form, makeMatrixBtn, saveBtn, columnTxtBox, rowTxtBox, transposeBtn);

            for (int i = 0; i < rowM1; i++)
            {
                for (int j = 0; j < columnM2; j++)
                {
                    textboxes[i][j].Text = matrix3[i][j] + "";
                }
            }

            saveBtn.Enabled = false;
        }

        public void matrixSubtraction(Form form, Button makeMatrixBtn, Button saveBtn, TextBox columnTxtBox, TextBox rowTxtBox, Button transposeBtn)
        {
            matrix3 = new List<List<int>>(matrix);
            for (int i = 0; i < rowM1; i++)
            {
                for (int j = 0; j < columnM2; j++)
                {
                    matrix3[i][j] = matrix1[i][j] - matrix2[i][j];
                }
            }

            makeMatrix(columnM1, rowM1, form, makeMatrixBtn, saveBtn, columnTxtBox, rowTxtBox, transposeBtn);

            for (int i = 0; i < rowM1; i++)
            {
                for (int j = 0; j < columnM1; j++)
                {
                    textboxes[i][j].Text = matrix3[i][j] + "";
                }
            }
            saveBtn.Enabled = false;
        }

        public void matrixMultiplication(Form form, Button makeMatrixBtn, Button saveBtn, TextBox columnTxtBox, TextBox rowTxtBox, Button transposeBtn)
        {
            matrix = new List<List<int>>();
            for (int i = 0; i < rowM1; i++)
            {
                matrix.Add(new List<int>());
                for (int j = 0; j < columnM2; j++)
                {
                    matrix[i].Add(new int());
                    matrix[i][j] = 0;
                }
            }

            matrix3 = new List<List<int>>(matrix);
            for (int i = 0; i < rowM1; ++i)
            {
                for (int j = 0; j < columnM2; ++j)
                {
                    for (int k = 0; k < columnM1; ++k)
                    {
                        matrix3[i][j] += matrix1[i][k] * matrix2[k][j];
                    }
                }
                    
            }
            
            makeMatrix(columnM2, rowM1, form, makeMatrixBtn, saveBtn, columnTxtBox, rowTxtBox, transposeBtn);

            for (int i = 0; i < rowM1; i++)
            {
                for (int j = 0; j < columnM2; j++)
                {
                    textboxes[i][j].Text = matrix3[i][j] + "";
                }
            }
            saveBtn.Enabled = false;
        }

        public void transpose(Form form, Button makeMatrixBtn, Button saveBtn, TextBox columnTxtBox, TextBox rowTxtBox, Button transposeBtn)
        {
            matrix = new List<List<int>>();
            for (int i = 0; i < columnM1; i++)
            {
                matrix.Add(new List<int>());
                for (int j = 0; j < rowM1; j++)
                {
                    matrix[i].Add(new int());
                    matrix[i][j] = 0;
                }
            }

            matrix3 = new List<List<int>>(matrix);
            for (int i = 0; i < columnM1; i++)
            {
                for (int j = 0; j < rowM1; j++)
                {
                    matrix3[i][j] = matrix1[j][i];
                }
            }

            counter++;
            makeMatrix(rowM1, columnM1, form, makeMatrixBtn, saveBtn, columnTxtBox, rowTxtBox, transposeBtn);

            for (int i = 0; i < columnM1; i++)
            {
                for (int j = 0; j < rowM1; j++)
                {
                    textboxes[i][j].Text = matrix3[i][j] + "";
                }
            }
            saveBtn.Enabled = false;
            transposeBtn.Enabled = false;
        }
    }
}