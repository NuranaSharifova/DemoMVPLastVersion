using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab.View;
using Lab.Repository;

namespace Lab
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var repository = new CustomerRepository(Application.StartupPath);
            var view = new Form1();
            var presenter = new Presenter.CustomerPresenter(view,repository);
            Application.Run(view);
        }
    }
}
