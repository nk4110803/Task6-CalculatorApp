using src;

namespace test
{
    public class UnitTest
    {
        [Fact]
        public void Add_TwoPositiveNumbers_ReturnsCorrectSum()
        {
            var calculator = new Calculator();
            var result = calculator.Add("5 + 10");
            Assert.Equal(15, result);
        }
        [Fact]
        public void Subtract_TwoPositiveNumbers_ReturnsCorrectDifference()
        {
            var calculator = new Calculator();
            var result = calculator.Subtraction("10 - 5");
            Assert.Equal(5, result);
        }
        [Fact]
        public void multiplication_TwoPositiveNumbers_ReturnsCorrectRresult()
        {
            var calculator = new Calculator();
            var result = calculator.multiplication("10 * 5");
            Assert.Equal(50, result);
        }
        [Fact]
        public void Division_TwoPositiveNumbers_ReturnsCorrectRresult()
        {
            var calculator = new Calculator();
            var result = calculator.Division("50 / 10");
            Assert.Equal(5, result);
        }
        [Fact]
        public void Add_IgnoreWhitespace_ReturnsCorrect()
        {
            var calculator = new Calculator();
            var result = calculator.Add("  7   +   3  ");
            Assert.Equal(10, result);
        }
        [Fact]
        public void DivisionByZero_ThrowsException()
        {
            var calc = new Calculator();
            Assert.Throws<DivideByZeroException>(() => calc.Division("8/0"));
        }


    }
}