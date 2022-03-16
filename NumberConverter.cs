using System;
using System.Text.RegularExpressions;

namespace ProjectRefresh
{
    public class NumberConverter
    {
        public NumberConverter()
        {
        }
        public bool status { get; set; } = false;
        public string resultMsg { get; set; } = "";
        public int numOfOne { get; set; } = 0;
        public int BinaryToDecimal(string input)
        {

            if (input.Length > 32)
            {
                resultMsg = $"{input} is too long";
                status = false;
                return -1;
            }

            Regex r = new Regex(@"[^01]");
            Match m = r.Match(input);
            if (m.Success)
            {
                status = false;
                resultMsg = $"{input} contains non binary char";
                return -1;
            }


            int power = 0;
            int n = 0;
            int x;
            for (int i = input.Length - 1; i >= 0; i--)
            {

                bool success = int.TryParse(input[i].ToString(), out x);
                if (success)
                {
                    if (x == 1)
                        numOfOne++;
                    n += (x * (int)Math.Pow(2, power));
                    power++;
                }
            }
            status = true;
            resultMsg = "Success";
            return n;


        }
        public string DecimalToBinary(string input)
        {
            string r = "";
            int x;
            bool success = int.TryParse(input, out x);
            if (success)
            {

                while (x >= 1)
                {
                    int d = x % 2;
                    if (d == 1)
                        numOfOne++;
                    r = d + r;
                    x = (x - d) / 2;
                }
                resultMsg = "Success";
                status = true;


            }
            else
            {
                resultMsg = $"{input} is not a decimal number ";
                status = false;

            }
            return r;


        }
    }
}
