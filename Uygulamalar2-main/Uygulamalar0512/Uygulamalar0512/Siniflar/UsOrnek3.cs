using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulamalar0512.Siniflar
{
    public class UsOrnek3
    {
        public int taban { get; set; }
        public int us { get; set; }

        int sonuc = 1;
        public int usHesapla()
        {
            for (int i = 0; i < us; i++)
            {
                sonuc = sonuc * taban;
            }
            return sonuc;
        }
    }
}
