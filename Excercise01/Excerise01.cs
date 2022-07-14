using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise01
{
    public class Excerise01
    {
        public string IntegerToWords(ulong inputNum)
        {
            int dig1, dig2, dig3, level = 0, lasttwo, threeDigits;

            string retval = "";
            string x = "";
            string[] ones ={
                "zero",
                "one",
                "two",
                "three",
                "four",
                "five",
                "six",
                "seven",
                "eight",
                "nine",
                "ten",
                "eleven",
                "twelve",
                "thirteen",
                "fourteen",
                "fifteen",
                "sixteen",
                "seventeen",
                "eighteen",
                "nineteen"
              };
            string[] tens ={
                "zero",
                "ten",
                "twenty",
                "thirty",
                "forty",
                "fifty",
                "sixty",
                "seventy",
                "eighty",
                "ninety"
              };
            string[] thou ={
                "",
                "thousand",
                "million",
                "billion",
                "trillion",
                "quadrillion",
                "quintillion"
              };

            bool isNegative = false;
            if (inputNum < 0)
            {
                isNegative = true;
                //inputNum *= -1;
            }

            if (inputNum == 0)
                return ("zero");

            string s = inputNum.ToString();

            while (s.Length > 0)
            {
                // Get the three rightmost characters
                x = (s.Length < 3) ? s : s.Substring(s.Length - 3, 3);

                // Separate the three digits
                threeDigits = int.Parse(x);
                lasttwo = threeDigits % 100;
                dig1 = threeDigits / 100;
                dig2 = lasttwo / 10;
                dig3 = (threeDigits % 10);

                // append a "thousand" where appropriate
                if (level > 0 && dig1 + dig2 + dig3 > 0)
                {
                    retval = thou[level] + " " + retval;
                    retval = retval.Trim();
                }

                // check that the last two digits is not a zero
                if (lasttwo > 0)
                {
                    if (lasttwo < 20) // if less than 20, use "ones" only
                        retval = ones[lasttwo] + " " + retval;
                    else // otherwise, use both "tens" and "ones" array
                        retval = tens[dig2] + " " + ones[dig3] + " " + retval;
                }

                // if a hundreds part is there, translate it
                if (dig1 > 0)
                    retval = ones[dig1] + " hundred " + retval;

                s = (s.Length - 3) > 0 ? s.Substring(0, s.Length - 3) : "";
                level++;
            }

            while (retval.IndexOf("  ") > 0)
                retval = retval.Replace("  ", " ");

            retval = retval.Trim();

            if (isNegative)
                retval = "negative " + retval;

            //Console.WriteLine("Number in words is \n{0}", retval);
            return (retval);
        }
    }
}
