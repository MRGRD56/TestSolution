using System;
using System.Collections.Generic;
using System.Linq;

namespace TestSolution
{
    internal static class Program
    {
        private static void Main()
        {
            var strings = new List<string>()
            {
                "somesrf один два",
                "123adsrf  fdefd",
                "helloi wordl1"
            };
            strings
                .Where(x => x.Contains("1"))
                .ToList()
                .ForEach(Console.WriteLine);
            string newString = "some test (beta)"; //master
            //some new text
        }
    }
}