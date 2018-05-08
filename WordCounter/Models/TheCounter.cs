using System.Collections.Generic;
using System;
using System.Text.RegularExpressions;

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

    public int GetCount()
    {
        string wordToLower = _word.ToLower();
        string textToLower = _text.ToLower();
        char[] delimiterChars = { ' ', ',', '.', ':', '\t' };
        string[] wordsFromText = textToLower.Split(delimiterChars);
        _count = 0;
        for (int i = 0; i < wordsFromText.Length; i++)
        {
          if (wordToLower == wordsFromText[i])
          {
            _count++;
          }
        }
        return _count;
        //Previous version without splitter
        // int i = 0;
        // while ((i = textToLower.IndexOf(wordToLower, i)) != -1)
        // {
        //     i += wordToLower.Length;
        //     _count++;
        // }

    }
    public bool IsThereAWord()
    {
      if (Regex.IsMatch(_word, "^(?=.*[a-z])"))
      {
          return true;
      }
      return false;
    }

  }
}
