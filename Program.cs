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
    Console.WriteLine($"MAIN MENU");
    Console.WriteLine("    1. Display Contact Names");
    Console.WriteLine("    2. Search for Contact");
    Console.WriteLine("    3. Edit Contact");
    Console.WriteLine("    4. New Contact");
    Console.WriteLine("    5. Remove Contact");
    Console.WriteLine("    6. Exit");
    Console.Write("-> ");
    int mainMenuChoice = Convert.ToInt32(Console.ReadLine());

    if (mainMenuChoice == 1)
    {
        Console.Clear();
        for (int i = 0; i < contacts.Count(); i++) { }
    }
    if (mainMenuChoice == 2)
    {
        Console.Clear();
    }
    if (mainMenuChoice == 3)
    {
        Console.Clear();
    }
    if (mainMenuChoice == 4)
    {
        Console.Clear();
    }
    if (mainMenuChoice == 5)
    {
        Console.Clear();
    }
    if (mainMenuChoice == 6)
    {
        Console.Clear();
        break;
    }
    Console.WriteLine("");
    Console.WriteLine("Back to Main Menu?");
    Console.Write("-> ");
    Console.ReadLine();
}
