using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 
* Created November 23 2023 | 05 : 22
* By Driann
*/

namespace For_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Seluruh Point Yang Anda Kumpulkan");
            for (int Point = 1; Point <= 10; Point++)
            {
                Console.WriteLine("Point Ke :" + Point.ToString());
            }
            Console.Read();
        }
    }
}

/*
 * Pembahasan :
 * Console.WriteLine        = digunakan untuk mencetak karakter disertai dengan pindah baris.
 * for (int Point = 1; Point <= 10; Point++) = merupakan sintak penulisan perulangan 
 * for,dimana nilai awal point diberikan 1 dengan tipe data integer, kemudian diberikan kondisi jika kurang dari atau sama dengan sepuluh, maka point bertambah 1 (++).
 * { Console.WriteLine ("Point Ke :"+Point.ToString()); = Statement yang akan diulang.}
 * + Point.ToString()       = digunakan untuk merubah tipe data int pada point kedalam string.
 */
