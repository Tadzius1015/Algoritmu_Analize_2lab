using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace algoritmu_antras_laboras_1_uzd
{
    class Program
    {
        static int m = 10;
        static int n = 10;
        static int[] a1 = new int[m];
        static int[] a2 = new int[n];
        static int[,] memo = new int[m + 1, n + 1];
        static int operationsCount = 0;
        static void Main(string[] args)
        {
            Stopwatch timer = new Stopwatch();
            ArrayAdding(a1, a2, m, n);
            timer.Start();
            int k = Function(m - 3, n - 1);
            timer.Stop();
            TimeSpan time1 = timer.Elapsed;
            timer.Reset();
            Console.WriteLine(k);
            Console.WriteLine("Rekursijos operacijų kiekis: " + operationsCount);
            Console.WriteLine("Rekursijos vykdymo laikas: " + time1);
            Dynamic dyn = new Dynamic();
            dyn.ArrayAdding();
            timer.Start();
            int t = dyn.Function(m - 3,n - 1,memo);
            timer.Stop();
            TimeSpan time2 = timer.Elapsed;
            timer.Stop();
            Console.WriteLine(t);
            Console.WriteLine("Dinaminio programavimo operacijų kiekis: " + dyn.GetOperationsCountt());
            Console.WriteLine("Dinaminio programavimo vykdymo laikas: " + time2);
        }
        private static void ArrayAdding(Array a1, Array a2, int m, int n)
        {
            Random rnd = new Random();
            for (int i = 0; i < m; i++)
            {
                a1.SetValue(rnd.Next(0, 500), i);
            }
            for (int i = 0; i < n; i++)
            {
                a2.SetValue(rnd.Next(0, 500), i);
            }
        }
        private static int Function(int m, int n)
        {
            operationsCount++;
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
        private static int DDD(int a, int b)
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
