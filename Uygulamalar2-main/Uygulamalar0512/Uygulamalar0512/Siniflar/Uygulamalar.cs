using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulamalar0512.Siniflar
{
    internal class Uygulamalar : Base
    {
        public override int sayi { get ; set ; }
        public override int sayi2 { get ; set ; }
        public override int sayi3 { get ; set ; }

        public override string Hesapla(int islemTipi, params int[] sayilar)
        {
            string sonuc5= "";
            string sonuc8 = "";
           

            switch (islemTipi)
            {
                case 0:
                    int topla;
                    topla = sayi + sayi2;
                    return topla.ToString();
                case 1:
                    int sonuc ;
                    sonuc = ((sayi * (sayi2 / 100) /365) * sayi3);
                    return sonuc.ToString();
                case 2:
                    int sonuc1 =1;
                    for (int i = 0; i <sayi; i++)
                    {
                        sonuc1 = sonuc1 * sayi2;
                    }
                    return sonuc1.ToString();
                case 3:
                    sayi = sayi + 2;
                    sonuc = sayi;
                    return sonuc.ToString();
                case 4:
                    sayi = sayi - 2;
                    sonuc = sayi;
                    return sonuc.ToString();
                case 5:
                    sayi = sayi *2;
                    sonuc = sayi;
                    return sonuc.ToString();
                case 6:
                    sayi = sayi / 2;
                    sonuc = sayi;
                    return sonuc.ToString();
                case 7:
                    sayi = sayi + 1;
                    sonuc = sayi;
                    return sonuc.ToString();
                case 8:
                    sayi = sayi - 1;
                    sonuc = sayi;
                    return sonuc.ToString();
                case 9:
                    sayi = sayi % 2;
                    sonuc = sayi;
                    return sonuc.ToString();
                case 10:
                   
                    int tutulan = 7;
                    
                    if (!(sayi > 0 && sayi <= 10))
                    {
                        return "Girilen sayı 1 ile 10 arasında olmalı ";
                       
                    }
                    else if (sayi > tutulan)
                    {
                        return "Tahmin edilen sayı tutulan sayıdan büyüktür.";
                        
                    }
                
                    else if (sayi < tutulan)
                    {
                        return "Tahmin edilen sayı tutulan sayıdan küçüktür. ";
                        
                    }
                    else
                    {
                        
                        return "Tebrikler doğru tahmin ettiniz :)";
                    }
                   

                case 11:

                    if (sayi < 0)
                    {
                       return "Girilen sayı negatiftir.";
                    }

                    else if (sayi % 2 == 0)
                    {
                        return "Girilen sayı çifttir";
                    }
                    else
                    {
                       return "Girilen sayı tektir.";
                    }


                case 12:
                    int toplam = 0;
                    for (int i = 1; i <= sayi / 2; i++)
                    {

                        if (sayi % i == 0)
                        {
                            toplam = toplam + i;
                        }
                    }
                    if (sayi == toplam)
                    {
                        return "Girilen sayı mükemmel sayıdır ";
                    }
                    else
                    {
                        return "Girilen sayı mükemmel sayı değildir. ";
                    }

                case 13:
                    if (sayi <= 50 && sayi >= 0)
                    {
                        return " Kaldınız: FF";
                    }
                    else if (sayi > 50 && sayi < 55)
                    {
                        return " Geçtiniz: DD";
                    }
                    else if (sayi >= 55 && sayi < 69)
                    {
                        return " Geçtiniz: CC";
                    }
                    else if (sayi >= 69 && sayi < 80)
                    {
                        return " Geçtiniz: BC";
                    }
                    else if (sayi >= 80 && sayi <= 90)
                    {
                        return "Geçtiniz: BB";
                    }
                    else if (sayi >= 90 && sayi <= 100)
                    {
                        return "Geçtiniz: AA";
                    }
                    else
                    {
                        return " Lütfen 1 ile 100 arasında bir sayı yazınız";
                    }
                    
                case 14:
                    
                    int faktoriyel = 1;
                    while (sayi > 0)
                    {
                        faktoriyel = faktoriyel * sayi;
                        sayi--;
                    }
                    return faktoriyel.ToString();

                case 15:

                  
                    
                    for (byte i = 1; i <= sayilar[0]; i++)
                    {
                        sayi3 = sayi + sayi2;
                        sayi = sayi2;
                        sayi2 = sayi3;
                        sonuc8 = sonuc8 + " " + sayi3;
                        return sonuc8;
                        
                    }
                    break;

                

                case 16:
                    if (sayi > sayi2 && sayi > sayi3)
                    {
                        return "Birinci sayı en büyüktür. ";
                    }
                    else if (sayi2 > sayi && sayi2 > sayi3)
                    {
                        return "İkinci sayı en büyüktür.";
                    }
                    else
                    {
                        return "Üçüncü sayı en büyüktür.";
                    }

                case 17:
                    // int sayi2;  kelvin
                    // int sayi3;  fahrenheit
                    sayi2 = sayi + 273;
                    sayi3 = sayi * 18 / 10 + 32;

                    return sayi2.ToString();
                    return sayi3.ToString();

                case 18:
                    
                case 19:
                    
                    while (sayi > 0)
                    {
                        sonuc5 = sayi % 2 + sonuc5;
                        sayi = sayi / 2;
                    }
                    return sonuc5.ToString();

                    case 20:    


                default:
                    break;
            }
            return "";
        }
    }
}
