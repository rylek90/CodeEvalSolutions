using System;

namespace CodeEvalSolutions
{
    public class SumOfPrimes
    {
        private static bool IsPrime(int number)
        {
            if ((number & 1) == 0) {
                return number == 2 && number != 1;
            }
            
            for (var i = 3; (int)Math.Pow(i, 2) <= number; i+=2) {
                if (number % i == 0) {
                    return false;
                }
            }
            
            return true;
        }

        static void Main(string[] args)
        {
            var num = 2;
            var count = 0;
            var sum = 0;
            
            while (count < 1000) {
                if (IsPrime(num)) {
                    sum += num;
                    count += 1;
                }
                num += 1;
            }
            
            Console.WriteLine(sum);
        }
    }
}
