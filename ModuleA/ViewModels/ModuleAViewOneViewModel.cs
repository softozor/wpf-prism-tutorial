using Interfaces;
using Prism.Commands;
using Prism.Events;
using Prism.Regions;
using System;
using System.ComponentModel;
using System.Windows.Input;

namespace ModuleA.ViewModels
{
  public class ModuleAViewOneViewModel : INotifyPropertyChanged
  {
    readonly IRegionManager regionManager;
    ICommand changeTextCommnand;

    public ModuleAViewOneViewModel(IRegionManager regionManager)
    {
      this.regionManager = regionManager;
    }

    public string Text { get => regionManager.Regions["ParentRegion"].Context as string; }

    public ICommand ChangeTextCommand {
      get
      {
        if(changeTextCommnand == null)
        {
          changeTextCommnand = new DelegateCommand<string>(OnChangeTextCommandExecuted);
        }
        return changeTextCommnand;
      }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    void OnChangeTextCommandExecuted(string newText)
    {
      regionManager.Regions["ParentRegion"].Context = newText;
      PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Text"));
    }
  }
}
