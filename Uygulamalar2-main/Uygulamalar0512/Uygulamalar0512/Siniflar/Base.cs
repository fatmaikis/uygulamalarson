using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uygulamalar0512.Arayuzler;

namespace Uygulamalar0512.Siniflar
{
    internal abstract class Base 
    {
        public abstract int sayi { get; set; }
        public abstract int sayi2 { get; set; } 
        public abstract int sayi3 { get; set; }

        
        public virtual string Hesapla(int islemTipi, params int[] sayilar )
        {
            return "";
        }
    }
}
