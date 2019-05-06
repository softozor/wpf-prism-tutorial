using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleB.ViewModels
{
  public class ModuleBViewOneViewModel
  {
    private readonly ITextService textService;

    public ModuleBViewOneViewModel(ITextService textService)
    {
      this.textService = textService;
    }

    public string Text { get => textService.GetText().Split(' ')[0]; }
  }
}
