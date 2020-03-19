using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ChocolateKata
{
    public class ChocolateBreaker
    {
        private int count;

        public static int BreakChocolate(int n, int m)
        {
            if (n == 1)
            {
                return m - 1;
            }
            if (m == 1)
            {
                return n - 1;
            }
            return 0;
        }

        public int BreakChocolateAlgo(int n, int m)
        {
            while ((n >= 1 && m > 1) || (n > 1 && m >= 1))
            {
                if (n != 1)
                {
                    if (n % 2 == 0)
                    {
                        n -= 1;
                        count++;
                        count += m - 1;
                    }
                    if (n % 2 != 0 && n != 1)
                    {
                        n -= 1;
                        count++;
                        count += m - 1;
                    }
                }

                if (m != 1)
                {
                    if (m % 2 == 0)
                    {
                        m -= 1;
                        count++;
                        count += n - 1;
                    }

                    if (m % 2 != 0 && m != 1)
                    {
                        m -= 1;
                        count++;
                        count += n - 1;
                    }
                }
            }
            return count;
        }
    }
}
