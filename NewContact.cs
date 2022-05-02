// Add new person information on list 
public class NewContact
{
    public static void AddNewPerson()
    {
        Console.Write("Name     : ");
        string name  = Console.ReadLine();
        Console.Write("Surname  : ");
        string surname = Console.ReadLine();
        Console.Write("Number   :");
        string number=Console.ReadLine();       
        Person.PBook.Add(new Person(name,surname,number));
        Console.Clear();
    }
}