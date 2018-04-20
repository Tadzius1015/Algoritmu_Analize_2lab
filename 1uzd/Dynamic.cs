using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algoritmu_antras_laboras_1_uzd
{
    class Dynamic
    {
        static int m = 8;
        static int n = 8;
        static int[] a1 = new int[m];
        static int[] a2 = new int[n];
        static int?[] memo = new int?[9];
        public void ArrayAdding()
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
        public int Function(int m, int n, int[,] memo)
        {
            int result = 0;
            if(memo[m,n] != 0)
            {
                return memo[m, n];
            }
            if (n == 0)
                return m;
            else if (m == 0 && n > 0)
                return n;
            else
                result = Math.Min(Math.Min(1 + Function(m - 1, n, memo), 1 + Function(m, n - 1, memo)), DDD(m, n) + Function(m - 1, n - 1, memo));
            memo[m, n] = result;
            return result;
        }
        public int DDD(int a, int b)
        {
            if (a1.GetValue(a) == a2.GetValue(b))
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
