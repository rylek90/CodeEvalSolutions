using System;
using System.Linq;

namespace CodeEvalSolutions
{
    public class Program
    {
        private static bool IsPrime(int number)
        {
            if (number != 0 && number % 2 == 0)
            {
                return false;
            }

            int squared = (int)Math.Sqrt(number);

            for (var i = 3; i <= squared; i += 2)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        private static string Reverse(string text)
        {
            var arr = text.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }

        private static bool IsPalindrome(int number)
        {
            var str = number.ToString();

            var reversed = Reverse(str);

            return str == reversed;
        }

        private static int BiggestPalindrome(int min, int max)
        {

            for (var i = max; max >= min; i -= 1) {
                if (IsPrime(i) && IsPalindrome(i)) {
                    return i;
                }
            }
            
            return 0;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine(BiggestPalindrome(1, 1000));
        }
    }
}
