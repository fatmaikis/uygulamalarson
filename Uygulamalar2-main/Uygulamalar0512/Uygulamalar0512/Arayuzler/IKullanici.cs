using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulamalar0512.Arayuzler
{
    internal interface IKullanici
    {
        string kullaniciadi { get; set; }
        string sifre { get; set; }
        string kayitadi { get; set; }
        string kayitsifre { get; set; }

        string GirisYap(string kullaniciadi, string sifre, string kayitadi, string kayitsifre);
    }
}
