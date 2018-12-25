using System.Windows.Forms;

namespace DarkDemo
{
    abstract public class Controller
    {
        Form form;
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
        //public void showForm()
        //{
        //    form.Show();
        //}
        //public void closeForm()
        //{
        //    form.Close();
        //}
    }
}
