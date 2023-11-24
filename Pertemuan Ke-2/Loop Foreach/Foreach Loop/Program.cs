using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 
* Created November 24 2023 | 12 : 58
* By Driann
*/
namespace Foreach_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] nama = { "Yuda Andrian", "Alex Hamongan Hasibuan", "Hari Bagus Maulana", "Driann Jaegar" };
            Console.WriteLine("Perulangan Dengan FOREACH");
            Console.WriteLine("=========================");
            foreach (String urutan in nama)
            {
                Console.WriteLine("" + urutan);
            }
            Console.Read();
        }
    }
}


