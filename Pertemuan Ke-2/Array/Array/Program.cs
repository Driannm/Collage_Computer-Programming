using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 
* Created November 24 2023 | 01 : 09
* By Driann
*/
namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dibawah ini adalah Contoh Array 1 Dimensi
            int[] array = new int[] { 1, 2, 3 }; //Contoh Array
            Console.WriteLine("\t\t Belajar Array"); //Ini akan dicetak
            Console.WriteLine("\n\n======== Array 1 Dimensi Menggunakan C# =========");
            for (int i = 0; i < array.Length; i++) // Membuat Perulangan
            {
                Console.WriteLine("Array Satu Dimensi" + (i + 1) + ":" + array[i]);
            }
            //Dibawah ini adalah Contoh Array 2 Dimensi
            Console.WriteLine("\n\n====== Array 2 Dimensi Menggunakan C# ======");
            int baris_array = 2;
            int klm_array = 2;
            int[,] matrik_array = new int[baris_array, klm_array];
            int x = 1;
            for (int s = 0; s < baris_array; s++)
            {
                for (int j = 0; j < klm_array; j++)
                {
                    matrik_array[s, j] = x;
                    x++;
                }
            }
            for (int s = 0; s < baris_array; s++)
            {
                for (int j = 0; j < klm_array; j++)
                {
                    Console.Write("Array 2 Dimensi" + matrik_array[s, j] + "\t"); //Array yang akan diceatak

                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
