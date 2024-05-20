using Practica_OCP.Interface;

namespace Practica_OCP.TaxCalculator
{
    public class TaxCalculatorForUs : ICountryTaxCalculatorStrategy
    {
            public decimal CalculateTaxAmount(decimal totalIncome, decimal totalDeduction)
            {
                decimal taxableIncome = totalIncome - totalDeduction;
                return taxableIncome * 0.3m; // Tasa de impuesto del 30%
            }

    }
}
