using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 
* Created November 24 2023 | 12 : 41
* By Driann
*/
namespace While_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==========Belajar Perulangan Dengan While==========");
            int loop = 1;
            while (loop <= 4)
            {
                Console.WriteLine("\n Ulang lagi sampai lulus" + loop);
                loop++;
            }
            Console.Read();

        }
    }
}
/* Pembahasan
 * 
 * int loop = 1;                        : mendefinisikan tipe data integer pada kata loop dengan diberikan nilai 1.
 * 
 * while (loop <= 4)
 * { Console.WriteLine("\n ulang lagi   : ilustrasinya sintak diatas menjelaskan seandainya nilai pada loop kurang dari / sama dengan 4, 
 * maka akan mencetak tulisan "Ulang lagi sampai lulus" sebanyak 4 kali.
 * 
 * loop++;                              : loop++ ini merupakan nilai loop yang akan bertambah terus menerus sampai kondisi / syarat pada while terpenuhi
*/