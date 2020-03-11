using Microsoft.AspNetCore.Mvc;
using JobBoard.Models;
using System.Collections.Generic;

namespace JobBoard.Controllers
{
  public class ContactsController : Controller
  {
    [HttpGet("/contacts")]
    public ActionResult Index(Contact contact)
    {
      return View(contact);
    }

    [HttpGet("/contacts/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpGet("/contacts/show")]
    public ActionResult Show(int id)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Contact foundContact = Contact.FindContact(id);
      List<JobOpening> contactJobListings = foundContact.GetJobListings();
      model.Add("contact", foundContact);
      model.Add("joblistings", contactJobListings);
      return View(model);
    }

    [HttpPost("/contacts")]
    public ActionResult Create(string name, string email, string phoneNumber)
    {
      Contact contact = new Contact(name, email, phoneNumber);
      return RedirectToAction("Index", contact);
    }
  }
}