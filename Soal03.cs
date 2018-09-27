using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic05
{
    public class Soal03:BaseLogic
    {
        public Soal03(int x, int y)
        {
            n = x;
            p = y;
            baris = n;
            pSegitiga = n;
            kolom = p * pSegitiga;
            array = new string[baris, kolom];
        }
        
        public void Hasil03()
        {
            int geser = 0;
            for (int segit = 1; segit <= p; segit++)
            {
                for (int i = 0; i < baris; i++)
                {
                    for (int d = 0; d < kolom; d++)
                    {
                        if(d==(0+geser) || i==n-1 || d == i+geser)
                        {
                            array[i, d] = "*";
                        }
                    }
                }
                geser = geser + pSegitiga;
            }
            CetakData();
        }
        public void Hasil03a()
        {
            int pas = 0;
            for (int s3 = 1; s3 <= p; s3++)
            {
                for (int dw = 0; dw < baris; dw++)
                {
                    for (int sc = 0; sc < kolom; sc++)
                    {
                        if (sc == (0 + pas) || dw == n - 1 || sc == dw + pas)
                        {
                            array[dw, sc] = "*";
                        }
                    }
                }
                pas = pas + pSegitiga;
            }
            CetakData();
        }
        public void Hasil03b()
        {
            int lw = 0;
            for (int segi3 = 1; segi3 <= p; segi3++)
            {
                for (int vf = 0; vf < baris; vf++)
                {
                    for (int bv = 0; bv < kolom; bv++)
                    {
                        if (bv == (0 + lw) || vf == n - 1 || bv == vf + lw)
                        {
                            array[vf, bv] = "*";
                        }
                    }
                }
                lw = lw + pSegitiga;
            }
            CetakData();
        }
        public void Hasil03c()
        {
            int dc = 0;
            for (int s3v = 1; s3v <= p; s3v++)
            {
                for (int wd = 0; wd < baris; wd++)
                {
                    for (int dd = 0; dd < kolom; dd++)
                    {
                        if (dd == (0 + dc) || wd == n - 1 || dd == wd + dc)
                        {
                            array[wd, dd] = "*";
                        }
                    }
                }
                dc = dc + pSegitiga;
            }
            CetakData();
        }
        public void Hasil03d()
        {
            int pindah = 0;
            for (int bentuk = 1; bentuk <= p; bentuk++)
            {
                for (int bar = 0; bar < baris; bar++)
                {
                    for (int kol = 0; kol < kolom; kol++)
                    {
                        if (kol == (0 + pindah) || bar == n - 1 || kol == bar + pindah)
                        {
                            array[bar, kol] = "*";
                        }
                    }
                }
                pindah = pindah + pSegitiga;
            }
            CetakData();
        }
        public void Hasil03e()
        {
            int pind = 0;
            for (int segi3 = 1; segi3 <= p; segi3++)
            {
                for (int ris = 0; ris < baris; ris++)
                {
                    for (int lom = 0; lom < kolom; lom++)
                    {
                        if (lom == (0 + pind) || ris == n - 1 || lom == ris + pind)
                        {
                            array[ris, lom] = "*";
                        }
                    }
                }
                pind = pind + pSegitiga;
            }
            CetakData();
        }
    }
}
