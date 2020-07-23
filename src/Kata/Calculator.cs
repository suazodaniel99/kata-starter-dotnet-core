using System.Net.Http.Headers;

namespace Kata
{
    public class Calculator
    {
        public int Add(string input = "")
        {
            if (string.IsNullOrEmpty(input))
            {
                return 0;                
            }
            
            string[] numbers = input.Split(",");

            if (numbers.Length == 1)
            {
                return int.Parse(input);
            }

            return int.Parse(numbers[0]) + int.Parse(numbers[1]);
        }
    }
}