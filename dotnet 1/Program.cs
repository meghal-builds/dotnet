using System;

class CurrencyConverter
{
    static void Main()
    {
        const double USD_TO_INR = 91.90;
        const double EURO_TO_INR = 109.63;
        const double FRANC_TO_INR = 119.62;
        const double POUND_TO_INR = 126.42;

        Console.WriteLine("Choose Currency Conversion:");
        Console.WriteLine("1. USD to INR");
        Console.WriteLine("2. EURO to INR");
        Console.WriteLine("3. FRANC to INR");
        Console.WriteLine("4. POUND to INR");
        Console.WriteLine("5. INR to USD");
        Console.WriteLine("6. EURO to USD");
        Console.WriteLine("7. FRANC to USD");
        Console.Write("Select option (1-7): ");

        int option = Convert.ToInt32(Console.ReadLine());

        string fromCurrency = "";
        string toCurrency = "";

        switch (option)
        {
            case 1: fromCurrency = "USD"; toCurrency = "INR"; break;
            case 2: fromCurrency = "EURO"; toCurrency = "INR"; break;
            case 3: fromCurrency = "FRANC"; toCurrency = "INR"; break;
            case 4: fromCurrency = "POUND"; toCurrency = "INR"; break;
            case 5: fromCurrency = "INR"; toCurrency = "USD"; break;
            case 6: fromCurrency = "EURO"; toCurrency = "USD"; break;
            case 7: fromCurrency = "FRANC"; toCurrency = "USD"; break;
            default:
                Console.WriteLine("Invalid option");
                return;
        }

        Console.WriteLine($"You selected: {fromCurrency} to {toCurrency}");
        Console.Write($"Enter amount in {fromCurrency}: ");
        double amount = Convert.ToDouble(Console.ReadLine());

        double result;

        switch (option)
        {
            case 1: result = amount * USD_TO_INR; break;
            case 2: result = amount * EURO_TO_INR; break;
            case 3: result = amount * FRANC_TO_INR; break;
            case 4: result = amount * POUND_TO_INR; break;
            case 5: result = amount / USD_TO_INR; break;
            case 6: result = (amount * EURO_TO_INR) / USD_TO_INR; break;
            case 7: result = (amount * FRANC_TO_INR) / USD_TO_INR; break;
            default: return;
        }

        Console.WriteLine($"Converted Amount: {result} {toCurrency}");
    }
}
