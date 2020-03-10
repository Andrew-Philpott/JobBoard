using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace JobBoard.Models
{

  public class JobOpening
  {
    public string Title { get; }

    public string Description { get; }

    public Contact Contact { get; }

    public JobOpening(string title, string description, Contact contact)
    {
      Title = title,
      Description = description,
      Contact = contact
    }
  }
}