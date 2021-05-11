using System;
using System.Windows.Forms;

using KeLi.FormMvc.App.Controllers;
using KeLi.FormMvc.App.Views;

namespace KeLi.FormMvc.App
{
    public static class Program
    {
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();

            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new PersonController(new PersonForm()).View);
        }
    }
}