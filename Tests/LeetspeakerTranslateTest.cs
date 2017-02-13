using Xunit;
using System;
using System.Collections.Generic;

namespace Leetspeaker
{
  public class LeetspeakerTranslatorTest
  {
    [Fact]
    public void LeetspeakerTranslator_ForUserInputa_a()
    {
      LeetspeakerTranslator testLeetspeaker = new LeetspeakerTranslator();
      Assert.Equal("a", testLeetspeaker.Translate("a"));
    }
  }
}
