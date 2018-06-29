using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
//2^15 = 32768 and the sum of its digits is 3 + 2 + 7 + 6 + 8 = 26.

//What is the sum of the digits of the number 2^1000?

namespace ProjectEuler15_20
{
    class ProjectEuler16
    {
         BigInteger x = new BigInteger(2);

        public  BigInteger bigpow(int n)
        {
            x = BigInteger.Pow(x, n);
            return x;
        }

        
        
        public void Stringarr()
        {
            string c = x.ToString();
            int vc = 0;
            for (int i = 0; i < c.Length; i++)
            {
                vc = vc + Convert.ToInt32(c[i].ToString());
            }

            Console.WriteLine(vc);
        }
    }
}
