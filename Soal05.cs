using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic05
{
    public class Soal05:BaseLogic
    {
        public Soal05(int x, int y)
        {
            n = x;
            p = y;
            pSegitiga = n+1;
            baris = n;
            kolom = pSegitiga*p;
            array = new string[baris, kolom];
        }

        public void Hasil05()
        {
            int geser = 0;
            for (int bangun = 1; bangun <= p; bangun++)
            {
                for (int i = 0; i < n; i++)
                {
                    for (int s = 0; s < n; s++)
                    {
                        if (i == 0 || i == n - 1 || s == 0 || s == n - 1)
                        {
                            array[i, s+geser] = "*";
                        }
                    }
                }
                geser = geser + pSegitiga;
            }
            CetakData();
        }
        public void Hasil05a()
        {
            int geser = 0;
            for (int bangun = 1; bangun <= p; bangun++)
            {
                for (int xd = 0; xd < n; xd++)
                {
                    for (int cx = 0; cx < n; cx++)
                    {
                        if (xd == 0 || xd == n - 1 || cx == 0 || cx == n - 1)
                        {
                            array[xd, cx + geser] = "*";
                        }
                    }
                }
                geser = geser + pSegitiga;
            }
            CetakData();
        }
        public void Hasil05b()
        {
            int geser = 0;
            for (int bangun = 1; bangun <= p; bangun++)
            {
                for (int ww = 0; ww < n; ww++)
                {
                    for (int qq = 0; qq < n; qq++)
                    {
                        if (ww == 0 || ww == n - 1 || qq == 0 || qq == n - 1)
                        {
                            array[ww, qq + geser] = "*";
                        }
                    }
                }
                geser = geser + pSegitiga;
            }
            CetakData();
        }
        public void Hasil05c()
        {
            int geser = 0;
            for (int bangun = 1; bangun <= p; bangun++)
            {
                for (int aq = 0; aq < n; aq++)
                {
                    for (int wa = 0; wa < n; wa++)
                    {
                        if (aq == 0 || aq == n - 1 || wa == 0 || wa == n - 1)
                        {
                            array[aq, wa + geser] = "*";
                        }
                    }
                }
                geser = geser + pSegitiga;
            }
            CetakData();
        }
        public void Hasil05d()
        {
            int geser = 0;
            for (int bangun = 1; bangun <= p; bangun++)
            {
                for (int wwq = 0; wwq < n; wwq++)
                {
                    for (int ft = 0; ft < n; ft++)
                    {
                        if (wwq == 0 || wwq == n - 1 || ft == 0 || ft == n - 1)
                        {
                            array[wwq, ft + geser] = "*";
                        }
                    }
                }
                geser = geser + pSegitiga;
            }
            CetakData();
        }
        public void Hasil05e()
        {
            int geser = 0;
            for (int bangun = 1; bangun <= p; bangun++)
            {
                for (int ed = 0; ed < n; ed++)
                {
                    for (int bl = 0; bl < n; bl++)
                    {
                        if (ed == 0 || ed == n - 1 || bl == 0 || bl == n - 1)
                        {
                            array[ed, bl + geser] = "*";
                        }
                    }
                }
                geser = geser + pSegitiga;
            }
            CetakData();
        }
    }
}
