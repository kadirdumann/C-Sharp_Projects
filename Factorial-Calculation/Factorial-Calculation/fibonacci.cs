using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    public class fibonacci
    {
        public int[] hesapla(int sayi)
        {
            int[] cevap = new int[sayi];
            cevap[0] = 0;
            cevap[1] = 1;
            for (int i = 2; i < sayi; i++)
            {
                cevap[i] = cevap[i - 1] + cevap[i - 2];
            }
            return cevap;
        }
    }
}
