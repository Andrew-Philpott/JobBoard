namespace JobBoard.Models
{
    public class Contact{

      public string Name { get; }

      public string Email { get; }

      public string PhoneNumber { get; }

      public Contact(string name, string email, string phoneNumber){
        Name = name;
        Email = email;
        PhoneNumber = phoneNumber;
      }

    }
}