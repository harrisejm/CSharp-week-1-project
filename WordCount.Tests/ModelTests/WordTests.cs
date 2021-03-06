using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using WordCounter;
namespace WordCounter.Tests
{
  [TestClass]
  public class TestWordCounter
  {

    [TestMethod]
    public void wordNumber()
    {
      RepeatCounter word = new RepeatCounter("Hello", "hi");
      Assert.AreEqual("hellohi" , word.testOutput()); //Test MS TEST
    }

    [TestMethod]
    public void testArr()
    {
      RepeatCounter word = new RepeatCounter("Hello", "Hello World Hello");
      Assert.AreEqual("hello appears 2 times." , word.test()); //test() return wordArr[0];
    }

    [TestMethod]
    public void testFinalOutput()
    {
      RepeatCounter word = new RepeatCounter("Hello", "Hello World Hello");
      Assert.AreEqual("hello appears 2 times." , word.test());
    }

    [TestMethod]
    public void testFinalOutput1()
    {
      RepeatCounter word = new RepeatCounter("Hello", "Hello. World? Hello: helLO! HELLO; hellO!");
      Assert.AreEqual("hello appears 5 times." , word.test());
    }
  }
}
