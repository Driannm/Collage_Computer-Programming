using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Pesawat
    {
        public string Nama;
        public int JumlahRoda;
        private string ketinggian;
        private string jumlahpenumpang;

        public string Ketinggian
        {
            get { return ketinggian; }
            set { ketinggian = value; }
        }
        public string JumlahPenumpang
        {
            get { return jumlahpenumpang; }
            set {  jumlahpenumpang = value; }
        }

        public void Terbang()
        {
            Console.WriteLine("Pesawat dengan Nama {0}, memiliki jumlah roda {1}, sedang berada pada ketinggian {2}, dengan membawa sebanyak {3} penumpang",
                this.Nama,
                this.JumlahRoda,
                this.ketinggian,
                this.jumlahpenumpang);
        }
    }
}
