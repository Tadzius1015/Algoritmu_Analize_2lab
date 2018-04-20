using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algoritmu_antras_laboras_1_uzd
{
    class Program
    {
        static int m = 8;
        static int n = 8;
        static int[] a1 = new int[m];
        static int[] a2 = new int[n];
        static int[,] memo = new int[m + 1, n + 1];
        static void Main(string[] args)
        {
            ArrayAdding(a1, a2);
            int k = Function(m - 3, n - 1);
            Console.WriteLine(k);
            Dynamic dyn = new Dynamic();
            dyn.ArrayAdding();
            int t = dyn.Function(m - 3,n - 1,memo);
            Console.WriteLine(t);
        }
        private static void ArrayAdding(Array a1, Array a2)
        {
            a1.SetValue(4, 0);
            a1.SetValue(2, 1);
            a1.SetValue(8, 2);
            a1.SetValue(10, 3);
            a1.SetValue(5, 4);
            a1.SetValue(1, 5);
            a1.SetValue(6, 6);
            a1.SetValue(7, 7);
            a2.SetValue(8, 0);
            a2.SetValue(9, 1);
            a2.SetValue(10, 2);
            a2.SetValue(15, 3);
            a2.SetValue(6, 4);
            a2.SetValue(1, 5);
            a2.SetValue(2, 6);
            a2.SetValue(3, 7);
        }
        public static int Function(int m, int n)
        {
            if (n == 0)
            {
                return m;
            }
            else if(m == 0 && n > 0)
            {
                return n;
            }
            else
            {
                return Math.Min(Math.Min(1 + Function(m - 1, n), 1 + Function(m, n - 1)), DDD(m,n) + Function(m - 1, n - 1));
            }
        }
        public static int DDD(int a, int b)
        {
            if(a1.GetValue(a) == a2.GetValue(b))
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
