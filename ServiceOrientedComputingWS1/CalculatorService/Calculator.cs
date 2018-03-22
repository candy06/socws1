
namespace CalculatorService
{
    class Calculator : ICalculator
    {
        public int Substraction(int a, int b)
        {
            return (a - b);
        }

        public int Sum(int a, int b)
        {
            return (a + b);
        }
    }
}
