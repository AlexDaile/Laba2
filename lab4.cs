using System;

public class User
{
    // Поля класу User
    private string login;
    private string firstName;
    private string lastName;
    private int age;
    private readonly DateTime registrationDate; 

    // Клас User
    public User(string login, string firstName, string lastName, int age)
    {
        this.login = login;
        this.firstName = firstName;
        this.lastName = lastName;
        this.age = age;
        this.registrationDate = DateTime.Now; 
    }

    // Виведення інформації
    public void DisplayUserInfo()
    {
        Console.WriteLine("Інформація про користувача:");
        Console.WriteLine($"Логін: {login}");
        Console.WriteLine($"Ім'я: {firstName}");
        Console.WriteLine($"Прізвище: {lastName}");
        Console.WriteLine($"Вік: {age} років");
        Console.WriteLine($"Дата заповнення анкети: {registrationDate}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Створення класу User
        User user = new User("user123", "Іван", "Петрович", 30);

        // Виведення інформації
        user.DisplayUserInfo();

        Console.ReadLine();
    }
}
