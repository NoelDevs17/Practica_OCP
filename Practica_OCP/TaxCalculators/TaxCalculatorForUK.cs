using Practica_OCP.Interface;

namespace Practica_OCP.TaxCalculator
{
    public class TaxCalculatorForUK : ICountryTaxCalculatorStrategy
    {
      
            public decimal CalculateTaxAmount(decimal totalIncome, decimal totalDeduction)
            {
                decimal taxableIncome = totalIncome - totalDeduction;
                return taxableIncome * 0.35m; // Tasa de impuesto del 35%
            }
        

    }
}
