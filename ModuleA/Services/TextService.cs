using Interfaces;

namespace ModuleA
{
  public class TextService : ITextService
  {
    public string GetText()
    {
      return "Hello World";
    }
  }
}
