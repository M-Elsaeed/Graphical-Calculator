using System.Collections.Generic;
using System.Windows.Forms;

namespace DarkDemo
{
    class HistoryController : Controller
    {
        private HistoryForm historyForm;
        private List<float> results = new List<float>();
        private List<string> equations = new List<string>();
        override public void closeForm()
        {
            historyForm.Close();
        }
        override public void showForm()
        {
            historyForm = new HistoryForm();
            historyForm.Show();
        }
        public void addResult(float res)
        {
            results.Add(res);
        }
        public void addEquation(string eqn)
        {
            equations.Add(eqn);
        }
        public string getHistory()
        {
            if (results.Count == 0)
                return "No history of calculations";
            string str = "";
            for (int i = 0; i < results.Count; i++)
            {
                str += equations[i] + " = " + results[i] + "\n";
            }
            return str;
        }
    }
}
