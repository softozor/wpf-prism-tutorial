using Interfaces;
using Prism.Events;
using System.ComponentModel;

namespace ModuleA.ViewModels
{
  public class ModuleAViewTwoViewModel : INotifyPropertyChanged
  {
    readonly ITextService textService;

    public ModuleAViewTwoViewModel(ITextService textService, IEventAggregator eventAggregator)
    {
      this.textService = textService;
      var evt = eventAggregator.GetEvent<TextChangedEvent>();
      evt.Subscribe(OnTextChangedReceived);
    }

    private void OnTextChangedReceived(string newText)
    {
      PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Text"));
    }

    public int Text { get => textService.GetText().Length; }

    public event PropertyChangedEventHandler PropertyChanged;
  }
}
