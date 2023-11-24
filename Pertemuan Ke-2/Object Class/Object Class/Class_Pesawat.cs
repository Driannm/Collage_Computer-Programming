using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Class
{
    internal class Class_Pesawat
    {
        //Attribute / Variable.
        public string nama;
        public string ketinggian;

        //Baris Method.
        public void terbang()
        {
            Console.WriteLine("Pesawat dengan nama {0}, sedang take off", this.nama);
        }
        public void sudahterbang()
        {
            Console.WriteLine("Pesawat berada pada ketinggian {0}", this.ketinggian);
        }
    }
}
