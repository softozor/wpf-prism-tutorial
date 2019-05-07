using Prism.Regions;
using System.ComponentModel;

namespace ModuleB.ViewModels
{
  public class ModuleBViewOneViewModel : INotifyPropertyChanged
  {
    private readonly IRegionManager regionManager;

    public ModuleBViewOneViewModel(IRegionManager regionManager)
    {
      regionManager.Regions["ParentRegion"].PropertyChanged += (s, e) =>
      {
        if (e.PropertyName == "Context")
        {
          PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Text"));
        }
      };
      this.regionManager = regionManager;
    }

    public string Text { get => (regionManager.Regions["ParentRegion"].Context as string).Split(' ')[0]; }

    public event PropertyChangedEventHandler PropertyChanged;
  }
}
