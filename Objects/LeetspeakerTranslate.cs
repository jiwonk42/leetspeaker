using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Leetspeaker
{
  public class LeetspeakerTranslator
  {
    public string Translate(string input)
    {
      char[] array = input.ToCharArray();
      for (int i = 0; i < array.Length; i++)
      {
        if (array[i] == 'e'|| array[i] == 'E')
        {
          array[i] = (3).ToString().ToCharArray()[0];
        }
        else if (array[i] == 'o'|| array[i] == 'O')
        {
          array[i] = (0).ToString().ToCharArray()[0];
        }
        else if (array[i] == 'I')
        {
          array[i] = (1).ToString().ToCharArray()[0];
        }
      }
      string result = string.Join("", array);

      string[] newArray = result.Split(' ');

      List<string> resultList = new List<string>{};
      foreach (string word in newArray)
      {
        char[] wordArray = word.ToCharArray();
        if (Regex.IsMatch(word, @"^\W"))
        {
          // When wordArray[0] is a punctuation
          // When wordArray[1] is a character 's'
          for (int i = 2; i < wordArray.Length; i++)
          {
            if (wordArray[i] == 's')
            {
              wordArray[i] = 'z';
            }
          }
        }
        else
        {
          // When wordArray[0] is NOT a punctuation
          // Skipping the first character 's'
          for (int i = 1; i < wordArray.Length; i++)
          {
            if (wordArray[i] == 's')
            {
              wordArray[i] = 'z';
            }
          }
        }
         resultList.Add(string.Join("", wordArray));
      }
      newArray = resultList.ToArray();
      string finalResult = string.Join(" ", newArray);
      return finalResult;
    }
  }
}
