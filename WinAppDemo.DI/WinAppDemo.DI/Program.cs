using SimpleInjector;
using SimpleInjector.Lifestyles;
using System;
using System.Windows.Forms;
using WinAppDemo.DI.Contracts;

namespace WinAppDemo.DI
{
    static class Program
    {
        private static Container container;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Bootstrap();

            // call out for an instance of Form1 from the IoC Container
            Application.Run(container.GetInstance<Form1>());
        }

        private static void Bootstrap()
        {
            container = new Container();

            container.Options.DefaultScopedLifestyle = new ThreadScopedLifestyle();

            container.Register<ICamera, NewFancySecurityCamera>(Lifestyle.Singleton);
            container.Register<Form, Form1>(Lifestyle.Scoped);

            container.Verify();
        }
    }
}
