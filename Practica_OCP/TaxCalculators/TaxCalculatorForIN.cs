
using Practica_OCP.Interface;

namespace Practica_OCP.TaxCalculator
{
    public class TaxCalculatorForIN : ICountryTaxCalculatorStrategy
    {
       
            public decimal CalculateTaxAmount(decimal totalIncome, decimal totalDeduction)
            {
                decimal taxableIncome = totalIncome - totalDeduction;
                return taxableIncome * 0.2m; // Tasa de impuesto del 20%
           }
        

    }
}

