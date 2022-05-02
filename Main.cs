using System.Collections.Generic;
using System.Collections;
using System.Linq;

Person.PBook.Add(new Person("huseyin","niyesuh","45435"));
Person.PBook.Add(new Person("berna","anreb","44353"));
Person.PBook.Add(new Person("ahmet","temah","08053"));
Person.PBook.Add(new Person("ceyda","adyec","6784"));
Person.PBook.Add(new Person("zeynep","penyez","5789"));

AGAIN:
Content.Menu();
Console.ForegroundColor=ConsoleColor.DarkRed;
Console.WriteLine("For Exit press --> 0");
Console.ResetColor();
byte choice =Convert.ToByte(Console.ReadLine());


switch (choice)
{
    case 0:
    Console.Beep();
    return 0;
    case 1 :
    NewContact.AddNewPerson();
    break;
    case 2 :
    DeleteContact.Remove();
    break;
    case 3 :
    Content.Update();
    break;
    case 4 :
    Content.ListSort();
    break;
    case 5 :
    Content.SearchList();
    break;
    default :
    Console.WriteLine("Please enter correct number between 1 and 5");
    break;
}
goto AGAIN;





