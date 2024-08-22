using UnitTestingSimple.Services;

namespace UnitTestingSimple.UnitTest
{
    public class CalculationServiceUnitTest
    {
        private readonly CalculationService calculatorService;

        public CalculationServiceUnitTest()
        {
            calculatorService = new CalculationService();
        }

        [Fact]
        public void Add_AddsTwoNumbers_ChecksIfTheResultIsEqualToTheGivenNumber()
        {
            int a = 2;
            int b = 3;
            int result = 5;

            var calculationResult = calculatorService.Add(a, b);
            Assert.Equal(result, calculationResult);
        }
        [Fact]
        public void Subtract_SubtractsTwoNumbers_ChecksIfTheResultIsEqualToTheGivenNumber()
        {
            int a = 5;
            int b = 3;
            int result = 2;

            var calculationResult = calculatorService.Subtract(a, b);
            Assert.Equal(result, calculationResult);
        }
        [Fact]
        public void Multiply_MultipliesTwoNumbers_ChecksIfTheResultIsEqualToTheGivenNumber()
        {
            int a = 5;
            int b = 3;
            int result = 15;

            var calculationResult = calculatorService.Multiply(a, b);
            Assert.Equal(result, calculationResult);
        }
        [Fact]
        public void Divide_MultipliesTwoNumbers_ChecksIfTheResultIsEqualToTheGivenNumber()
        {
            int a = 15;
            int b = 3;
            int result = 5;

            var calculationResult = calculatorService.Divide(a, b);
            Assert.Equal(result, calculationResult);
        }
    }
}