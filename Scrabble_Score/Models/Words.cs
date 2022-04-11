using System;
using System.Collections.Generic;
// using System.Linq;

namespace Scrabble_Score.Models {

  public class Word
  {
    public string Letters {get; set;}
    public int Score {get; set;}
    public char[] onePoint = { 'a', 'e', 'i', 'o', 'u', 'l', 'n', 'r', 's', 't'};
    public char[] twoPoint = { 'd', 'g'};
    public char[] threePoint = { 'b', 'c', 'm', 'p'};
    public char[] fourPoint = { 'f', 'h', 'v', 'w', 'y'};
    public char[] fivePoint = { 'k'};
    public char[] eightPoint = { 'j', 'x'};
    public char[] tenPoint = { 'q', 'z'};
    public int Scorer(string letters)
    {
      char[] letterArray = letters.ToCharArray();
      int score = 0;
      foreach(var letter in letterArray)
      {
        if (Array.Exists(onePoint, element => element == Char.ToLower(letter)))
        {
          score += 1;
        }
        else if (Array.Exists(twoPoint, element => element == Char.ToLower(letter)))
        {
          score += 2;
        } 
        else if (Array.Exists(threePoint, element => element == Char.ToLower(letter)))
        {
          score += 3;
        } 
        else if (Array.Exists(fourPoint, element => element == Char.ToLower(letter)))
        {
          score += 4;
        } 
        else if (Array.Exists(fivePoint, element => element == Char.ToLower(letter)))
        {
          score += 5;
        } 
        else if (Array.Exists(eightPoint, element => element == Char.ToLower(letter)))
        {
          score += 8;
        } 
        else if (Array.Exists(tenPoint, element => element == Char.ToLower(letter)))
        {
          score += 10;
        }
      }
      return score;
    }
    public Word(string letters)
    {
      Letters = letters;
      Score = Scorer(Letters);
    }
  }
}