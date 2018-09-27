using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic05
{
    public class Soal06 : BaseLogic
    {
        public Soal06(int x, int y)
        {
            n = x;
            p = y;
            pSegitiga = (2 * n) - 1;
            baris = n;
            kolom = pSegitiga*n;
            array = new string[baris, kolom];
        }

        public void Hasil06()
        {
            int geser = 0;
            int[] fibon = Deret.fibo(n * n);
            for (int bangun = 1; bangun <= p; bangun++)
            {
                int angka = 0;
                for (int i = 0; i < baris; i++)
                {
                    for (int j = 0; j < kolom; j++)
                    {
                        if (j + i >= n - 1 && j - i <= n - 1)
                        {
                            array[i, j+geser] = fibon[angka].ToString();
                            angka++;
                        }
                            
                    }
                }
                geser += pSegitiga;
            }

            CetakData();
        }
        public void Hasil06a()
        {
            int geser = 0;
            int[] fibon = Deret.fibo(n * n);
            for (int bangun = 1; bangun <= p; bangun++)
            {
                int angka = 0;
                for (int ef = 0; ef < baris; ef++)
                {
                    for (int sd = 0; sd < kolom; sd++)
                    {
                        if (sd + ef >= n - 1 && sd - ef <= n - 1)
                        {
                            array[ef, sd + geser] = fibon[angka].ToString();
                            angka++;
                        }

                    }
                }
                geser += pSegitiga;
            }

            CetakData();
        }
        public void Hasil06b()
        {
            int pindah = 0;
            int[] fibon = Deret.fibo(n * n);
            for (int bangun = 1; bangun <= p; bangun++)
            {
                int angka = 0;
                for (int bn = 0; bn < baris; bn++)
                {
                    for (int vb = 0; vb < kolom; vb++)
                    {
                        if (vb + bn >= n - 1 && vb - bn <= n - 1)
                        {
                            array[bn, vb + pindah] = fibon[angka].ToString();
                            angka++;
                        }

                    }
                }
                pindah += pSegitiga;
            }

            CetakData();
        }
        public void Hasil06c()
        {
            int gsr = 0;
            int[] fibon = Deret.fibo(n * n);
            for (int bangun = 1; bangun <= p; bangun++)
            {
                int angka = 0;
                for (int cf = 0; cf < baris; cf++)
                {
                    for (int lm = 0; lm < kolom; lm++)
                    {
                        if (lm + cf >= n - 1 && lm - cf <= n - 1)
                        {
                            array[cf, lm + gsr] = fibon[angka].ToString();
                            angka++;
                        }

                    }
                }
                gsr += pSegitiga;
            }

            CetakData();
        }
        public void Hasil06d()
        {
            int geser = 0;
            int[] fibon = Deret.fibo(n * n);
            for (int bentuk = 1; bentuk <= p; bentuk++)
            {
                int angka = 0;
                for (int dd = 0; dd < baris; dd++)
                {
                    for (int cv = 0; cv < kolom; cv++)
                    {
                        if (cv + dd >= n - 1 && cv - dd <= n - 1)
                        {
                            array[dd, cv + geser] = fibon[angka].ToString();
                            angka++;
                        }

                    }
                }
                geser += pSegitiga;
            }

            CetakData();
        }
        public void Hasil06e()
        {
            int geser = 0;
            int[] fibon = Deret.fibo(n * n);
            for (int bent = 1; bent <= p; bent++)
            {
                int angka = 0;
                for (int ws = 0; ws < baris; ws++)
                {
                    for (int dd = 0; dd < kolom; dd++)
                    {
                        if (dd + ws >= n - 1 && dd - ws <= n - 1)
                        {
                            array[ws, dd + geser] = fibon[angka].ToString();
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
