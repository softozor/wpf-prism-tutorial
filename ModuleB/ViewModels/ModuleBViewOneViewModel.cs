using Interfaces;
using System.ComponentModel;

namespace ModuleB.ViewModels
{
  public class ModuleBViewOneViewModel : INotifyPropertyChanged
  {
    private readonly ITextService textService;

    public ModuleBViewOneViewModel(ITextService textService)
    {
      this.textService = textService;
      textService.TextChanged += (s, e) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Text"));
    }

    public string Text { get => textService.GetText().Split(' ')[0]; }

    public event PropertyChangedEventHandler PropertyChanged;
  }
}
