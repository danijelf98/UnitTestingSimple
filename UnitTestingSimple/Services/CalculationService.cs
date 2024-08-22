using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestingSimple.Services
{
    public class CalculationService
    {
        public int Add(int numA, int numB)
        {
            return numA + numB;
        }
        public int Subtract(int numA, int numB)
        {
            return numA - numB;
        }
        public int Multiply(int numA, int numB)
        {
            return numA * numB;
        }
        public int Divide(int numA, int numB)
        {
            return numA / numB;
        }
    }
}
