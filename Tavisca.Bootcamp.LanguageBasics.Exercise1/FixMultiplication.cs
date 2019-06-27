using System;
using System.Linq;


namespace Tavisca.Bootcamp.LanguageBasics.Exercise1
{
    public class FixMultiplication
    {
        static void Main(string[] args)
        {
            Test("42*47=1?74", 9);
            Test("4?*47=1974", 2);
            Test("42*?7=1974", 4);
            Test("42*?47=1974", -1);
            Test("2*12?=247", -1);
            Console.ReadKey(true);
        }

        private static void Test(string args, int expected)
        {
            var result = FindDigit(args).Equals(expected) ? "PASS" : "FAIL";
            Console.WriteLine($"{args} : {result}");
        }

        public static int FindDigit(string equation)
        {

            char[] delimiterChars = { '*', '=' };
            string[] numbers = equation.Split(delimiterChars);

            string num1 = numbers[0];
            string num2 = numbers[1];
            string product = numbers[2];
            string output;

            //if the first operand has a missing value
            if (num1.Contains('?'))
            {
                if (Int32.Parse(product) % Int32.Parse(num2) != 0)
                    return -1;
                else
                {
                    output = (Int32.Parse(product) / Int32.Parse(num2)).ToString();
                    if (output.Length == numbers[0].Length)
                    {
                        return Convert.ToInt32(output[num1.IndexOf('?')].ToString());
                    }
                    else
                        return -1;
                }
            }
           
            //if second operand has missing values
            if (num2.Contains('?'))
            {
                if ((Int32.Parse(product) % Int32.Parse(num1)) !=0)
                    return -1;
                else
                {
                    output = (Int32.Parse(product) / Int32.Parse(num1)).ToString();
                    if (output.Length == numbers[1].Length)
                    {
                        return Convert.ToInt32(output[num2.IndexOf('?')].ToString());
                    }
                    else
                        return -1;
                }
            }

            //if third operand has missing value
            if (product.Contains('?'))
            {
                output = (Int32.Parse(num1) * Int32.Parse(num2)).ToString();
                if (output.Length == numbers[2].Length)
                {
                    return Convert.ToInt32(output[product.IndexOf('?')].ToString());
                }
                else
                    return -1;
            }
            else
                return -1;
        }
    }
}
