using Microsoft.AspNetCore.Mvc;
using AngryLibs.Models;

namespace AngryLibs.Controllers
{
  public class FantasyController : Controller
  {
    [Route("/fantasy")]
    public ActionResult Home()
    {
      return View();
    }
    [Route("/fantasy1")]
    public ActionResult RobinHood()
    {
      return View();
    }
    [Route("/EndRHStory")]
    public ActionResult NewRobinHood(string name1, string noun1, string noun2, string noun3, string noun4, string noun5, string adjective1,string adjective2,string adjective3,string adjective4)
    {
      ChooseLibs newLibs = new ChooseLibs();
      newLibs.Name1 = name1;
      newLibs.PluralNoun1 = noun1;
      newLibs.PluralNoun2 = noun2;
      newLibs.PluralNoun3 = noun3;
      newLibs.PluralNoun4 = noun4;
      newLibs.PluralNoun5 = noun5;
      newLibs.Adjective1 = adjective1;
      newLibs.Adjective2 = adjective2;
      newLibs.Adjective3 = adjective3;
      return View(newLibs);
    }
  }
}