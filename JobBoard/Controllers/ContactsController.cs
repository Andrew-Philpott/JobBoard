using Microsoft.AspNetCore.Mvc;
using JobBoard.Models;

namespace JobBoard.Controllers
{
  public class ContactsController : Controller
  {
    [HttpGet("/contacts/")]
    public ActionResult Index()
    {
      return View();
    }

    [HttpGet("/contacts/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/contacts")]
    public ActionResult New(string name, string email, string phoneNumber)
    {
      Contact contact = new Contact(name, email, phoneNumber);
      return View(contact);
    }
  }
}