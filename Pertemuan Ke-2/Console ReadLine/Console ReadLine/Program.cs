using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 
* Created November 23 2023 | 05 : 15
* By Driann
*/

namespace Console_ReadLine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Masukan Nama Anda : ");
            String nama = Console.ReadLine();
            Console.WriteLine("Nama Anda Adalah :{0}", nama);
            Console.Read();
        }
    }
/*
 * Pembahasan :
 * Console.Write        : Untuk mencetak karakter
 * Console.WriteLine    : Untuk mencetak karakter disertai pindah baris
 * String nama          : Tipe data string pana variable nama.
 * Console.ReadLine();  : Perintah masukan dari user.
 * {0}                  : Merupakan array
 */
}
