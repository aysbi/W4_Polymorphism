
using W4_Polymorphism;

BaseGeometrikSekil Ucgen = new DikUcgen(); 
Ucgen.Genislik = 4;
Ucgen.Yukseklik = 3;

Console.WriteLine("Ucgenin Alani: " + Ucgen.AlanHesapla()); //ucgen alanini yazdiriyoruz

Dikdortgen dikdortgen = new Dikdortgen();
dikdortgen.Genislik = 5;
dikdortgen.Yukseklik = 6;

Console.WriteLine("Dikdortgenin alani: " + dikdortgen.AlanHesapla()); //dikdortgen alanini yazdiriyoruz

Kare kare = new Kare();
kare.Genislik = 7;
kare.Yukseklik = 7;

Console.WriteLine("Karenin alani: " + kare.AlanHesapla()); //karenin alanini yazdiriyoruz

Console.ReadKey();