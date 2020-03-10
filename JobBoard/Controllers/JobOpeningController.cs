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
  }
}