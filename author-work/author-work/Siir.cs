using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    public class Siir
    {
        public string yazar;
        public string siirAdi;
        public int satirSayisi;

        public virtual void Aciklama()
        {
            Console.WriteLine("Bu açıklama şiir sınıfına aittir");
        }
    }

}
