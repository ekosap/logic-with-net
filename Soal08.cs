using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic05
{
    public class Soal08:BaseLogic
    {
        public Soal08(int d, int r)
        {
            n = d;
            p = r;
            pSegitiga = n;
            baris = n;
            kolom = p * pSegitiga;
            array = new string[baris, kolom];
        }

        public void Hasil08()
        {
            int[] deret2 = Deret.deret1(n * n);
            int geser = 0;
            for (int bangun = 1; bangun <= p; bangun++)
            {
                int angka = 0;
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if(i==j || j==0 || i == n - 1)
                        {
                            array[i, j+geser] = deret2[angka].ToString();
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
