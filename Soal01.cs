using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic05
{
    public class Soal01 : BaseLogic
    {
        public Soal01(int k, int l)
        {
            n = k;
            p = l;
            pSegitiga = (2 * n) - 1;
            baris = n;
            kolom = pSegitiga * p;
            array = new String[baris, kolom];
        }

        public void Hasil01()
        {
            int geser = 0;
            for (int bangun = 1; bangun <= p; bangun++)
            {
                for (int i = 0; i < baris; i++)
                {
                    for (int j = 0; j < kolom; j++)
                    {
                        if (j + i >= pSegitiga / 2 && j - i <= pSegitiga / 2)
                        {
                            array[i, j + geser] = "*";
                        }
                    }
                }
                geser += pSegitiga;
            }

            CetakData();
        }
        public void Hasil01a()
        {
            int geser = 0;
            for (int bentuk = 1; bentuk <= p; bentuk++)
            {
                for (int jk = 0; jk < baris; jk++)
                {
                    for (int lp = 0; lp < kolom; lp++)
                    {
                        if (jk + lp >= pSegitiga / 2 && lp - jk <= pSegitiga / 2)
                        {
                            array[jk, lp + geser] = "*";
                        }
                    }
                }
                geser += pSegitiga;
            }
            CetakData();
        }
        public void Hasil01b()
        {
            int geser = 0;
            for (int bent = 1; bent <= p; bent++)
            {
                for (int sd = 0; sd < baris; sd++)
                {
                    for (int ac = 0; ac < kolom; ac++)
                    {
                        if (ac + sd >= pSegitiga / 2 && ac - sd <= pSegitiga / 2)
                        {
                            array[sd, ac+geser] = "*";
                        }
                    }
                }
                geser += pSegitiga;
            }
            CetakData();
        }
        public void Hasil01c()
        {
            int geser = 0;
            for (int shape = 1; shape <= p; shape++)
            {
                for (int lk = 0; lk < baris; lk++)
                {
                    for (int om = 0; om < kolom; om++)
                    {
                        if(om + lk >= pSegitiga / 2 && om - lk <= pSegitiga / 2)
                        {
                            array[lk, om+geser] = "*";    
                        }
                    }
                }
                geser += pSegitiga;
            }
            CetakData();
        }
        public void Hasil01d()
        {
            int pindah = 0;
            for (int segi3 = 1; segi3 <= p; segi3++)
            {
                for (int gb = 0; gb < baris; gb++)
                {
                    for (int dk = 0; dk < kolom; dk++)
                    {
                        if(dk + gb >= pSegitiga / 2 && dk - gb <= pSegitiga / 2)
                        {
                            array[gb, dk+pindah] = "*";
                        }
                    }
                }
                pindah += pSegitiga;
            }
            CetakData();
        }
        public void Hasil01e()
        {
            int move = 0;
            for (int segi3 = 1; segi3 <= p; segi3++)
            {
                for (int df = 0; df < baris; df++)
                {
                    for (int ko = 0; ko < kolom; ko++)
                    {
                        if (ko + df >= pSegitiga / 2 && ko - df <= pSegitiga / 2)
                        {
                            array[df, ko+move] = "*";
                        }
                    }
                }
                move += pSegitiga;
            }
            CetakData();
        }
    }
}
