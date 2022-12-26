using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulamalar0512.Arayuzler
{
    internal interface IOrnekler
    {
        double anapara { get; set; }
        double faiz { get; set; }
        int gun { get; set; }

        double sayi { get; set; }
        double sayiortalama();
        double faizHesapla();
       

    }
}
