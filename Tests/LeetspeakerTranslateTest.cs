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

    [Fact]
    public void LeetspeakerTranslator_ForUserInpute_3()
    {
      LeetspeakerTranslator testLeetspeaker = new LeetspeakerTranslator();
      Assert.Equal("3gg", testLeetspeaker.Translate("Egg"));
    }

    [Fact]
    public void LeetspeakerTranslator_ForUserInputo_0()
    {
      LeetspeakerTranslator testLeetspeaker = new LeetspeakerTranslator();
      Assert.Equal("n30n", testLeetspeaker.Translate("neon"));
    }

    [Fact]
    public void LeetspeakerTranslator_ForUserInputI_1()
    {
      LeetspeakerTranslator testLeetspeaker = new LeetspeakerTranslator();
      Assert.Equal("1'm L30", testLeetspeaker.Translate("I'm Leo"));
    }

    [Fact]
    public void LeetspeakerTranslator_ForUserInputs_z()
    {
      LeetspeakerTranslator testLeetspeaker = new LeetspeakerTranslator();
      Assert.Equal("1t'z L30 'Start hip'zz aza", testLeetspeaker.Translate("It's Leo 'Start hip'ss asa"));
    }
  }
}
