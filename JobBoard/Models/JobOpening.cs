using System.Collections.Generic;

namespace JobBoard.Models
{
  public class JobOpening
  {
    public int Id { get; }
    public string Title { get; }

    public string Description { get; }

    public Contact Contact { get; }

    private static List<JobOpening> JobOpenings = new List<JobOpening>();

    public JobOpening(string title, string description, Contact contact)
    {
      Title = title;
      Description = description;
      Contact = contact;
      Id = JobOpenings.Count;
      JobOpenings.Add(this);
    }
    public static List<JobOpening> GetAllJobOpenings()
    {
      return JobOpenings;
    }
  }
}