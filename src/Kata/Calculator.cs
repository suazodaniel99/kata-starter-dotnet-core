using System;
using System.Linq;
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

            var separator = new [] {",", "\n"};

            var content = input;
            if (input.StartsWith("//"))
            {
                var parts = input.Split("\n");
                content = parts[1];
                separator = new[] {parts[0].Replace("//", "")};
            }
            
            var numbers = content.Split(separator, StringSplitOptions.None).Select(int.Parse);
            return numbers.Sum();
        }
    }
}