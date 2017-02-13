using System;
using System.Collections.Generic;

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
      return result;
    }
  }
}
