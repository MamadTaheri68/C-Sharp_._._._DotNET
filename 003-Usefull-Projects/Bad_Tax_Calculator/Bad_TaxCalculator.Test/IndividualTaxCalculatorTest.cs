using Bad_TaxCalculator.Entity;
using System;
using Xunit;

namespace Bad_TaxCalculator.Test
{
    public class IndividualTaxCalculatorTest
    {

        [Fact]
        public void Disable_Taxpayer_SHOULD_Pay_Zero_Percent_Tax()
        {
            // Arrange
            TaxPayer taxPayer = new TaxPayer
            {
                TaxCitizen = true,
                HasDisability = true,
            };
            IndividualTaxCalculator individualTaxCalculator = new IndividualTaxCalculator();

            // Act
            var Result = individualTaxCalculator.CalculateTaxPercentage(taxPayer);

            // Assert
            Assert.Equal(0, Result);
        }


        [Fact]
        public void None_TaxResident_SHOULD_NOT_BE_Calculated()
        {
            // Arrange
            TaxPayer taxPayer = new TaxPayer
            {
                TaxCitizen = false
            };
            IndividualTaxCalculator individualTaxCalculator = new IndividualTaxCalculator();

            // Act
            string expectedErrorMessage = "No TAX Calculation for NON-TAX REsidents";

            var ExceptionResult = Assert.Throws<InvalidOperationException>(() =>
            individualTaxCalculator.CalculateTaxPercentage(taxPayer));

            // Assert
            Assert.Equal(expectedErrorMessage, ExceptionResult.Message);
        }
    }
}