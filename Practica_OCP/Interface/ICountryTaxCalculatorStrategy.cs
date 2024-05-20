
namespace Practica_OCP.Interface
{
    public interface ICountryTaxCalculatorStrategy
    {
        decimal CalculateTaxAmount(decimal totalIncome, decimal totalDeduction);
    }
}
