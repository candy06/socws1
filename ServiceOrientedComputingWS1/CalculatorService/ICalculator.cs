using System.ServiceModel;

namespace CalculatorService
{
    [ServiceContract]
    interface ICalculator
    {
        [OperationContract]
        int Sum(int a, int b);
        [OperationContract]
        int Substraction(int a, int b);
    }
}
