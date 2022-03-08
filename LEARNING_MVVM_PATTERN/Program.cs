using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LEARNING_MVVM_PATTERN
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var people = 
                new List<ViewModel.PersonViewModel>();

            people.Add(new ViewModel.PersonViewModel
            {
                FirstName = "ali",
                LastName ="azimzadeh",
            });

            Application.Run(new View.PesonForm(people));
        }
    }
}
