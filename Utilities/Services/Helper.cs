using System;
using System.Linq;

namespace Utilities
{
    public class Helper
    {
        public enum TriangleType
        {
            Isoseles,
            Equilateral,
            Scalene
        };
        public static string ReverseWords(string text)
        {
            return string.Join(" ", text.Split(' ').Select(x => new String(x.Reverse().ToArray())));
        }

        public static ulong GetFibonacci(int index)
        {
            double sqrt5 = Math.Sqrt(5);
            double p1 = (1 + sqrt5) / 2;
            double p2 = -1 * (p1 - 1);


            double n1 = Math.Pow(p1, index);
            double n2 = Math.Pow(p2, index);
            return (ulong)((n1 - n2) / sqrt5);
        }

        public static string GetTriangleType(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0 || (a + b < c) || (a + c < b) || (b + c < a))
                return "Error";
            if (a.CompareTo(b) != 0 && a.CompareTo(c) != 0)
                return TriangleType.Scalene.ToString();
            else if (a.CompareTo(b) == 0 && a.CompareTo(c) == 0)
                return TriangleType.Equilateral.ToString();
            else
                return TriangleType.Isoseles.ToString();
        }
    }
}
