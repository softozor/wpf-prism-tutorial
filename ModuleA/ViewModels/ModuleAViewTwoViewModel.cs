using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleA.ViewModels
{
  public class ModuleAViewTwoViewModel
  {
    readonly ITextService textService;

    public ModuleAViewTwoViewModel(ITextService textService)
    {
      this.textService = textService;
    }

    public int Text { get => textService.GetText().Length; }
  }
}
