using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algoritmu_antras_laboras_1_uzd
{
    class Dynamic
    {
        static int m = 10;
        static int n = 10;
        static int[] a1 = new int[m];
        static int[] a2 = new int[n];
        static int?[,] memo = new int?[m + 1, n + 1];
        private int operationsCount = 0;
        public void ArrayAdding()
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
        public int Function(int m, int n, int[,] memo)
        {
            operationsCount++;
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
        private int DDD(int a, int b)
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
        public int GetOperationsCountt()
        {
            return operationsCount;
        }
    }
}
