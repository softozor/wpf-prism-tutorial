using Prism.Modularity;
using Prism.Unity;
using System;
using System.IO;
using System.Windows;

namespace WpfPrismTutorial
{
  public class MyBootstrapper : UnityBootstrapper
  {
    protected override IModuleCatalog CreateModuleCatalog()
    {
       // for this to work, modulecatalog.xaml needs to be a resource (this is set in the file's properties)
       return Prism.Modularity.ModuleCatalog.CreateFromXaml(new Uri("modulecatalog.xaml", UriKind.Relative));
    }

    protected override DependencyObject CreateShell()
    {
      return new MainWindow();
    }

    protected override void InitializeShell()
    {
      base.InitializeShell();
      Application.Current.MainWindow = Shell as Window;
      Application.Current.MainWindow.Show();
    }
  }
}
