using System.Collections.Generic;
using System;

namespace TheCounter.Models
{
  public class RepeatCounter
  {
    private string _word;
    private string _text;
    private int _count;

    public RepeatCounter(string inputWord, string inputText)
    {
      _word = inputWord;
      _text = inputText;
    }
    public string GetWord()
    {
      return _word;
    }
    public int GetCountNo()
    {
      return _count;
    }

    public void GetCount()
    {
        string wordToLower = _word.ToLower();
        string textToLower = _text.ToLower();
        _count = 0;
        int i = 0;
        while ((i = textToLower.IndexOf(wordToLower, i)) != -1)
        {
            i += wordToLower.Length;
            _count++;
        }
        // return count; //since GetCount() was changed from 'int' to 'void', 'return' was commented out
    }
  }
}
