using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 
* Created November 24 2023 | 01 : 01
* By Driann
*/
namespace Statement_If_Else
{
    class Program
    {
        static void Main(string[] args)
        {
            String harga;
            Console.Write("Masukan Harga Buku : ");
            harga = Console.ReadLine();
            int hargabuku = Convert.ToInt32(harga);
            if (hargabuku < 25000)
            {
                Console.Write("Jadi beli buku");
            }
            else
            {
                Console.Write("Mahal banget sih, ga jadi beli deh");
            }
            Console.Read();
        }
    }
}
