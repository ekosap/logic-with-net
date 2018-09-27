using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic05
{
    public class Soal09 : BaseLogic
    {
        public Soal09(int g, int f)
        {
            n = g;
            pSegitiga = n;
            p = f;
            baris = n;
            kolom = pSegitiga * p;
            array = new string[baris, kolom];
        }

        public void Hasil09()
        {
            int geser = 0;
            int[] deret = Deret.deret2(n * n);

            for (int bang = 1; bang <= p; bang++)
            {
                int angka = 0;

                if (bang % 4 == 1)
                {
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            if (j == i || j == 0 || i == n - 1)
                            {
                                array[i, j + geser] = deret[angka].ToString();
                                angka++;

                            }

                        }
                    }
                }
                else if (bang % 4 == 2)
                {
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            if (j + i == n-1 || j == 0 || i == 0)
                            {
                                array[i, j + geser] = deret[angka].ToString();
                                angka++;

                            }

                        }
                    }
                }
            
                else if (bang % 4 == 3)
                {
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            if (j == i || j == n - 1 || i == 0)
                            {
                                array[i, j + geser] = deret[angka].ToString();
                                angka++;

                            }

                        }
                    }
                }
                else
                {
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            if (j + i == n - 1 || j == n - 1 || i == n - 1)
                            {
                                array[i, j + geser] = deret[angka].ToString();
                                angka++;

                            }

                        }
                    }
                }
                geser += pSegitiga;
            }
            CetakData();
        }
    }
}
