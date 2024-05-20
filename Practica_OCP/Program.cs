using Practica_OCP.Interface;
using Practica_OCP.TaxCalculator;

public class Program
{
    public static void Main(string[] args)
    {
        // Obtener la entrada del usuario para el país
        Console.WriteLine("Ingrese el país (USA, UK, IN): ");
        string country = Console.ReadLine().ToUpper();

        // Obtener la entrada del usuario para el ingreso total y la deducción
        Console.WriteLine("Ingrese el ingreso total: ");
        decimal totalIncome = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese la deducción total: ");
        decimal totalDeduction = decimal.Parse(Console.ReadLine());

        // Crear la estrategia de calculadora de impuestos adecuada según el país
        ICountryTaxCalculatorStrategy taxCalculatorStrategy;
        switch (country)
        {
            case "USA":
                taxCalculatorStrategy = new TaxCalculatorForUs();
                break;
            case "UK":
                taxCalculatorStrategy = new TaxCalculatorForUK();
                break;
            case "IN":
                taxCalculatorStrategy = new TaxCalculatorForIN();
                break;
            default:
                Console.WriteLine("País no válido. Saliendo.");
                return;
        }

        // Calcular el monto del impuesto utilizando la estrategia
        decimal taxAmount = taxCalculatorStrategy.CalculateTaxAmount(totalIncome, totalDeduction);

        // Mostrar el resultado
        Console.WriteLine($"Impuesto total para {country}: {taxAmount}");
    }
}
