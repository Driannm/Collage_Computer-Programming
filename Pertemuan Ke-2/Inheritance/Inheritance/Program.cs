using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 
* Created November 24 2023 | 01 : 19
* By Driann
*/
namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Pesawat pesawat = new Pesawat();
            Pesawat_Tempur pesawat_Tempur = new Pesawat_Tempur();

            pesawat.Nama = "Private Jet";
            pesawat.JumlahRoda = 3;
            pesawat.Ketinggian = "12.000 Kaki";
            pesawat.JumlahPenumpang = "12";

            pesawat_Tempur.Nama = "Dassault Rafale";
            pesawat_Tempur.JumlahRoda = 3;
            pesawat_Tempur.Ketinggian = "15.000 Kaki";
            pesawat_Tempur.JumlahPenumpang = "2";

            pesawat.Terbang();
            pesawat_Tempur.Terbang();

            Console.Read();
        }
    }
}
