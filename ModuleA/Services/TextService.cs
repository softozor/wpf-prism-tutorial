using System;
using Interfaces;

namespace ModuleA
{
  public class TextService : ITextService
  {
    string text;
    public event EventHandler TextChanged;

    public TextService()
    {
      text = "Hello World";
    }

    public string GetText()
    {
      return text;
    }

    public void SetText(string newValue)
    {
      text = newValue;
      TextChanged?.Invoke(this, EventArgs.Empty);
    }
  }
}
