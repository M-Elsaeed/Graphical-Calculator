using System.Windows.Forms;

namespace DarkDemo
{
    abstract public class Controller
    {
        abstract public void showForm();
        abstract public void closeForm();
        public void closeApplication()
        {
            Application.Exit();
        }
        public void showHome()
        {
            Program.home.Show();
        }
        public void hideHome()
        {
            Program.home.Hide();
        }
    }
}
