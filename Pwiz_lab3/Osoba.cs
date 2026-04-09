using System;
using System.IO;
using System.Xml.Serialization;
// Klasa reprezentująca informacje osobowe
[Serializable]
public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public string Stanowisko { get; set; }
    // Konstruktor
    public Person()
    {
        FirstName = "Brak Imienia";
        LastName = "Brak Nazwiska";
        Age = 0;
        Stanowisko = "Brak Stanowiska";
    }
    public Person(string firstName, string lastName, int age, string stanowisko)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
        Stanowisko = stanowisko;
    }

    // Metoda do wyświetlania informacji o osobie
    public void DisplayInfo()
    {
        Console.WriteLine("Imię: " + FirstName);
        Console.WriteLine("Nazwisko: " + LastName);
        Console.WriteLine("Wiek: " + Age);
        Console.WriteLine("Stanowisko: " + Stanowisko);
    }
    
}