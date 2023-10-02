using System;

public class Address
{
    // Поля класу Address
    private string index;
    private string country;
    private string city;
    private string street;
    private string house;
    private string apartment;

    // Доступ до поля index
    public string Index
    {
        get { return index; }
        set { index = value; }
    }

    // Доступ до поля country
    public string Country
    {
        get { return country; }
        set { country = value; }
    }

    // Доступ до поля city
    public string City
    {
        get { return city; }
        set { city = value; }
    }

    // Доустп до поля street
    public string Street
    {
        get { return street; }
        set { street = value; }
    }

    // Доустп до поля house
    public string House
    {
        get { return house; }
        set { house = value; }
    }

    // Доступ до поля apartment
    public string Apartment
    {
        get { return apartment; }
        set { apartment = value; }
    }
}

class Program
{
    static void Main(string[] args;)
    {
        // Клас Address
        Address address = new Address();

        // Заповнення полів Адрес
        address.Index = "07403";
        address.Country = "Україна";
        address.City = "Бровари";
        address.Street = "Сергія Москаленка";
        address.House = "41";
        address.Apartment = "126";

        // Виведення інформації про адресу
        Console.WriteLine($"Індекс: {address.Index}");
        Console.WriteLine($"Країна: {address.Country}");
        Console.WriteLine($"Місто: {address.City}");
        Console.WriteLine($"Вулиця: {address.Street}");
        Console.WriteLine($"Будинок: {address.House}");
        Console.WriteLine($"Квартира: {address.Apartment}");

        Console.ReadLine();
    }
}

