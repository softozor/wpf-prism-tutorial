using Interfaces;
using Prism.Events;
using Prism.Regions;
using System.ComponentModel;

namespace ModuleA.ViewModels
{
  public class ModuleAViewTwoViewModel : INotifyPropertyChanged
  {
    private readonly IRegionManager regionManager;

    public ModuleAViewTwoViewModel(IRegionManager regionManager)
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

    public int Text { get => (regionManager.Regions["ParentRegion"].Context as string).Length; }

    public event PropertyChangedEventHandler PropertyChanged;
  }
}
