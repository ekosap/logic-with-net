using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic05
{
    class Soal10:BaseLogic
    {
        public Soal10(int x, int y)
        {
            n = x;
            p = y;
            pSegitiga = n+1;
            baris = n;
            kolom = pSegitiga * p;
            array = new string[baris, kolom];
        }

        public void Hasil10()
        {
            int geser = 0;
            int[] deret = Deret.deret1(27);
            for (int bangun = 1; bangun <= p; bangun++)
            {
                int angka = 0;
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (i == 0)
                        {
                            array[i, j+geser] = deret[angka].ToString();
                            angka++;
                            if (j >= n)
                                break;
                        }
                        if (j==n-1)
                        {
                            array[i, j + geser] = deret[angka].ToString();
                            angka++;
                            if (i >= n)
                                break;
                        }
                        if (i==n-1)
                        {
                            array[i, (n-1-j) + geser] = deret[angka].ToString();
                            angka++;
                            if (j >= n)
                                break;
                        }
                        if (j == 0)
                        {
                            array[n-1-i, j + geser] = deret[angka].ToString();
                            angka++;

                        }
                    }
                }
                geser += pSegitiga;
            }
            CetakData();
        }
    }
}
