﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uygulamalar0512.Arayuzler;

namespace Uygulamalar0512.Siniflar
{
    internal class Ornekler : IOrnekler
    {
        public double anapara { get ; set ; }
        public double faiz { get ; set ; }
        public int gun { get ; set; }
       
        public double sayi { get ; set ; }
        
        public double faizHesapla()
        {
            return (anapara * (faiz / 100) / 365) * gun;
        }

        public double sayiortalama()
        {
            return (10*sayi)/10;
        }

      
       
    }


}
