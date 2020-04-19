using System;
using System.Windows.Forms;

using KeLi.MvcUsage.App.Controllers;
using KeLi.MvcUsage.App.Views;

namespace KeLi.MvcUsage.App
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