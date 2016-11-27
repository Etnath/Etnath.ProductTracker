using Microsoft.Practices.Unity;
using Prism.Unity;
using Etnath.ProductTracker.Presentation.Shell.Views;
using System.Windows;

namespace Etnath.ProductTracker.Presentation.Shell
{
    class Bootstrapper : UnityBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void InitializeShell()
        {
            Application.Current.MainWindow.Show();
        }
    }
}
