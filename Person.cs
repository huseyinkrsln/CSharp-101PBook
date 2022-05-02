using System.Collections.Generic;
using System.Collections;
public class Person 
{
    private string name;
    private string surname;
    private string no;
    public static List<Person> PBook = new List<Person>();

    public Person(string name, string surname, string no)
    {
        Name = name;
        Surname = surname;
        No = no;
    } 
    
    public string Name { get => name; set => name = value; }
    public string Surname { get => surname; set => surname = value; }
    public string No { get => no; set => no = value; }
}    