using System;
using System.Windows.Forms;

namespace DarkDemo
{
    public partial class HistoryForm : Form
    {
        public HistoryForm()
        {
            InitializeComponent();
            historyText.Text = Program.historyController.getHistory();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Program.historyController.closeForm();
        }
    }
}
