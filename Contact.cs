namespace ContactList
{
    public class Contact
    {
        public string Name;
        public string PhoneNumber;
        public string Email;

        public Contact(string name, string phoneNumber, string email)
        {
            this.Name = name;
            this.PhoneNumber = phoneNumber;
            this.Email = email;
        }
    }
}
