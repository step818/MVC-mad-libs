using Microsoft.AspNetCore.Mvc;

namespace AngryLibs.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Home()
    {
      return View();
    }
  }
}