using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uygulamalar0512.Arayuzler;

namespace Uygulamalar0512.Siniflar
{
    internal  class AltiliIslem : IIslem
    {
        public double sayi { get ; set ; }

        public double birileazalt()
        {
            return sayi-=1;
        }

        public double biriletopla()
        {
            return sayi += 1;
        }

        public double bol()
        {
            return sayi /= 2;
        }

        public double carp()
        {
            return sayi *= 2;
        }

        public double ikiileazalt()
        {
            return sayi -= 2;
        }

        public double ikiiletopla()
        {
            return sayi += 2;
        }

        public double modal()
        {
            return sayi = sayi % 2;
        }
    }
}
