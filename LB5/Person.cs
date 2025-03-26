using System.Text.RegularExpressions;
using System.Xml;

namespace LB5;

public class Person
{
    private string name;
    private string surname;
    private DateTime dateOfBirth;
        
    public Person(string name, string surname, DateTime dateOfBirth)
    {
        this.name = name;
        this.surname = surname;
        this.dateOfBirth = dateOfBirth;
    }

    public Person()
    {
        name = "Noname";
        surname = "Nosurname";
        dateOfBirth = new DateTime(0);
    }

    public string Name
    {
        get => name;
        set
        {
            string pattern = @"^[a-zA-Z]+$";
            bool check = Regex.IsMatch(value, pattern);
            if (check)
            {
                name = value;
            }
            else
            {
                name = "Noname";
            }
        }
    }

    public string Surname
    {
        get => surname;
        set
        {
            string pattern = @"^[a-zA-Z]+$";
            bool check = Regex.IsMatch(value, pattern);
            if (check)
            {
                surname = value;
            }
            else
            {
                surname = "Nosurname";
            }
        }
    }

    public DateTime DateOfBirth
    {
        get => dateOfBirth;
        set
        {
            if (DateTime.Now.Year < value.Year)
            {
                dateOfBirth = new DateTime(value.Year);
            }
            else
            {
                dateOfBirth = new DateTime(0);
            }
        }
    }

    public override string ToString()
    {
        return "Name"+' '+name+" \nSurname"+' '+surname+"\nDateOfBirth"+' '+dateOfBirth;
    }

    public string ToShortString()
    {
        return "Name"+' '+name+" \nSurname"+' '+surname;
    }
    
}