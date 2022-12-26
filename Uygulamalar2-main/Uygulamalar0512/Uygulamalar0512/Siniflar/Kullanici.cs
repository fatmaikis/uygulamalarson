using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uygulamalar0512.Arayuzler;
using System.Windows.Forms;


namespace Uygulamalar0512.Siniflar
{
    internal class Kullanici : IKullanici
    {
        private object kaydetlbl;

        public string kullaniciadi { get ; set ; }
        public string sifre { get; set ; }
        public string kayitadi { get ; set ; }
        public string kayitsifre { get ; set ; }

        
        public string GirisYap(string kullaniciadi, string sifre, string kayitadi, string kayitsifre)
        {
            if (kullaniciadi == "Fatma" && sifre == "123")
            {

                 return  "Kullanıcı girişi doğru. ".ToString();


            }
            else if (kullaniciadi == kayitadi && sifre == kayitsifre)
            {
                return "Kullanıcı girişi dogru .".ToString();

            }

            else
            {
                return "Böyle bir kullanıcı yok. Kayıt olunuz.".ToString();
            }
        }
    }
}
