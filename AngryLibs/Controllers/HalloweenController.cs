using Microsoft.AspNetCore.Mvc;
using AngryLibs.Models;

namespace AngryLibs.Controllers
{
  public class HalloweenController : Controller
  {
    [Route("/halloween")]
    public ActionResult Home()
    {
      return View();
    }
    [Route("/halloween1")]
    public ActionResult Form()
    {
      return View();
    }
    [Route("/halloweenStory1")]
    public ActionResult NewHalloween1(string verb1, string verb2, string verb3, string verb4, string verb5, string verb6, string adj1, string adj2, string adj3, string adj4, string adj5, string adj6, string adj7, string adj8, string adj9, string pluralNoun1, string pluralNoun2, string pluralNoun5, string pluralNoun6, string noun3, string noun4, string noun5, string noun6, string noun7, string adverb1, string number, string celeb, string person, string bodyPart)
    {
      ChooseScaryLibs newScaryLibs = new ChooseScaryLibs();
      newScaryLibs.Verb1 = verb1;
      newScaryLibs.Verb2 = verb2;
      newScaryLibs.Verb3 = verb3;
      newScaryLibs.Verb4 = verb4;
      newScaryLibs.Verb5 = verb5;
      newScaryLibs.VerbEndING = verb6;
      newScaryLibs.Adjective1 = adj1;
      newScaryLibs.Adjective2 = adj2;
      newScaryLibs.Adjective3 = adj3;
      newScaryLibs.Adjective4 = adj4;
      newScaryLibs.Adjective5 = adj5;
      newScaryLibs.Adjective6 = adj6;
      newScaryLibs.Adjective7 = adj7;
      newScaryLibs.Adjective8 = adj8;
      newScaryLibs.Adjective9 = adj9;
      newScaryLibs.PluralNoun1 = pluralNoun1;
      newScaryLibs.PluralNoun2 = pluralNoun2;
      newScaryLibs.PluralNoun5 = pluralNoun5;
      newScaryLibs.PluralNoun6 = pluralNoun6;
      newScaryLibs.Noun3 = noun3;
      newScaryLibs.Noun4 = noun4;
      newScaryLibs.Noun5 = noun5;
      newScaryLibs.Noun6 = noun6;
      newScaryLibs.Noun7 = noun7;
      newScaryLibs.Adverb1 = adverb1;
      newScaryLibs.Number = number;
      newScaryLibs.Celebrity = celeb;
      newScaryLibs.PersonInRoom = person;
      newScaryLibs.PartOfTheBody = bodyPart;
      return View(newScaryLibs);
    }
  }
}