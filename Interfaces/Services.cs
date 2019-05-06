using System;
using System.Windows;

namespace Interfaces {
  public interface ITextService
  {
    string GetText();
    void SetText(string newValue);

    event EventHandler TextChanged;
  }
}
