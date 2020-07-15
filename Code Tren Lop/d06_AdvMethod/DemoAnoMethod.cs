using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace d06_AdvMethod
{
    public delegate void DCasio(int a, int b);
    public class DemoAnoMethod
    {
        public void test() {
            DCasio casio = delegate (int x, int y)
            {
                int r = x + y;
                Console.WriteLine($"{x} + {y} = {r}");
            };

            casio += delegate (int x, int y)
            {
                int r = x * y;
                Console.WriteLine($"{x} * {y} = {r}");
            };

            casio(10, 4);
        }
    }

    public static class DemoExtensionMethod
    {
        public static bool ContainIgnocase(this string s, string subs)
        {
            if (Regex.IsMatch(s, subs, RegexOptions.IgnoreCase)) {
                return true;
            }
            return false;
        }
    }
}
