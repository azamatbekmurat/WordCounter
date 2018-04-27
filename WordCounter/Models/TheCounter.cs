using System.Collections.Generic;
using System;

namespace TheCounter.Models
{
  public class RepeatCounter
  {
    private string _word;
    private string _text;

    public RepeatCounter(string inputWord, string inputText)
    {
      _word = inputWord;
      _text = inputText;
    }

    public int GetCount()
    {
        string wordToLower = _word.ToLower();
        string textToLower = _text.ToLower();
        int count = 0;
        int i = 0;
        while ((i = textToLower.IndexOf(wordToLower, i)) != -1)
        {
            i += wordToLower.Length;
            count++;
        }
        return count;
    }
  }
}
