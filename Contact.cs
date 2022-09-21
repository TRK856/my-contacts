namespace ContactList
{
    public class Contact
    {
        public string Name {get; set;}
        public string PhoneNumber {get; set;}
        public string Email {get; set;}

        public Contact(string name, string email, string phoneNumber)
        {
            this.Name = name;
            this.PhoneNumber = phoneNumber;
            this.Email = email;
        }

        public void writeAllInfo()
        {
            Console.WriteLine($"Name: {this.Name}");
        }
    }
}
