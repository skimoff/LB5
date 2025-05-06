using System.Text.RegularExpressions;
using System.Xml;

namespace LB5;

public class Person
{
    private string name;
    private string surname;
    private DateTime dateOfBirth;
        
    public Person(string _name, string _surname, DateTime _dateOfBirth)
    {
        name = _name;
        surname = _surname;
        dateOfBirth = _dateOfBirth;
    }

    public Person()
    {
        name = "Noname";
        surname = "Nosurname";
        dateOfBirth = new DateTime(2000,1,1);
    }

    public static bool checkName(string s)
    {
        return Regex.IsMatch(s.Trim(), @"^[a-zA-Z]+$");
    }

    public string Name
    {
        get => name;
        set
        {
            if (!String.IsNullOrEmpty(value)&&checkName(value))
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
            if (!String.IsNullOrEmpty(value)&&checkName(value))
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
            if (DateTime.Now < value)
            {
                dateOfBirth = new DateTime(value.Year, value.Month, value.Day);
            }
            else
            {
                dateOfBirth = new DateTime(0,0,0);
            }
        }
    }

    public override string ToString()
    {
        return $"{name} {surname}, Дата народження: {dateOfBirth}";
    }

    public string ToShortString()
    {
        return $"{name} {surname}";
    }
    
}