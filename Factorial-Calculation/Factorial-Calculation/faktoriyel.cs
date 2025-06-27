using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    public class faktoriyel
    {
        public int Hesapla(int sayi)
        {
            if (sayi == 0)
                return 1;
            else
                return sayi * Hesapla(sayi - 1);
        }
    }
}
