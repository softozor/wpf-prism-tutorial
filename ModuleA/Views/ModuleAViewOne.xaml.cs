using ModuleA.ViewModels;
using System.Windows.Controls;

namespace ModuleA
{
  /// <summary>
  /// Interaction logic for ModuleAViewOne.xaml
  /// </summary>
  public partial class ModuleAViewOne : UserControl
  {
    public ModuleAViewOne(ModuleAViewOneViewModel model)
    {
      InitializeComponent();

      Loaded += (sender, ev) => DataContext = model;
    }
  }
}
