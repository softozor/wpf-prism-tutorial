using Interfaces;
using Prism.Commands;
using Prism.Events;
using System;
using System.ComponentModel;
using System.Windows.Input;

namespace ModuleA.ViewModels
{
  public class ModuleAViewOneViewModel : INotifyPropertyChanged
  {
    readonly ITextService textService;
    private readonly IEventAggregator eventAggregator;
    ICommand changeTextCommnand;

    public ModuleAViewOneViewModel(ITextService textService, IEventAggregator eventAggregator)
    {
      this.textService = textService;
      this.eventAggregator = eventAggregator;
    }

    public string Text { get => textService.GetText(); }

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
      textService.SetText(newText);
      PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Text"));
      var evt = eventAggregator.GetEvent<TextChangedEvent>();
      evt.Publish(textService.GetText());
    }
  }
}
