using System.Linq;

namespace CalculatorEngine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var calcRequests = new List<CalculationRequest>();

            calcRequests.Add(new CalculationRequest { CalculationType = CalculationType.Average, Input = new[] { 1, 6, 5, 4, 6, 7 }.ToList() });
            calcRequests.Add(new CalculationRequest { CalculationType = CalculationType.Sum, Input = new[] { 1, 8, 5, 2, 34, 3, 5 }.ToList() });
            calcRequests.Add(new CalculationRequest { CalculationType = CalculationType.SumOfFibonacci, Input = new[] { 1, 8, 5, 2, 2, 3, 5 }.ToList() });

            RunCalculations(calcRequests);
        }

        /*
         * Run calculations and print output to console
         */
        static void RunCalculations(List<CalculationRequest> calculationRequests)
        {

        }

        enum CalculationType
        {
            Sum, //Sum of elements in the array
            Average, //Average of elements in the array
            SumOfFibonacci //Sum of the fibonacci(el) for each el in the array. fibonacci is defined as f(x) = f(x - 1) + f(x - 2). f(0) = 0, f(1) = 1
        }

        class CalculationRequest
        {
            public List<int> Input { get; set; }
            public CalculationType CalculationType { get; set; }
        }
    }
}