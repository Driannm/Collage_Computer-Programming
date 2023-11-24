using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_While_Loop
/* 
* Created November 24 2023 | 12 : 52
* By Driann
*/
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Perulangan dengan Do - While");
        Console.WriteLine("============================");
        int loop = 1;
        do
        {
            Console.WriteLine("\n Perulangan Yang Ke = " + loop);
            loop++;
        }
        while (loop <= 10);
        Console.Read();
    }
}

/* Pembahasan
 * int loop = 1; : mendefinisikan tipe data integer pada kata loop dengan diberikan nilai 1.
 * 
 * do
 * { Console.WriteLine("\n Perulangan yang Ke=” + loop); : Perintah ini berarti dijalankan terlebih dahulu sebelum kondisi batas exesuki while (loop <= 10); diberikan.
 * 
 * loop++;} : ini merupakan nilai loop yang akan bertambah terus menerus sampai kondisi / syarat pada while terpenuh.
 */