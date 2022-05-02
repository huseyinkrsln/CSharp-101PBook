using System.Collections.Generic;
using System.Collections;

public class DeleteContact
{
    public static void Remove()
    {
        Console.Write("Enter the name or surname you want to delete :");
        string name_Surname = Console.ReadLine().ToLower();
        int counter = 0;

        foreach (var m in Person.PBook)
        {
            if (m.Name.ToString() == name_Surname || m.Surname.ToString() == name_Surname)
            {
                Console.WriteLine("You are deleting {0}. Confirm ? (y/n)", m.Name);
                char yes_No = Convert.ToChar(Console.ReadLine().ToLower());
                if (yes_No == 'y')
                {
                    Person.PBook.Remove(m);
                    counter++;
                    break;
                }
                else
                {
                    Console.Clear();
                    Content.Menu();
                    counter++;
                    break;
                }
            }
        }
        if (counter == 0)
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("Not Found ! Please make a choice ");
            Console.WriteLine("To end the deletion press => 1");
            Console.WriteLine("To try again press        => 2");
            Console.ResetColor();
            string one_Two = Console.ReadLine();
            if (one_Two == "1")
            {
                Content.Menu();
            }
            else if (one_Two == "2")
            {
                Remove();               
            }
        }
    }
}
