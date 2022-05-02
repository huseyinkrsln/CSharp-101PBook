using System.Collections.Generic;
using System.Collections;
using System.Linq;

public static class Content
{
// Just show the menu
    public static void Menu()
    {   
        Console.ForegroundColor= ConsoleColor.DarkYellow;
        Console.WriteLine("Please select the action you want to do");
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("*******************************");
        Console.WriteLine("* (1) Add new number ".PadRight(30) + "*");
        Console.WriteLine("* (2) Delete number  ".PadRight(30) + "*");
        Console.WriteLine("* (3) Update number ".PadRight(30) + "*");
        Console.WriteLine("* (4) List ".PadRight(30) + "*");
        Console.WriteLine("* (5) Search ".PadRight(30) + "*");
        Console.WriteLine("*******************************");
        Console.ResetColor();
    }
// To sort ascending order the list 
    public static void ListSort()
    {
        foreach (var p in Person.PBook.OrderBy(x => x.Name))
        {
            Console.WriteLine($"Ad      : {p.Name}");
            Console.WriteLine($"Surname : {p.Surname}");
            Console.WriteLine($"No      : {p.No}");
            Console.WriteLine("******************");
        }
    }
// To update information on list 
    public static void Update()
    {
        Console.WriteLine("Enter name or surname you want to update :");
        string n_s = Console.ReadLine();
        int counter =0; // this counter blocks to enter loop again. If it is increased it will skip the loop.
        foreach (var pp in Person.PBook)
        {
            if (n_s == pp.Name || n_s == pp.Surname)
            {
                Console.WriteLine("Informations about who you want to update");
                Console.WriteLine($"Name    : {pp.Name}");
                Console.WriteLine($"Surname : {pp.Surname}");
                Console.WriteLine($"No      : {pp.No}");
                Console.WriteLine("******************");

                Console.WriteLine("What do you want to change ?");
                Console.WriteLine("For name press    -->  1");
                Console.WriteLine("For surname press -->  2");
                Console.WriteLine("For number press  -->  3");

                byte c =Convert.ToByte(Console.ReadLine());
                switch(c)
                {
                    case 1:
                    Console.WriteLine("Enter the new name :");
                    pp.Name=Console.ReadLine();
                    counter++;
                    break;                    
                    case 2:
                    Console.WriteLine("Enter the new surname :");
                    pp.Surname=Console.ReadLine();
                    counter++;
                    break;
                    case 3:
                    Console.WriteLine("Enter the new number :");
                    pp.No=Console.ReadLine();
                    counter++;
                    break;
                }
            }
        }
        if(counter ==0)
        {
            Console.WriteLine("Not found. Please make a choice");
            Console.WriteLine("To finish press    -->  1 ");
            Console.WriteLine("To try again press -->  2 ");
            byte b =Convert.ToByte(Console.ReadLine());
            switch(b)
            {
                case 1:
                Menu();
                break;
                case 2:
                Update();
                break;
            }
        }
    }

    public static void SearchList()
    {
        Console.WriteLine("Enter name or surname you want to search :");
        string n_s = Console.ReadLine();
        int c=0;
        foreach (var pp in Person.PBook)
        {
            if (n_s == pp.Name || n_s == pp.Surname)
            {
                Console.WriteLine("Informations about who you want to update");
                Console.WriteLine($"Name    : {pp.Name}");
                Console.WriteLine($"Surname : {pp.Surname}");
                Console.WriteLine($"No      : {pp.No}");
                Console.WriteLine("******************");
                c++;
            }
        }
        if (c == 0)
        {
            Console.WriteLine("Not found. Please make a choice");
            Console.WriteLine("To finish press    -->  1 ");
            Console.WriteLine("To try again press -->  2 ");
            byte b = Convert.ToByte(Console.ReadLine());
            switch (b)
            {
                case 1:
                    // Menu();
                    break;
                case 2:
                    Update();
                    break;
            }
        }
    }
}