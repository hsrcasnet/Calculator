using System.Collections.Generic;
using Xunit;
using Xunit.Abstractions;

namespace Calculator.Tests
{
    /// <summary>
    /// DEMO: xUnit features:
    /// - ITestOutputHelper
    /// - Theory, InlineData, MemberData, ClassData
    /// Source: https://andrewlock.net/creating-strongly-typed-xunit-theory-test-data-with-theorydata/
    /// </summary>
    public class CalculatorServiceTheoryTests
    {
        private readonly ITestOutputHelper testOutputHelper;

        public CalculatorServiceTheoryTests(ITestOutputHelper testOutputHelper)
        {
            this.testOutputHelper = testOutputHelper;
        }

        [Theory]
        [InlineData(0, 0, 0)]
        [InlineData(1, 2, 3)]
        [InlineData(-2, 2, 0)]
        [InlineData(-4, -6, -10)]
        public void ShouldAddTwoValues_InlineData(int value1, int value2, int expectedResult)
        {
            // Arrange
            var calculator = new CalculatorService();

            // Act
            var result = calculator.Add(value1, value2);

            // Assert
            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [MemberData(nameof(CalculatorTestDataMember))]
        public void ShouldAddTwoValues_MemberData(int value1, int value2, int expectedResult)
        {
            // Arrange
            var calculator = new CalculatorService();

            // Act
            var result = calculator.Add(value1, value2);

            // Assert
            Assert.Equal(expectedResult, result);
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
        public void ShouldAddTwoValues_ClassData(int value1, int value2, int expectedResult)
        {
            // Arrange
            var calculator = new CalculatorService();

            // Act
            var result = calculator.Add(value1, value2);

            // Assert
            this.testOutputHelper.WriteLine($"result={result}, expectedResult={expectedResult}");

            Assert.Equal(expectedResult, result);
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