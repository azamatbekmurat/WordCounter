using Microsoft.VisualStudio.TestTools.UnitTesting;
using TheCounter.Models;
using System.Collections.Generic;
using System;

namespace TheCounter.Tests
{
  [TestClass]
  public class RepeatCounterTest
  {
    [TestMethod]
    public void CountOneLetterWithinOneLetterText()
    {
      RepeatCounter inputValues = new RepeatCounter("A", "a");
      Console.WriteLine(inputValues.GetCount());

      Assert.AreEqual(1, inputValues.GetCount());
    }

    [TestMethod]
    public void CountTwoLettersWithinText()
    {
      RepeatCounter inputValues = new RepeatCounter("Re", "Read application");
      Console.WriteLine(inputValues.GetCount());

      Assert.AreEqual(0, inputValues.GetCount());
    }

    [TestMethod]
    public void CountOneWord_Apple()
    {
      RepeatCounter inputValues = new RepeatCounter("apple", "big apple");
      Console.WriteLine(inputValues.GetCount());

      Assert.AreEqual(1, inputValues.GetCount());
    }

    [TestMethod]
    public void CountWordWithVariousCasesInString_Apple()
    {
      RepeatCounter inputValues = new RepeatCounter("AppLE", "big aPplE, and red aPPLe, and ripe aPpLe");
      Console.WriteLine(inputValues.GetCount());

      Assert.AreEqual(3, inputValues.GetCount());
    }

    [TestMethod]
    public void IsThereAWord_False()
    {
      RepeatCounter inputValues = new RepeatCounter("24", "Big apple 24");
      Console.WriteLine(inputValues.IsThereAWord());
      Assert.AreEqual(false, inputValues.IsThereAWord());
    }

  }
}
