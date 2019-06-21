using System;
using System.Linq;


namespace Tavisca.Bootcamp.LanguageBasics.Exercise1
{
    class Program
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
            string[] item = equation.Split(delimiterChars);


            //if the first operand has a missing value
            if (item[0].Contains('?'))
            {
                string a = item[0];
                int b = Int32.Parse(item[1]);
                int c = Int32.Parse(item[2]);
                if (c % b != 0)
                {
                    return -1;
                }
                else
                {
                    int ans = c / b;
                    string s = ans.ToString();
                    int indexofq = 0;
                    int matches = 0;
                    
                    if (s.Length == a.Length)
                    {
                        for (int i = 0; i < s.Length; i++)
                        {
                            if (a[i] == '?')
                            {
                                indexofq = i;
                                continue;
                            }
                            if (a[i] == s[i])
                            {
                                matches = matches + 1;
                            }
                        }
                    }
                    else
                    {
                        return (-1);
                    }
                    if (matches == (s.Length - 1))
                    {
                        string s1 = s[indexofq].ToString();
                        return (Int32.Parse(s1));
                    }
                    else
                    {
                        return (-1);
                    }
                }
            }



            //if second operand has missing values
            if (item[1].Contains('?'))
            {
                string b = item[1];
                int a = Int32.Parse(item[0]);
                int c = Int32.Parse(item[2]);
                if (c % a != 0)
                {
                    return -1;
                }
                else
                {
                    int ans = c / a;
                    string s = ans.ToString();
                    int indexofq = 0;
                    int matches = 0;

                    if (s.Length == b.Length)
                    {
                        for (int i = 0; i < s.Length; i++)
                        {
                            if (b[i] == '?')
                            {
                                indexofq = i;
                                continue;
                            }
                            if (b[i] == s[i])
                            {
                                matches = matches + 1;
                            }
                        }
                    }
                    else
                    {
                        return (-1);
                    }
                    if (matches == (s.Length - 1))
                    {
                        string s1 = s[indexofq].ToString();
                        return (Int32.Parse(s1));
                    }
                    else
                    {
                        return (-1);
                    }
                }
            }


            //if third operand has missing value
            if (item[2].Contains('?'))
            {
                string c = item[2];
                int a = Int32.Parse(item[0]);
                int b = Int32.Parse(item[1]);
     
                int ans = a * b;
                string s = ans.ToString();
                int indexofq = 0;
                int matches = 0;
               
                if (s.Length == c.Length)
                {
                    for (int i = 0; i < s.Length; i++)
                    {
                        if (c[i] == '?')
                        {
                            indexofq = i;
                            continue;
                        }
                        if (c[i] == s[i])
                        {
                            matches = matches + 1;
                        }
                    }
                }
                else
                {
                    return (-1);
                }
                if (matches == (s.Length - 1))
                {
                    string s1 = s[indexofq].ToString();
                    return (Int32.Parse(s1));
                }
                else
                {
                    return (-1);
                }
            }
           
            return 0;
            throw new NotImplementedException();
        }
    }
}

