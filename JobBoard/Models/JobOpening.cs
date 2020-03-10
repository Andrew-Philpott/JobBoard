using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace JobBoard.Models
{

  public class JobOpening
  {
    public string Title { get; }

    public string Description { get; }

    public Contact Contact { get; set; }

    private static List<JobOpening> JobOpenings = new List<JobOpening>();

    public JobOpening(string title, string description)
    {
      Title = title;
      Description = description;
      Id = JobOpenings.Count;
      JobOpenings.Add(this);
    }

    public void AddContact(Contact contact)
    {
      Contact = contact;
    }

    public static List<JobOpening> GetAllJobOpenings(){
      return JobOpenings;
    }
  }
}