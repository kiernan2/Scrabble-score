using System.Collections.Generic;
using System;
using Scrabble_Score.Models;

  public class Program
  {
    static void Main()
    {
      Console.WriteLine("Enter a Word");
      string word = Console.ReadLine();
      Word scoreWord = new Word(word);
      Console.WriteLine(scoreWord.Score);
    }
  }