using System;

public class Converter
{
    // Поле курсу валют
    private double usd;
    private double eur;
    private double pln;

    // Конвертер грошей
    public Converter(double usd, double eur, double pln)
    {
        this.usd = usd;
        this.eur = eur;
        this.pln = pln;
    }

    // Конверція з гривні в іншу валюту
    public double ConvertToCurrency(double amount, string currencyCode)
    {
        switch (currencyCode.ToUpper())
        {
            case "USD":
                return amount / usd;
            case "EUR":
                return amount / eur;
            case "PLN":
                return amount / pln;
            default:
                throw new ArgumentException("Непідтримувана валюта");
        }
    }

    // Концверц з іншої валюти в гривню
    public double ConvertFromCurrency(double amount, string currencyCode)
    {
        switch (currencyCode.ToUpper())
        {
            case "USD":
                return amount * usd;
            case "EUR":
                return amount * eur;
            case "PLN":
                return amount * pln;
            default:
                throw new ArgumentException("Непідтримувана валюта");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Converter converter = new Converter(27.5, 32.1, 7.0);

        Console.WriteLine("Оберіть операцію:");
        Console.WriteLine("1. Конвертація з гривні в іншу валюту");
        Console.WriteLine("2. Конвертація з іншої валюти в гривню");

        int choice = Convert.ToInt32(Console.ReadLine());

        if (choice == 1)
        {
            Console.Write("Введіть суму в гривнях: ");
            double amount = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введіть код валюти (USD, EUR, PLN): ");
            string currencyCode = Console.ReadLine();

            double result = converter.ConvertToCurrency(amount, currencyCode);
            Console.WriteLine($"Результат конвертації: {result} {currencyCode}");
        }
        else if (choice == 2)
        {
            Console.Write("Введіть суму в іншій валюті: ");
            double amount = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введіть код валюти (USD, EUR, PLN): ");
            string currencyCode = Console.ReadLine();

            double result = converter.ConvertFromCurrency(amount, currencyCode);
            Console.WriteLine($"Результат конвертації: {result} UAH");
        }
        else
        {
            Console.WriteLine("Помилка операції");
        }

        Console.ReadLine();
    }
}
