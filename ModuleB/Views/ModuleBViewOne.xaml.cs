using ModuleB.ViewModels;
using System.Windows.Controls;

namespace ModuleB
{
  /// <summary>
  /// Interaction logic for ModuleBViewOne.xaml
  /// </summary>
  public partial class ModuleBViewOne : UserControl
  {
    public ModuleBViewOne(ModuleBViewOneViewModel model)
    {
      InitializeComponent();
      Loaded += (sender, ev) => DataContext = model;
    }
  }
}
