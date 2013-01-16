using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GUSGives.Generators
{
    public class MobilePhoneGenerator : Generator
    {
        public MobilePhoneGenerator(Random rand)
        {
            _rand = rand;
        }

        public string GetNumber(string country, HashSet<string> allNumbers)
        {
            string number;
            do
            {
                if (country == "Australia")
                {
                    string[] prefixes = new[] { "00", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "37", "38", "39", "44", "46", "47", "48", "49", "50", "51", "52", "53", "57", "58", "59", "66", "67", "68", "69", "70", "77", "78", "79", "87", "88", "89", "98", "99" };
                    int randIndex = _rand.Next(0, prefixes.Length);
                    number = "04" + prefixes[randIndex].ToString() + _rand.Next(0, 999999).ToString().PadLeft(6, '0');

                    number = number.Substring(0, 10).Insert(4, " ").Insert(8, " ");
                }
                else if (country == "England")
                {
                    int[] prefixes = new[] { 74, 75, 77, 78, 79 };
                    int randIndex = _rand.Next(0, prefixes.Length);
                    number = "+44" + prefixes[randIndex].ToString() + _rand.Next(0, 99999999).ToString().PadLeft(8, '0');
                    number = number.Substring(0, 13).Insert(3, " ").Insert(8, " ");
                }
                else
                {
                    int[] prefixes = new[] { 21, 22, 27, 29 };
                    int randIndex = _rand.Next(0, prefixes.Length);
                    number = "+64" + prefixes[randIndex].ToString() + _rand.Next(0, 9999999).ToString().PadLeft(7, '0');
                    number = number.Substring(0, 12).Insert(3, " ").Insert(6, " ").Insert(11, " ");
                }
            }
            while (allNumbers.Contains(number));

            return number;
        }
    }
}
