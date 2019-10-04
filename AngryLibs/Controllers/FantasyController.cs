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
    public ActionResult NewRobinHood(string adjective1, string noun1)
    {
      ChooseLibs newLibs = new ChooseLibs();
      newLibs.Adjective = adjective1;
      newLibs.Noun = noun1;
      return View(newLibs);
    }
  }
}