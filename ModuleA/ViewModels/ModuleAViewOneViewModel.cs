using Interfaces;

namespace ModuleA.ViewModels
{
  public class ModuleAViewOneViewModel
  {
    readonly ITextService textService;

    public ModuleAViewOneViewModel(ITextService textService)
    {
      this.textService = textService;
    }

    public string Text { get => textService.GetText(); }
  }
}
