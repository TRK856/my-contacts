namespace ContactList
{
    public class Contact
    {
        public string Name;
        public string PhoneNumber;
        public string Email;

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
