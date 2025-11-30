using Xunit;
using CiCdDemo;

namespace CiCdDemo.Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void Add_ReturnsCorrectResult()
        {
            var calc = new Calculator();
            Assert.Equal(6, calc.Add(2, 3));
        }

        [Fact]
        public void Subtract_ReturnsCorrectResult()
        {
            var calc = new Calculator();
            Assert.Equal(1, calc.Subtract(3, 2));
        }
    }

    public static class Program
    {
        public static void Main() { }
    }
}
