using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulamalar0512.Arayuzler
{
    internal interface IIslem
    {
        double sayi { get; set; }
        double ikiiletopla();
        double ikiileazalt();
        double carp();
        double bol();
        double biriletopla();
        double birileazalt();
        double modal();
    }
}
