using Microsoft.AspNetCore.Mvc;

namespace JobBoard.Controllers
{
  public class JobOpeningsController : Controller
  {
    [HttpGet("/jobopenings")]
    public ActionResult Index()
    {
      return View();
    }
  }
}