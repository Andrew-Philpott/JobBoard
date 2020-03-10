using Microsoft.AspNetCore.Mvc;
using JobBoard.Models;

namespace JobBoard.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }

    // [HttpGet("/jobboard")]
    // public ActionResult Index()
    // {
    //   return View();
    // }

    [HttpGet("/jobboard/new")]
    public ActionResult New()
    {
      return View();
    }

    // [HttpPost("/jobboard")]
    // public ActionResult New()
    // {
    //   return View();
    // }
  }
}