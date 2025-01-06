internal class Program
{
    private static void Main(string[] args)
    {
        //type safety = tip güvenliği 
        //do not repeat your self 
        //Değer tutucu
        //veri tpiler string-int-double 

        string kategoriEtiketi = "Kategoriler" ;
        int ogrenciSayisi = 3200;
        double faizOrani = 1.45;
        bool sistemeGirisYapmİsMİ = true;
        double dolarDun = 7.45;
        double dolarBugun = 7.45;

        if (dolarDun>dolarBugun)
        {
            Console.WriteLine("azalış butonu");
        }
        else if (dolarDun<dolarBugun)
        {
            Console.WriteLine("artış oku");

        }
        else
        {
            Console.WriteLine("eşittir");
        }



        if (sistemeGirisYapmİsMİ== true )
        {
            Console.WriteLine("Ayarlar Butonu");
        }
        else
        {
            Console.WriteLine("Giriş Yap Butonu");
        }



        Console.WriteLine(kategoriEtiketi);
        
    }
}