using Microsoft.AspNetCore.Mvc;
using JobBoard.Models;
using System.Threading.Tasks;

namespace JobBoard.Controllers
{
  public class JobBoardController : Controller
  {
    [HttpGet("/JobBoard")]
    public ActionResult Index()
    {
      return View();
    }

    [HttpGet("/JobBoard/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/JobBoard")]
    public ActionResult New()
    {

      return View();
    }
  }
}