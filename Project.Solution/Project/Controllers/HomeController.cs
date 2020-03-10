using Microsoft.AspNetCore.Mvc;
using Project.Models;

namespace FriendLetter.Controllers
{
  public class HomeController : Controller
  {

    [Route("/hello")]
    public string Hello() { return "Hello friend!"; }

    [Route("/goodbye")]
    public string Goodbye() { return "Goodbye friend"; }

    // [Route("/")]
    // public ActionResult Letter() { 
    //   ProjectVariable projectVariable = new ProjectVariable();
    //   projectVariable.Test = "Test";
    //   projectVariable.Test2 = "Test2";
    //   return View(projectVariable);
    //  }

     [Route("/")]
     public ActionResult Form() { return View(); }

     [Route("/testFormResult")]
     public ActionResult TestFormResult(string test, string test2)
     {
       ProjectVariable projectVariable = new ProjectVariable();
       projectVariable.Test = test;
       projectVariable.Test2 = test2;
       return View(projectVariable);
     }
  }
}