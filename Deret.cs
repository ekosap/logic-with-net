using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic05
{
    class Deret
    {
        public static int[] fibo(int Leng)
        {
            int[] fibo = new int[Leng];
            for (int i = 0; i < Leng; i++)
            {
                if (i < 2)
                {
                    fibo[i] = 1;
                }
                else
                {
                    fibo[i] = fibo[i - 2] + fibo[i - 1];
                }
            }
            return fibo;
        }

        public static int[] deret1(int nLength)
        {
            int[] array = new int[nLength];
            int angka = 1;
            for (int i = 0; i < nLength; i++)
            {
                array[i] = angka;
                angka += 3;
            }
            return array;
        }

        public static int[] deret2(int p)
        {
            int[] array = new int[p];
            int angka = 1;
            for (int i = 0; i < p; i++)
            {
                array[i] = angka;
                angka += 4;
            }
            return array;
        }
    }
}
