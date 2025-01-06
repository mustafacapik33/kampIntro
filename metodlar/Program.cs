using metodlar;

internal class Program
{
    private static void Main(string[] args)
    {
        string urunAdi = "Elma";
        double fiyati = 15;
        string aciklama = "amasya elması" ;


        string[] meyveler = new string[] { };

        Urun urun1 = new Urun();
        urun1.Adi = "Elma";
        urun1.Fiyati = 15;
        urun1.Aciklama = "amasya elması";

        Urun urun2 = new Urun();
        urun2.Adi = "Karpuz";
        urun2.Fiyati = 80;
        urun2.Aciklama = "Diyarbakır karpuzu";

        Urun[] urunler = new Urun[] { urun1,urun2};
        
        
        foreach (var urun in urunler )
        {
            Console.WriteLine(urun.Adi);
            Console.WriteLine(urun.Fiyati);
            Console.WriteLine(urun.Aciklama);
            Console.WriteLine("--------------------");


        }

        Console.WriteLine( "----------Metodlar-----------");


        //İnstace - örnek
        //encapsulatıon - kapsülleme 

        SepetManager sepetManager = new SepetManager();
        sepetManager.Ekle(urun1);
        sepetManager.Ekle(urun2);

        sepetManager.Ekle2("armut","yeşil",31);
        sepetManager.Ekle2("karpuz", "yeşil", 31);
        sepetManager.Ekle2("elma", "yeşil", 31);








    }
}