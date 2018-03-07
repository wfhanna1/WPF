using System.Windows;
using Prism.Unity;
using SampleWPF.Views;
using Microsoft.Practices.Unity;

namespace SampleWPF.DI
{
    public class Bootstrapper : UnityBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            return Container.Resolve<Shell>();
        }
        protected override void InitializeShell()
        {
            base.InitializeShell();
            Application.Current.MainWindow = (Window)Shell;
            Application.Current.MainWindow.Show();
        }

        //protected override void ConfigureModuleCatalog()
        //{
        //    base.ConfigureModuleCatalog();
        //    ModuleCatalog moduleCatalog = (ModuleCatalog)this.ModuleCatalog;
        //    // moduleCatalog.AddModule(x);
        //    // moduleCatalog.AddModule(y);
        //    // moduleCatalog.AddModule(z);
        //}
        //protected override void ConfigureContainer()
        //{
        //    base.ConfigureContainer();
        //    Container.RegisterInstance<>();
        //}
    }
}
