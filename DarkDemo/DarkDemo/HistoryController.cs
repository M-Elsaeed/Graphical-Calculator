using System.Collections.Generic;
using System.Windows.Forms;

namespace DarkDemo
{
    class HistoryController
    {
        private HistoryForm historyForm;
        private List<float> results = new List<float>();
        private List<string> equations = new List<string>();
        public void addResult(float res)
        {
            results.Add(res);
        }
        public void addEquation(string eqn)
        {
            equations.Add(eqn);
        }
        public void closeApplication()
        {
            Application.Exit();
        }
        public string getHistory()
        {
            if (results.Count == 0)
                return "No history of calculations";
            string str = "";
            for (int i = 0; i < results.Count; i++)
            {
                str += equations[i] + " = " + results[i]+"\n";
            }
            return str;
        }
        public void closeForm()
        {
            historyForm.Close();
        }
        public void showForm()
        {
            Program.home.Hide();
            historyForm = new HistoryForm();
            historyForm.Show();
        }

    }
}
