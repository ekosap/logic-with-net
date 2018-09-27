using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic05
{
    public class Soal07 : BaseLogic
    {
        public Soal07(int a, int b)
        {
            n = a;
            p = b;
            pSegitiga = (2 * n) - 1;
            baris = n;
            kolom = pSegitiga * p;
            array = new String[baris, kolom];
        }

        public void Hasil07()
        {
            int[] der1 = Deret.deret1(n * n);
            int geser = 0;
            for (int bangun = 1; bangun <= p; bangun++)
            {
                int angka = 0;
                for (int i = 0; i < n; i++)
                {
                    
                    for (int j = 0; j < pSegitiga; j++)
                    {
                        if (j + i >= pSegitiga / 2 && j - i <= pSegitiga / 2)
                        {
                            if (bangun % 2 == 1)
                            {
                                array[i, j + geser] = der1[angka].ToString();
                                angka++;
                            }
                            else
                            {
                                array[n-1-i, j + geser] = der1[angka].ToString();
                                angka++;
                            }
                            
                        }
                        
                    }
                    
                }
                geser += pSegitiga;
            }
            CetakData();
        }
        public void Hasil07a()
        {
            int[] der1 = Deret.deret1(n * n);
            int geser = 0;
            for (int bangun = 1; bangun <= p; bangun++)
            {
                int angka = 0;
                for (int qq = 0; qq < n; qq++)
                {

                    for (int cd = 0; cd < pSegitiga; cd++)
                    {
                        if (cd + qq >= pSegitiga / 2 && cd - qq <= pSegitiga / 2)
                        {
                            if (bangun % 2 == 1)
                            {
                                array[qq, cd + geser] = der1[angka].ToString();
                                angka++;
                            }
                            else
                            {
                                array[n - 1 - qq, cd + geser] = der1[angka].ToString();
                                angka++;
                            }

                        }

                    }

                }
                geser += pSegitiga;
            }
            CetakData();
        }
        public void Hasil07b()
        {
            int[] deret1 = Deret.deret1(n * n);
            int pindah = 0;
            for (int bangun = 1; bangun <= p; bangun++)
            {
                int angka = 0;
                for (int dc = 0; dc < n; dc++)
                {

                    for (int sw = 0; sw < pSegitiga; sw++)
                    {
                        if (sw + dc >= pSegitiga / 2 && sw - dc <= pSegitiga / 2)
                        {
                            if (bangun % 2 == 1)
                            {
                                array[dc, sw + pindah] = deret1[angka].ToString();
                                angka++;
                            }
                            else
                            {
                                array[n - 1 - dc, sw + pindah] = deret1[angka].ToString();
                                angka++;
                            }

                        }

                    }

                }
                pindah += pSegitiga;
            }
            CetakData();
        }
        public void Hasil07c()
        {
            int[] deret = Deret.deret1(n * n);
            int pind = 0;
            for (int bangun = 1; bangun <= p; bangun++)
            {
                int angka = 0;
                for (int qw = 0; qw < n; qw++)
                {

                    for (int mm = 0; mm < pSegitiga; mm++)
                    {
                        if (mm + qw >= pSegitiga / 2 && mm - qw <= pSegitiga / 2)
                        {
                            if (bangun % 2 == 1)
                            {
                                array[qw, mm + pind] = deret[angka].ToString();
                                angka++;
                            }
                            else
                            {
                                array[n - 1 - qw, mm + pind] = deret[angka].ToString();
                                angka++;
                            }

                        }

                    }

                }
                pind += pSegitiga;
            }
            CetakData();
        }
        public void Hasil07d()
        {
            int[] deret = Deret.deret1(n * n);
            int pindah = 0;
            for (int bangun = 1; bangun <= p; bangun++)
            {
                int angka = 0;
                for (int cc = 0; cc < n; cc++)
                {

                    for (int ed = 0; ed < pSegitiga; ed++)
                    {
                        if (ed + cc >= pSegitiga / 2 && ed - cc <= pSegitiga / 2)
                        {
                            if (bangun % 2 == 1)
                            {
                                array[cc, ed + pindah] = deret[angka].ToString();
                                angka++;
                            }
                            else
                            {
                                array[n - 1 - cc, ed + pindah] = deret[angka].ToString();
                                angka++;
                            }

                        }

                    }

                }
                pindah += pSegitiga;
            }
            CetakData();
        }
        public void Hasil07e()
        {
            int[] der = Deret.deret1(n * n);
            int pin = 0;
            for (int bangun = 1; bangun <= p; bangun++)
            {
                int angka = 0;
                for (int sd = 0; sd < n; sd++)
                {

                    for (int vn = 0; vn < pSegitiga; vn++)
                    {
                        if (vn + sd >= pSegitiga / 2 && vn - sd <= pSegitiga / 2)
                        {
                            if (bangun % 2 == 1)
                            {
                                array[sd, vn + pin] = der[angka].ToString();
                                angka++;
                            }
                            else
                            {
                                array[n - 1 - sd, vn + pin] = der[angka].ToString();
                                angka++;
                            }

                        }

                    }

                }
                pin += pSegitiga;
            }
            CetakData();
        }

    }
}
