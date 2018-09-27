using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic05
{
    public class BaseLogic
    {
        public int n { get; set; }
        public int p { get; set; }
        public int baris { get; set; }
        public int kolom { get; set; }
        public int pSegitiga { get; set; }
        public String[,] array { get; set; }

        public void CetakData()
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i,j]+"\t");
                }
                Console.WriteLine("\n");
            }
        }


    }
}
