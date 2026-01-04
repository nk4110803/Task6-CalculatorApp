using src;

namespace test
{
    public class UnitTest
    {
        [Fact]
        public void Add_TwoPositiveNumbers_ReturnsCorrectSum()
        {
            var calculator = new Calculator();
            var result = calculator.Calculate("5 + 10");
            Assert.Equal(15, result);
        }
        [Fact]
        public void Subtract_TwoPositiveNumbers_ReturnsCorrectDifference()
        {
            var calculator = new Calculator();
            var result = calculator.Calculate("10 - 5");
            Assert.Equal(5, result);
        }
        [Fact]
        public void multiplication_TwoPositiveNumbers_ReturnsCorrectRresult()
        {
            var calculator = new Calculator();
            var result = calculator.Calculate("10 * 5");
            Assert.Equal(50, result);
        }
        [Fact]
        public void Division_TwoPositiveNumbers_ReturnsCorrectRresult()
        {
            var calculator = new Calculator();
            var result = calculator.Calculate("50 / 10");
            Assert.Equal(5, result);
        }
        [Fact]
        public void Add_IgnoreWhitespace_ReturnsCorrect()
        {
            var calculator = new Calculator();
            var result = calculator.Calculate("  7   +   3  ");
            Assert.Equal(10, result);
        }
        [Fact]
        public void DivisionByZero_ThrowsException()
        {
            var calc = new Calculator();
            Assert.Throws<DivideByZeroException>(() => calc.Calculate("8/0"));
        }
        [Fact]
        public void HandlesPrecedence_ReturnsCorrect()
        {
            var calculator = new Calculator();
            var result = calculator.Calculate("4 +5*4/2-8 ");
            Assert.Equal(6, result);
        }


    }
}