using Interfaces;
using Prism.Events;
using System.ComponentModel;

namespace ModuleB.ViewModels
{
  public class ModuleBViewOneViewModel : INotifyPropertyChanged
  {
    private readonly ITextService textService;

    public ModuleBViewOneViewModel(ITextService textService, IEventAggregator eventAggregator)
    {
      this.textService = textService;
      var evt = eventAggregator.GetEvent<TextChangedEvent>();
      evt.Subscribe(OnTextChanged);
    }

    private void OnTextChanged(string obj)
    {
      PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Text"));
    }

    public string Text { get => textService.GetText().Split(' ')[0]; }

    public event PropertyChangedEventHandler PropertyChanged;
  }
}
