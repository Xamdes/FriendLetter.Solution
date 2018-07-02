using Microsoft.AspNetCore.Mvc;
using FriendLetter.Models;

namespace FriendLetter.Controllers
{
  public class HomeController : Controller
  {

    [Route("/")]
    public ActionResult Hello()
    {
      LetterVariable myLetterVariable = new LetterVariable();
      return View(myLetterVariable);
    }

    [Route("/form")]
    public ActionResult Form()
    {
      Location loc = new Location("/greeting_card");
      return View(loc);
    }

    [Route("/greeting_card")]
    public ActionResult GreetingCard()
    {
      LetterVariable myLetterVariable = new LetterVariable();
      myLetterVariable.SetRecipient(Request.Query["recipient"]);
      myLetterVariable.SetSender(Request.Query["sender"]);
      return View("Hello", myLetterVariable);
    }

    [Route("/cd")]
    public ActionResult Albums()
    {
      Album[] testOne = new Album[3];
      testOne[0] = new Album("One", "Traul", "5");
      testOne[1] = new Album("Thrice", "Ipsum", "12");
      testOne[2] = new Album("Quad", "Septim", "3");
      return View(testOne);
    }

    [Route("/hello")]
    public string HelloFriend()
    {
      return "Hello Friend!";
    }

    [Route("/goodbye")]
    public string GoodbyeFriend()
    {
      return "Goodbye Friend.";
    }

    [Route("/letter")]
    public ActionResult Letter()
    {
      return View();
    }

    [Route("/journal")]
    public ActionResult Journal()
    {
      return View();
    }
  }
}
