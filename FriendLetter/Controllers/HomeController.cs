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
      return View();
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
