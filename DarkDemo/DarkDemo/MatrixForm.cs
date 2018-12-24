using System;
using System.Windows.Forms;

namespace DarkDemo
{
    public partial class MatrixForm : Form
    {
        public MatrixForm()
        {
            InitializeComponent();

            columnTxtBox.Text = "0";
            rowTxtBox.Text = "0";
            saveBtn.Enabled = false;
            plusBtn.Enabled = false;
            minusBtn.Enabled = false;
            multiplyBtn.Enabled = false;
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            Program.matrixContoller.reset();
            Program.matrixContoller.closeForm();
            Program.matrixContoller.showForm();
        }

        private void makeMatrix_Click(object sender, EventArgs e)
        {
            Program.matrixContoller.makeMatrix(Convert.ToInt16(columnTxtBox.Text), Convert.ToInt16(rowTxtBox.Text), this,makeMatrixBtn,saveBtn);
            columnTxtBox.Enabled = false;
            rowTxtBox.Enabled = false;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            Program.matrixContoller.saveMatrix(Convert.ToInt16(columnTxtBox.Text), Convert.ToInt16(rowTxtBox.Text), this, makeMatrixBtn, plusBtn, minusBtn, multiplyBtn, saveBtn);
            columnTxtBox.Enabled = true;
            rowTxtBox.Enabled = true;
        }

        private void plusBtn_Click(object sender, EventArgs e)
        {
            Program.matrixContoller.matrixAddition(this, makeMatrixBtn, saveBtn);
        }

        private void minusBtn_Click(object sender, EventArgs e)
        {
            Program.matrixContoller.matrixSubtraction(this, makeMatrixBtn, saveBtn);
        }

        private void multiplyBtn_Click(object sender, EventArgs e)
        {
            Program.matrixContoller.matrixMultiplication(this, makeMatrixBtn, saveBtn);
        }

        private void homeBtn_Click_1(object sender, EventArgs e)
        {
            Program.matrixContoller.closeForm();
        }

        private void closeBtn_Click_1(object sender, EventArgs e)
        {
            Program.matrixContoller.closeApplication();
        }

        private void MatrixForm_Load(object sender, EventArgs e)
        {
            this.Location = new System.Drawing.Point(200, 100);
        }
    }
}
