using Interfaces;
using System.ComponentModel;

namespace ModuleA.ViewModels
{
  public class ModuleAViewTwoViewModel : INotifyPropertyChanged
  {
    readonly ITextService textService;

    public ModuleAViewTwoViewModel(ITextService textService)
    {
      this.textService = textService;
      textService.TextChanged += (s, e) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Text"));
    }

    public int Text { get => textService.GetText().Length; }

    public event PropertyChangedEventHandler PropertyChanged;
  }
}
