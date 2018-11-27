using System.Collections.Generic;
using Xunit;

namespace Calculator.Tests
{
    /// <summary>
    /// Source: https://andrewlock.net/creating-strongly-typed-xunit-theory-test-data-with-theorydata/
    /// </summary>
    public class CalculatorTests
    {
        [Theory]
        [InlineData(0, 0, 0)]
        [InlineData(1, 2, 3)]
        [InlineData(-2, 2, 0)]
        [InlineData(-4, -6, -10)]
        public void ShouldAddTwoValues_InlineData(int value1, int value2, int expected)
        {
            // Arrange
            var calculator = new CalculatorService();

            // Act
            var result = calculator.Add(value1, value2);

            // Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [MemberData(nameof(CalculatorTestDataMember))]
        public void ShouldAddTwoValues_MemberData(int value1, int value2, int expected)
        {
            // Arrange
            var calculator = new CalculatorService();

            // Act
            var result = calculator.Add(value1, value2);

            // Assert
            Assert.Equal(expected, result);
        }

        public static IEnumerable<object[]> CalculatorTestDataMember =>
            new List<object[]>
            {
                new object[] { 0, 0, 0 },
                new object[] { 1, 2, 3 },
                new object[] { -2, 2, 0 },
                new object[] { -4, -6, -10 },
            };

        [Theory]
        [ClassData(typeof(CalculatorTestDataClass))]
        public void ShouldAddTwoValues_ClassData(int value1, int value2, int expected)
        {
            // Arrange
            var calculator = new CalculatorService();

            // Act
            var result = calculator.Add(value1, value2);

            // Assert
            Assert.Equal(expected, result);
        }
    }

    public class CalculatorTestDataClass : TheoryData<int, int, int>
    {
        public CalculatorTestDataClass()
        {
            this.Add(0, 0, 0);
            this.Add(1, 2, 3);
            this.Add(-2, 2, 0);
            this.Add(-4, -6, -10);
        }
    }
}