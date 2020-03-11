using Microsoft.AspNetCore.Mvc;
using JobBoard.Models;

namespace JobBoard.Controllers
{
  public class JobOpeningsController : Controller
  {
    [HttpGet("/contacts/{contactId}/jobopenings/new")]
    public ActionResult New(int contactId)
    {
      Contact contact = Contact.FindContact(contactId);
      return View(contact);
    }
  }
}