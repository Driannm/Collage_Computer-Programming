using Object_Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 
* Created November 24 2023 | 01 : 16
* By Driann
*/
namespace Object_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Class_Pesawat pesawat = new Class_Pesawat(); //Instansi objek (objek yang akan dibuat harus di INSTANTIASI terlebih dahulu
            pesawat.nama = "DUNIAKU"; //Mengakses Attribute Class
            pesawat.ketinggian = "10000 KAKI";
            pesawat.terbang(); //Mengakses method pada kelas
            pesawat.sudahterbang();
            Console.Read();
        }
    }
}
