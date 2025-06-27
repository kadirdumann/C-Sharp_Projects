using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    public class BestelenenSiir : Siir
    {
        public string besteleyenKisi;
        public int bestelendigiTarih;

        public override void Aciklama()
        {
            Console.WriteLine("Bu açıklama bestelenmiş şiir sınıfına aittir");
        }
    }
}
