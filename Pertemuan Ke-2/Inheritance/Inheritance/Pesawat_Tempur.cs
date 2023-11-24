using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Pesawat_Tempur:Pesawat
    {
        public void Terbang() 
        {
            Console.WriteLine("Pesawat Tempur dengan nama : {0}, yang memiliki jumlah roda {1}, sedang berada pada ketinggian {2}, dengan jumlah awak sebanyak {3} awak pesawat. Siap Menembak",
                this.Nama,
                this.JumlahRoda,
                this.Ketinggian,
                this.JumlahPenumpang);
        }
    }
}
