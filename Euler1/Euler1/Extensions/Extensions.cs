using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Euler1.Extensions
{
    public static class Extensions
    {
        public static IEnumerable<int> GetNumbersMultiple3or5(this int number)
        {

            do
            {
                if ((int)(number % 3) == 0 || (int)(number % 5) == 0)
                    yield return number;

                number--;
            }
            while (number > 0);
        }

        public static int ReadOnlyNumbers(this string line) => 
            Regex.Split(line, @"\D+")
              .Aggregate(0, (x, y) =>
              Int32.Parse($"{x}{y}"));

           

        //public static int ReadOnlyNumbers(this string line)
        //{
        //    var entered = Regex.Split(line, @"\D+")
        //      .Select(s =>
        //      {
        //          int value;
        //          bool success = int.TryParse(s, out value);
        //          return new { value, success };
        //      })
        //      .Where(x => x.success)
        //      .Select(x => x.value)
        //      .Aggregate(0, (x, y) =>
        //      Int32.Parse($"{x}{y}"));

        //    //if (entered.Count() == 0)
        //    //    return 0;

        //    //int input = Int32.Parse(string.Join("", entered));

        //    return entered;
        //}
    }
}
