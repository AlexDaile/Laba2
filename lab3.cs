using System;

public class Employee
{
    // Поля класу Employee
    private string lastName;
    private string firstName;

    // Ввод класу Employee
    public Employee(string lastName, string firstName)
    {
        this.lastName = lastName;
        this.firstName = firstName;
    }

    // Розрахунок окладу співробітника та його збору
    public void CalculateSalaryAndTax(string position, int experience)
    {
        double baseSalary = 0;
        double taxRate = 0.15; // Податкова ставка 15%

        
        switch (position.ToLower())
        {
            case "менеджер":
                baseSalary = 30000;
                break;
            case "розробник":
                baseSalary = 40000;
                break;
            case "тестувальник":
                baseSalary = 35000;
                break;
            default:
                Console.WriteLine("Невідома посада");
                return;
        }

        // Збільшення окладу в залежності від стажу
        if (experience >= 5)
        {
            baseSalary += 5000;
        }

        
        double tax = baseSalary * taxRate;

        // Виведення інформації
        Console.WriteLine($"Прізвище: {lastName}");
        Console.WriteLine($"Ім'я: {firstName}");
        Console.WriteLine($"Посада: {position}");
        Console.WriteLine($"Оклад: {baseSalary} грн");
        Console.WriteLine($"Податковий збір: {tax} грн");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Створення екземпляра класу Employee
        Employee employee = new Employee("Гебізов", "Олександр");

        // Виклик методу для розрахунку окладу та податкового збору
        employee.CalculateSalaryAndTax("розробник", 6);

        Console.ReadLine();
    }
}
