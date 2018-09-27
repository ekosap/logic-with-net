using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Masukan Nilai n :");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Masukan Nilai p :");
            int p = int.Parse(Console.ReadLine());

            Soal10 soal = new Soal10(n, p);
            
            soal.Hasil10();
            //soal.Hasil02b();
            //soal.Hasil02c();
            //soal.Hasil02d();
            //soal.Hasil02e();

            Console.ReadLine();
        }
    }
}
