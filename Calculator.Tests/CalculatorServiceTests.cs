using Xunit;

namespace Calculator.Tests
{
    public class CalculatorServiceTests
    {
        [Fact]
        public void ShouldAddTwoNumbers()
        {
            // Arrange
            const decimal parameter1 = 1.0m;
            const decimal parameter2 = 2.0m;
            const decimal expectedResult = 3.0m;

            var calculator = new CalculatorService();

            // Act
            var result = calculator.Add(parameter1, parameter2);

            // Assert
            Assert.Equal(expectedResult, result);
        }
    }
}