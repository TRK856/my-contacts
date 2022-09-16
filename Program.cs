// // See https://aka.ms/new-console-template for more information
#nullable disable
using ContactList;

List<Contact> contacts = new List<Contact>
{
    new Contact("Kung Fu Panada", "theRealPanda@gmail.com", "+1 (THE) FUU LINE"),
    new Contact("Weenie The Pooie", "thePooie@gmail.com", "+1 (OOP) JUS POOO"),
    new Contact("A Dragon", "aRealDragon@gmail.com", "+1 (NOT) SUS @ALL")
};

Random rnd = new Random();

// actual program
bool loop = true;
while (loop)
{
    Console.Clear();
    Console.WriteLine("MAIN MENU");
    Console.WriteLine("    1. Display Contact Names");
    Console.WriteLine("    2. Search for Contact");
    Console.WriteLine("    3. Edit Contact");
    Console.WriteLine("    4. New Contact");
    Console.WriteLine("    5. Remove Contact");
    Console.WriteLine("    6. Exit");
    Console.Write("-> ");
    int mainMenuChoice = Convert.ToInt32(Console.ReadLine());
    Console.Clear();

    if (mainMenuChoice == 1)
    {
        Console.WriteLine("DISPLAY CONTACTS NAMES");
        for (int i = 0; i < contacts.Count(); i++)
        {
            contacts[i].writeAllInfo();
        }
    }
    if (mainMenuChoice == 2)
    {
        Console.WriteLine("SEARCH FOR CONTACTS");
        Console.Write("Enter a Vaild Name: ");
        string searchName = Console.ReadLine();
        for (int i = 0; i < contacts.Count(); i++)
        {
            if (contacts[i].Name.ToLower() == searchName.ToLower())
            {
                Console.WriteLine("------------");
                Console.WriteLine(
                    $"Name: {contacts[i].Name}, \nEmail: {contacts[i].Email}, \nPhone Number: {contacts[i].PhoneNumber}"
                );
            }
        }
    }
    if (mainMenuChoice == 3)
    {
        Console.WriteLine("EDIT CONTACT");
        Console.Write("Enter a Vaild Name: ");
        string searchName = Console.ReadLine();
        for (int i = 0; i < contacts.Count(); i++)
        {
            if (contacts[i].Name.ToLower() == searchName.ToLower())
            {
                Console.WriteLine();
                Console.Write("Edit Name: ");
                string newName = Console.ReadLine();
                if (newName != "")
                {
                    contacts[i].Name = newName;
                }
                Console.Write("Edit Email: ");
                string newEmail = Console.ReadLine();
                if (newEmail != "")
                {
                    contacts[i].Email = newEmail;
                }
                Console.Write("Edit Phone Number: ");
                string newPhoneNumber = Console.ReadLine();
                if (newPhoneNumber != "")
                {
                    contacts[i].PhoneNumber = newPhoneNumber;
                }
            }
        }
    }
    if (mainMenuChoice == 4) { }
    if (mainMenuChoice == 5) { }
    if (mainMenuChoice == 6)
    {
        break;
    }
    Console.WriteLine("");
    Console.WriteLine("Back to Main Menu?");
    Console.Write("-> ");
    Console.ReadLine();
}
