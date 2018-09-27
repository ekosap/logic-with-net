using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic05
{
    class Soal04:BaseLogic
    {
        public Soal04(int x, int y)
        {
            n = x;
            p = y;
            pSegitiga = n;
            baris = n;
            kolom = p * pSegitiga;
            array = new string[baris, kolom];
        }

        public void Hasil04()
        {
            int geser = 0;
            for (int bangun = 1; bangun <= p; bangun++)
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (j == i  || i == n - 1 || j == 0 )
                        {
                            if (bangun % 4 == 1)
                                array[i, j] = "*";
                            else if (bangun % 4 == 2)
                                array[n-1-i, j+geser] = "*";
                            else if (bangun % 4 == 3)
                                array[n-1-i, (n-1-j)+geser] = "*";
                            else
                                array[i, (n-1-j)+geser] = "*";
                        }
                    }
                }
                geser = geser + pSegitiga;
            }
            CetakData();
        }
        public void Hasil04a()
        {
            int ser = 0;
            for (int bang = 1; bang <= p; bang++)
            {
                for (int fc = 0; fc < n; fc++)
                {
                    for (int ee = 0; ee < n; ee++)
                    {
                        if (ee == fc || fc == n - 1 || ee == 0)
                        {
                            if (bang % 4 == 1)
                                array[fc, ee] = "*";
                            else if (bang % 4 == 2)
                                array[n - 1 - fc, ee + ser] = "*";
                            else if (bang % 4 == 3)
                                array[n - 1 - fc, (n - 1 - ee) + ser] = "*";
                            else
                                array[fc, (n - 1 - ee) + ser] = "*";
                        }
                    }
                }
                ser = ser + pSegitiga;
            }
            CetakData();
        }
        public void Hasil04b()
        {
            int pin = 0;
            for (int bangun = 1; bangun <= p; bangun++)
            {
                for (int b = 0; b < n; b++)
                {
                    for (int d = 0; d < n; d++)
                    {
                        if (d == b || b == n - 1 || d == 0)
                        {
                            if (bangun % 4 == 1)
                                array[b, d] = "*";
                            else if (bangun % 4 == 2)
                                array[n - 1 - b, d + pin] = "*";
                            else if (bangun % 4 == 3)
                                array[n - 1 - b, (n - 1 - d) + pin] = "*";
                            else
                                array[b, (n - 1 - d) + pin] = "*";
                        }
                    }
                }
                pin = pin + pSegitiga;
            }
            CetakData();
        }
        public void Hasil04c()
        {
            int pindah = 0;
            for (int bentuk = 1; bentuk <= p; bentuk++)
            {
                for (int gb = 0; gb < n; gb++)
                {
                    for (int nm = 0; nm < n; nm++)
                    {
                        if (nm == gb || gb == n - 1 || nm == 0)
                        {
                            if (bentuk % 4 == 1)
                                array[gb, nm] = "*";
                            else if (bentuk % 4 == 2)
                                array[n - 1 - gb, nm + pindah] = "*";
                            else if (bentuk % 4 == 3)
                                array[n - 1 - gb, (n - 1 - nm) + pindah] = "*";
                            else
                                array[gb, (n - 1 - nm) + pindah] = "*";
                        }
                    }
                }
                pindah = pindah + pSegitiga;
            }
            CetakData();
        }
        public void Hasil04d()
        {
            int geser = 0;
            for (int ben = 1; ben <= p; ben++)
            {
                for (int vd = 0; vd < n; vd++)
                {
                    for (int se = 0; se < n; se++)
                    {
                        if (se == vd || vd == n - 1 || se == 0)
                        {
                            if (ben % 4 == 1)
                                array[vd, se] = "*";
                            else if (ben % 4 == 2)
                                array[n - 1 - vd, se + geser] = "*";
                            else if (ben % 4 == 3)
                                array[n - 1 - vd, (n - 1 - se) + geser] = "*";
                            else
                                array[vd, (n - 1 - se) + geser] = "*";
                        }
                    }
                }
                geser = geser + pSegitiga;
            }
            CetakData();
        }
        public void Hasil04e()
        {
            int geser = 0;
            for (int bangun = 1; bangun <= p; bangun++)
            {
                for (int ed = 0; ed < n; ed++)
                {
                    for (int fg = 0; fg < n; fg++)
                    {
                        if (fg == ed || ed == n - 1 || fg == 0)
                        {
                            if (bangun % 4 == 1)
                                array[ed, fg] = "*";
                            else if (bangun % 4 == 2)
                                array[n - 1 - ed, fg + geser] = "*";
                            else if (bangun % 4 == 3)
                                array[n - 1 - ed, (n - 1 - fg) + geser] = "*";
                            else
                                array[ed, (n - 1 - fg) + geser] = "*";
                        }
                    }
                }
                geser = geser + pSegitiga;
            }
            CetakData();
        }
    }
}
