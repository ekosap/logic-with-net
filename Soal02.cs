using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic05
{
    public class Soal02 : BaseLogic
    {
        
        public Soal02(int x, int y)
        {
            n = x;
            p = y;
            pSegitiga = (2 * x) - 1;
            baris = x;
            kolom = pSegitiga * p;
            array = new string[baris, kolom];
        }

        public void Hasil02()
        {
            int geser = 0;
            for (int bangun = 1; bangun <= p; bangun++)
            {
                for (int h = 0; h < baris; h++)
                {
                    for (int k = 0; k < kolom; k++)
                    {
                        if (k + h >= pSegitiga / 2 && k - h <= pSegitiga / 2)
                        {
                            if (bangun % 2 == 1)
                                array[h, k + geser] = "*";
                            else
                                array[n - 1 - h, k + geser] = "*";
                        }
                    }
                }
                geser = geser + pSegitiga;
            }
            CetakData();
        }
        public void Hasil02a()
        {
            int pin = 0;
            for (int wujud = 1; wujud <= p; wujud++)
            {
                for (int hj = 0; hj < baris; hj++)
                {
                    for (int lm = 0; lm < kolom; lm++)
                    {
                        if (lm + hj >= pSegitiga / 2 && lm - hj <= pSegitiga / 2)
                        {
                            if (wujud % 2 == 1)
                                array[hj, lm + pin] = "*";
                            else
                                array[n - 1 - hj, lm + pin] = "*";
                        }
                    }
                }
                pin += pSegitiga;
            }
            CetakData();
        }
        public void Hasil02b()
        {
            int ndah = 0;
            for (int bent = 1; bent <= p; bent++)
            {
                for (int dt = 0; dt < baris; dt++)
                {
                    for (int nm = 0; nm < kolom; nm++)
                    {
                        if (nm + dt >= pSegitiga / 2 && nm - dt <= pSegitiga / 2)
                        {
                            if (bent%2==1)
                            {
                                array[dt, nm+ndah] = "*";
                            }
                            else
                            {
                                array[n - 1 - dt, nm + ndah] = "*";
                            }
                        }
                    }
                }
                ndah += pSegitiga;
            }
            CetakData();
        }
        public void Hasil02c()
        {
            int ger = 0;
            for (int tuk = 1; tuk <= p; tuk++)
            {
                for (int rt = 0; rt < baris; rt++)
                {
                    for (int cv = 0; cv < kolom; cv++)
                    {
                        if (cv + rt >= pSegitiga / 2 && cv - rt <= pSegitiga / 2)
                        {
                            if (tuk % 2 == 1)
                            {
                                array[rt, cv + ger] = "*";
                            }
                            else
                            {
                                array[n - 1 - rt, cv + ger] = "*";
                            }
                        }
                    }
                }
                ger += pSegitiga;
            }
            CetakData();
        }
        public void Hasil02d()
        {
            int pnd = 0;
            for (int bentuk = 1; bentuk <= p; bentuk++)
            {
                for (int vb = 0; vb < baris; vb++)
                {
                    for (int hp = 0; hp < kolom; hp++)
                    {
                        if (hp + vb >= pSegitiga / 2 && hp - vb <= pSegitiga / 2)
                        {
                            if (bentuk % 2 == 1)
                            {
                                array[vb, hp + pnd] = "*";
                            }
                            else
                            {
                                array[n - 1 - vb, hp + pnd] = "*";
                            }
                        }
                    }
                }
                pnd += pSegitiga;
            }
            CetakData();
        }
        public void Hasil02e()
        {
            int op = 0;
            for (int mk = 1; mk <= p; mk++)
            {
                for (int pl = 0; pl < baris; pl++)
                {
                    for (int kj = 0; kj < kolom; kj++)
                    {
                        if (kj + pl >= pSegitiga / 2 && kj - pl <= pSegitiga / 2)
                        {
                            if (mk % 2 == 1)
                            {
                                array[pl, kj + op] = "*";
                            }
                            else
                            {
                                array[n - 1 - pl, kj + op] = "*";
                            }
                        }
                    }
                }
                op += pSegitiga;
            }
            CetakData();
        }
    }
}
