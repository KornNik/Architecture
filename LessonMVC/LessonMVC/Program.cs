using System;
using System.Windows.Forms;

namespace LessonMVC
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            MVCForm view = new MVCForm();
            IModel mdl = new IncrementModel();
            IController cnt = new IncrementController(view, mdl);
            Application.Run(view);
        }
    }
}
