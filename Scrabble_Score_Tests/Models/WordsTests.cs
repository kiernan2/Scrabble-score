using Microsoft.VisualStudio.TestTools.UnitTesting;
using Scrabble_Score.Models;
using System.Collections.Generic;
using System;

namespace Scrabble_Score
{
  [TestClass]
  public class GameTests
  {
    // public void Dispose()
    // {
    //   Word.ClearAll();
    // }
    [TestMethod]
    public void Eleven()
    {
      Word newWord = new Word("QA");
      newWord.Score = 11;
    }
    [TestMethod]
    public void Seven()
    {
      Word newWord = new Word("ken");
      newWord.Score = 7;
    }
  }
}