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
    public partial class ArithmeticForm : Form
    {
        public ArithmeticForm()
        {
            InitializeComponent();
            this.eqnTxtBox.Enabled = false;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Program.arithmeticController.closeApplication();
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            Program.arithmeticController.closeForm();
        }

        private void Arithmetic_Load(object sender, EventArgs e)
        {
            this.Location = new System.Drawing.Point(200, 100);
        }

        private void openBrackerBtn_Click(object sender, EventArgs e)
        {
            Program.arithmeticController.writeSimpleArithmatic((Button)sender, eqnTxtBox);
        }

        private void closeBracketBtn_Click(object sender, EventArgs e)
        {
            Program.arithmeticController.writeSimpleArithmatic((Button)sender, eqnTxtBox);
        }

        private void pointBtn_Click(object sender, EventArgs e)
        {
            Program.arithmeticController.writeSimpleArithmatic((Button)sender, eqnTxtBox);
        }

        private void multiplyBtn_Click(object sender, EventArgs e)
        {
            Program.arithmeticController.writeSimpleArithmatic((Button)sender, eqnTxtBox);
        }

        private void plusBtn_Click(object sender, EventArgs e)
        {
            Program.arithmeticController.writeSimpleArithmatic((Button)sender, eqnTxtBox);
        }

        private void minusBtn_Click(object sender, EventArgs e)
        {
            Program.arithmeticController.writeSimpleArithmatic((Button)sender, eqnTxtBox);
        }

        private void divideBtn_Click(object sender, EventArgs e)
        {
            Program.arithmeticController.writeSimpleArithmatic((Button)sender, eqnTxtBox);
        }

        private void zeroBtn_Click(object sender, EventArgs e)
        {
            Program.arithmeticController.writeSimpleArithmatic((Button)sender, eqnTxtBox);
        }

        private void nineBtn_Click(object sender, EventArgs e)
        {
            Program.arithmeticController.writeSimpleArithmatic((Button)sender, eqnTxtBox);
        }

        private void eightBtn_Click(object sender, EventArgs e)
        {
            Program.arithmeticController.writeSimpleArithmatic((Button)sender, eqnTxtBox);
        }

        private void sevenBtn_Click(object sender, EventArgs e)
        {
            Program.arithmeticController.writeSimpleArithmatic((Button)sender, eqnTxtBox);
        }

        private void sixBtn_Click(object sender, EventArgs e)
        {
            Program.arithmeticController.writeSimpleArithmatic((Button)sender, eqnTxtBox);
        }

        private void fiveBtn_Click(object sender, EventArgs e)
        {
            Program.arithmeticController.writeSimpleArithmatic((Button)sender, eqnTxtBox);
        }

        private void fourBtn_Click(object sender, EventArgs e)
        {
            Program.arithmeticController.writeSimpleArithmatic((Button)sender, eqnTxtBox);
        }

        private void threeBtn_Click(object sender, EventArgs e)
        {
            Program.arithmeticController.writeSimpleArithmatic((Button)sender, eqnTxtBox);
        }

        private void twoBtn_Click(object sender, EventArgs e)
        {
            Program.arithmeticController.writeSimpleArithmatic((Button)sender, eqnTxtBox);
        }

        private void oneBtn_Click(object sender, EventArgs e)
        {
            Program.arithmeticController.writeSimpleArithmatic((Button)sender, eqnTxtBox);
        }

        private void equalBtn_Click(object sender, EventArgs e)
        {
            Program.arithmeticController.equals(eqnTxtBox);
        }

        private void sinBtn_Click(object sender, EventArgs e)
        {
            Program.arithmeticController.trignometry((Button)sender, eqnTxtBox);
        }

        private void cosBtn_Click(object sender, EventArgs e)
        {
            Program.arithmeticController.trignometry((Button)sender, eqnTxtBox);
        }

        private void tanBtn_Click(object sender, EventArgs e)
        {
            Program.arithmeticController.trignometry((Button)sender, eqnTxtBox);
        }

        private void asinBtn_Click(object sender, EventArgs e)
        {
            Program.arithmeticController.trignometry((Button)sender, eqnTxtBox);
        }

        private void acosBtn_Click(object sender, EventArgs e)
        {
            Program.arithmeticController.trignometry((Button)sender, eqnTxtBox);
        }

        private void atanBtn_Click(object sender, EventArgs e)
        {
            Program.arithmeticController.trignometry((Button)sender, eqnTxtBox);
        }

        private void ACbtn_Click(object sender, EventArgs e)
        {
            Program.arithmeticController.clear(eqnTxtBox);
        }

        private void secBtn_Click(object sender, EventArgs e)
        {
            Program.arithmeticController.trignometry((Button)sender, eqnTxtBox);
        }

        private void cosecBtn_Click(object sender, EventArgs e)
        {
            Program.arithmeticController.trignometry((Button)sender, eqnTxtBox);
        }

        private void cotanBtn_Click(object sender, EventArgs e)
        {
            Program.arithmeticController.trignometry((Button)sender, eqnTxtBox);
        }

        private void secInverseBtn_Click(object sender, EventArgs e)
        {
            Program.arithmeticController.trignometry((Button)sender, eqnTxtBox);
        }

        private void cosecInverseBtn_Click(object sender, EventArgs e)
        {
            Program.arithmeticController.trignometry((Button)sender, eqnTxtBox);
        }

        private void cotanInverseBtn_Click(object sender, EventArgs e)
        {
            Program.arithmeticController.trignometry((Button)sender, eqnTxtBox);
        }

        private void HsinBtn_Click(object sender, EventArgs e)
        {
            Program.arithmeticController.trignometry((Button)sender, eqnTxtBox);
        }

        private void coshBtn_Click(object sender, EventArgs e)
        {
            Program.arithmeticController.trignometry((Button)sender, eqnTxtBox);
        }

        private void tanhBtn_Click(object sender, EventArgs e)
        {
            Program.arithmeticController.trignometry((Button)sender, eqnTxtBox);
        }

        private void sechBtn_Click(object sender, EventArgs e)
        {
            Program.arithmeticController.trignometry((Button)sender, eqnTxtBox);
        }

        private void cosechBtn_Click(object sender, EventArgs e)
        {
            Program.arithmeticController.trignometry((Button)sender, eqnTxtBox);
        }

        private void cotanhBtn_Click(object sender, EventArgs e)
        {
            Program.arithmeticController.trignometry((Button)sender, eqnTxtBox);
        }

        private void sinhInverseBtn_Click(object sender, EventArgs e)
        {
            Program.arithmeticController.trignometry((Button)sender, eqnTxtBox);
        }

        private void coshInverseBtn_Click(object sender, EventArgs e)
        {
            Program.arithmeticController.trignometry((Button)sender, eqnTxtBox);
        }

        private void tanhInverseBtn_Click(object sender, EventArgs e)
        {
            Program.arithmeticController.trignometry((Button)sender, eqnTxtBox);
        }

        private void sechInverseBtn_Click(object sender, EventArgs e)
        {
            Program.arithmeticController.trignometry((Button)sender, eqnTxtBox);
        }

        private void cosechInverseBtn_Click(object sender, EventArgs e)
        {
            Program.arithmeticController.trignometry((Button)sender, eqnTxtBox);
        }

        private void cotanhInverseBtn_Click(object sender, EventArgs e)
        {
            Program.arithmeticController.trignometry((Button)sender, eqnTxtBox);
        }

        private void power2Btn_Click(object sender, EventArgs e)
        {
            Program.arithmeticController.writeSimpleArithmatic((Button)sender, eqnTxtBox);
        }

        private void power3Btn_Click(object sender, EventArgs e)
        {
            Program.arithmeticController.writeSimpleArithmatic((Button)sender, eqnTxtBox);
        }

        private void power_Click(object sender, EventArgs e)
        {
            Program.arithmeticController.writeSimpleArithmatic((Button)sender, eqnTxtBox);
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            Program.arithmeticController.clear(eqnTxtBox);
        }

        private void squareRoot_Click(object sender, EventArgs e)
        {
            Program.arithmeticController.exp((Button)sender,eqnTxtBox);
        }

        private void logBtn_Click(object sender, EventArgs e)
        {
            Program.arithmeticController.exp((Button)sender, eqnTxtBox);
        }

        private void lnBtn_Click(object sender, EventArgs e)
        {
            Program.arithmeticController.exp((Button)sender, eqnTxtBox);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.historyController.showForm();
        }
    }
}
