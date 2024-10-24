using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W4_Polymorphism
{
    public class BaseGeometrikSekil  //base sinif olarak tanimladik
    {
        public int Yukseklik {  get; set; } //3 geometrik seklin de yukseklik ve genisligi var bu degerler hepsi icin gecerli
        public int Genislik { get; set; }

        public virtual int AlanHesapla() //alan hesaplama icin ortak formul virtual olarak kaydettik cunku override yapacagiz dikucgen icin
        {
            return Yukseklik*Genislik;
        }
    }
    public class Dikdortgen : BaseGeometrikSekil // icine ekstra bir sey tanimlamamiza gerek yok base sinifin ayni ozelliklerine sahip
    {
    }
    public class Kare : BaseGeometrikSekil //dikdortgen ile ayni ozelliklerde
    {
    }
    public class DikUcgen : BaseGeometrikSekil //ucgen alani farkli hesplaniyor 
    {
        public override int AlanHesapla() //virtual olan metodu override yapip ekleme yapiyoruz sonucu 2ye boluyoruz 
        {
            return base.AlanHesapla()/2;
        }
    }
}
