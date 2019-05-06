using Interfaces;
using Prism.Commands;
using System;
using System.ComponentModel;
using System.Windows.Input;

namespace ModuleA.ViewModels
{
  public class ModuleAViewOneViewModel : INotifyPropertyChanged
  {
    readonly ITextService textService;
    ICommand changeTextCommnand;

    public ModuleAViewOneViewModel(ITextService textService)
    {
      this.textService = textService;
      textService.TextChanged += (s, e) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Text"));
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
    }
  }
}
