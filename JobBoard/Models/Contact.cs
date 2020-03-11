using System.Collections.Generic;

namespace JobBoard.Models
{
  public class Contact
  {
    private static List<Contact> _contacts = new List<Contact>();
    public int Id { get; }
    public string Name { get; }
    public string Email { get; }
    public string PhoneNumber { get; }

    private List<JobOpening> _jobOpenings = new List<JobOpening>();

    public Contact() { }
    public Contact(string name, string email, string phoneNumber)
    {
      Name = name;
      Email = email;
      PhoneNumber = phoneNumber;
      _contacts.Add(this);
      Id = _contacts.Count;
    }
    public List<JobOpening> GetJobListings()
    {
      return _jobOpenings;
    }
    public static Contact FindContact(int id)
    {
      return _contacts.Find(x => x.Id == id);
    }
    public void AddJobOpening(JobOpening jobOpening)
    {
      _jobOpenings.Add(jobOpening);
    }
  }
}