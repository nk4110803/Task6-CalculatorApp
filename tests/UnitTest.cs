using src;

namespace test
{
    public class UnitTest
    {
        [Fact]
        public void Add_TwoPositiveNumbers_ReturnsCorrectSum()
        {
            var operationFactory = new OperationFactory();
            var calculator = new Calculator(operationFactory);
            var result = calculator.Calculate("5 + 10");
            Assert.Equal(15, result);
        }
        [Fact]
        public void Subtract_TwoPositiveNumbers_ReturnsCorrectDifference()
        {
            var operationFactory = new OperationFactory();
            var calculator = new Calculator(operationFactory);
            var result = calculator.Calculate("10 - 5");
            Assert.Equal(5, result);
        }
        [Fact]
        public void multiplication_TwoPositiveNumbers_ReturnsCorrectRresult()
        {
            var operationFactory = new OperationFactory();
            var calculator = new Calculator(operationFactory);
            var result = calculator.Calculate("10 * 5");
            Assert.Equal(50, result);
        }
        [Fact]
        public void Division_TwoPositiveNumbers_ReturnsCorrectRresult()
        {
            var operationFactory = new OperationFactory();
            var calculator = new Calculator(operationFactory);
            var result = calculator.Calculate("50 / 10");
            Assert.Equal(5, result);
        }
        [Fact]
        public void Add_IgnoreWhitespace_ReturnsCorrect()
        {
            var operationFactory = new OperationFactory();
            var calculator = new Calculator(operationFactory);
            var result = calculator.Calculate("  7   +   3  ");
            Assert.Equal(10, result);
        }
        [Fact]
        public void DivisionByZero_ThrowsException()
        {
            var operationFactory = new OperationFactory();
            var calculator = new Calculator(operationFactory);
            Assert.Throws<DivideByZeroException>(() => calculator.Calculate("8/0"));
        }
        [Fact]
        public void HandlesPrecedence_ReturnsCorrect()
        {
            var operationFactory = new OperationFactory();
            var calculator = new Calculator(operationFactory);
            var result = calculator.Calculate("4 +5*4/2-8 ");
            Assert.Equal(6, result);
        }


    }
}