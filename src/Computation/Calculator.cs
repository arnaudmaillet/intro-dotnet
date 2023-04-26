using System;
using System.Linq;

namespace Computation
{
    public class Calculator
    {
        public int SumNumbers(int start, int count)
        {
            // TODO #1: Get all tests passing

            //var res = 0;

            //for (int i = start; i < start + count; start++)
            //{
            //    res += i;
            //}
            //return res;

            // TODO #2: Refactor so there are no loopss or if statements

            // TODO #3: Refactor to use the Aggregate() LINQ method
            return Enumerable.Range(start, count).Aggregate(0, (acc, x) => acc + x);
       
            throw new NotImplementedException();
        }
    }
}
