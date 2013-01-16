using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GUSGives.Generators
{
    public class HomePhoneGenerator : Generator
    {
        public HomePhoneGenerator(Random rand)
        {
            _rand = rand;
        }

        public string GetNumber(string country, string auState, HashSet<string> allNumbers)
        {
            string number;
            do
            {
                if (country == "Australia")
                {
                    if (auState == "QLD")
                    {
                        int[] prefixes = new[] { 3, 40, 41, 42, 44, 45, 46, 47, 48, 49, 53, 54, 55, 56 };
                        int randIndex = _rand.Next(0, prefixes.Length);
                        number = "07" + prefixes[randIndex].ToString();
                    }
                    else if (auState == "NSW")
                    {
                        int[] prefixes = new[] { 40, 42, 43, 44, 45, 46, 47, 48, 49, 53, 55, 56, 57, 58, 59, 60, 63, 64, 65, 66, 67, 68, 69, 8, 9 };
                        int randIndex = _rand.Next(0, prefixes.Length);
                        number = "02" + prefixes[randIndex].ToString();
                    }
                    else if (auState == "VIC")
                    {
                        int[] prefixes = new[] { 40, 41, 43, 44, 47, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 8, 9 };
                        int randIndex = _rand.Next(0, prefixes.Length);
                        number = "03" + prefixes[randIndex].ToString();
                    }
                    else if (auState == "WA")
                    {
                        int[] prefixes = new[] { 60, 61, 62, 63, 64, 65, 68, 92, 93, 94, 95, 96, 97, 98, 99 };
                        int randIndex = _rand.Next(0, prefixes.Length);
                        number = "08" + prefixes[randIndex].ToString();
                    }
                    else if (auState == "SA")
                    {
                        int[] prefixes = new[] { 70, 71, 72, 73, 74, 75, 76, 81, 82, 83, 84, 85, 86 };
                        int randIndex = _rand.Next(0, prefixes.Length);
                        number = "08" + prefixes[randIndex].ToString();
                    }
                    else if (auState == "TAS")
                    {
                        int[] prefixes = new[] { 61, 62, 63, 64 };
                        int randIndex = _rand.Next(0, prefixes.Length);
                        number = "03" + prefixes[randIndex].ToString();
                    }
                    else if (auState == "ACT")
                    {
                        int[] prefixes = new[] { 61, 62 };
                        int randIndex = _rand.Next(0, prefixes.Length);
                        number = "02" + prefixes[randIndex].ToString();
                    }
                    else if (auState == "NT")
                    {
                        int[] prefixes = new[] { 87, 88, 89 };
                        int randIndex = _rand.Next(0, prefixes.Length);
                        number = "08" + prefixes[randIndex].ToString();
                    }
                    else throw new InvalidOperationException();

                    number += _rand.Next(0, 9999999).ToString().PadLeft(7, '0');
                    number = number.Substring(0, 10).Insert(2, " ").Insert(7, " ");
                }
                else if (country == "England")
                {
                    int[] prefixes = new[] { 1, 2 };
                    int randIndex = _rand.Next(0, prefixes.Length);
                    number = "+44" + prefixes[randIndex].ToString() + _rand.Next(0, 999999999).ToString().PadLeft(9, '0');
                    if(number[3] == '1')
                        number = number.Substring(0, 13).Insert(3, " ").Insert(7, " ").Insert(11, " ");
                    else
                        number = number.Substring(0, 13).Insert(3, " ").Insert(6, " ").Insert(11, " ");
                }
                else
                {
                    int[] prefixes = new[] { 320, 321, 322, 323, 324, 330, 331, 33, 340, 341, 342, 343, 344, 345, 346, 347, 348, 352, 354, 357, 361, 368, 369, 373, 375, 376, 378, 390, 394, 395, 396, 397, 398, 423, 429, 43, 44, 45, 480, 490, 49, 627, 630, 632, 634, 635, 636, 637, 638, 675, 676, 683, 684, 685, 686, 687, 694, 695, 696, 697, 698, 730, 731, 732, 733, 734, 735, 736, 737, 738, 754, 757, 782, 783, 784, 785, 786, 787, 788, 789, 790, 792, 793, 795, 796, 923, 92, 93, 940, 941, 942, 943, 944, 947, 948, 95, 96, 98, 990, 998, 99 };
                    int randIndex = _rand.Next(0, prefixes.Length);
                    number = "+64" + prefixes[randIndex].ToString() + _rand.Next(0, 9999999).ToString().PadLeft(7, '0');
                    number = number.Substring(0, 11).Insert(3, " ").Insert(5, " ").Insert(9, " ");
                }
            }
            while (allNumbers.Contains(number));

            return number;
        }
    }
}
