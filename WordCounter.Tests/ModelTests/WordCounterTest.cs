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
      int finalCount = inputValues.GetCount();
      Console.WriteLine(finalCount);
      Assert.AreEqual(1, finalCount);
    }

    [TestMethod]
    public void CountOneLetterWithinText()
    {
      RepeatCounter inputValues = new RepeatCounter("A", "Read application");
      int finalCount = inputValues.GetCount();
      Console.WriteLine(finalCount);

      Assert.AreEqual(3, finalCount);
    }

    [TestMethod]
    public void CountOneWordApple()
    {
      RepeatCounter inputValues = new RepeatCounter("apple", "big apple");
      int finalCount = inputValues.GetCount();
      Console.WriteLine(finalCount);

      Assert.AreEqual(1, finalCount);
    }

    [TestMethod]
    public void CountTwoWordsInStringApple()
    {
      RepeatCounter inputValues = new RepeatCounter("apple", "big apple, and red apple");
      int finalCount = inputValues.GetCount();
      Console.WriteLine(finalCount);

      Assert.AreEqual(2, finalCount);
    }

    [TestMethod]
    public void CountWordWithUpperCaseInInputWordApple()
    {
      RepeatCounter inputValues = new RepeatCounter("Apple", "big apple, and red apple");
      int finalCount = inputValues.GetCount();
      Console.WriteLine(finalCount);

      Assert.AreEqual(2, finalCount);
    }

    [TestMethod]
    public void CountWordWithVariousCasesInStringApple()
    {
      RepeatCounter inputValues = new RepeatCounter("AppLE", "big aPplE, and red aPPLe, and ripe aPpLe");
      int finalCount = inputValues.GetCount();
      Console.WriteLine(finalCount);

      Assert.AreEqual(3, finalCount);
    }

  }
}
