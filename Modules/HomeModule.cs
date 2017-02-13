using Nancy;
using Leetspeaker;
using System;
using System.Collections.Generic;

namespace Leetspeaker
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => View["index.cshtml"];
      Get["/result"] = _ =>
      {
        string userInput = Request.Query["user-input"];
        LeetspeakerTranslator leetspeaker = new LeetspeakerTranslator();
        string leetspeakerResult = leetspeaker.Translate(userInput);
        return View["result.cshtml", leetspeakerResult];
      };
    }
  }
}
