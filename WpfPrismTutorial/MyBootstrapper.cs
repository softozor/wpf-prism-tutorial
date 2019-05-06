using Prism.Modularity;
using Prism.Unity;
using System.IO;
using System.Windows;

namespace WpfPrismTutorial
{
  public class MyBootstrapper : UnityBootstrapper
  {
    protected override IModuleCatalog CreateModuleCatalog()
    {
      FileStream catalogStream = new FileStream(@".\modulecatalog.xaml", FileMode.Open);
      var catalog = Prism.Modularity.ModuleCatalog.CreateFromXaml(catalogStream);
      catalogStream.Dispose();
      return catalog;
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
