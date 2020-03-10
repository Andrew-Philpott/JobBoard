using System.Collections.Generic;

namespace JobBoard.Models
{
    public class Contact{

      public string Name { get; }

      public string Email { get; }

      public string PhoneNumber { get; }

      public List<JobOpening> JobOpenings = new List<JobOpening>();

      public Contact(string name, string email, string phoneNumber){
        Name = name;
        Email = email;
        PhoneNumber = phoneNumber;
      }

      public void AddJobOpening(JobOpening jobOpening){
        JobOpenings.Add(jobOpening);
      }
    }
}