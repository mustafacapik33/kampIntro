internal class Program
{
    private static void Main(string[] args)
    {
        string adi = "engin ";
        int yas = 18;

        Kurs kurs1 = new Kurs();
        kurs1.kursAdi = "C#";
        kurs1.kursunEgitmeni = "engin demiroğ";
        kurs1.izlenmeOrani = 68;

        Kurs kurs4 = new Kurs();
        kurs4.kursAdi = "HERBOKOLOG";
        kurs4.kursunEgitmeni = "MUSTAFA ARSLAN ";
        kurs4.izlenmeOrani = 500;

        Kurs kurs2 = new Kurs();
        kurs2.kursAdi = "Java";
        kurs2.kursunEgitmeni = "celil unver";
        kurs2.izlenmeOrani = kurs4.izlenmeOrani + 5;

        Kurs kurs3 = new Kurs();
        kurs3.kursAdi = "phyton";
        kurs3.kursunEgitmeni = "halil unver ";
        kurs3.izlenmeOrani = 200;


        Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3,kurs4 };

        foreach (Kurs kurs  in  kurslar)
        {
            Console.WriteLine(kurs.kursAdi + ":" + kurs.kursunEgitmeni + "=" + kurs.izlenmeOrani);
        }

        //Console.WriteLine( kurs1.kursAdi+ "" + kurs1.kursunEgitmeni);

        //Console.WriteLine("Hello, World!");
    }

    class Kurs 
    {
        public string kursAdi { get; set; }
        
        public string kursunEgitmeni { get; set; }
        
        public int izlenmeOrani { get; set; }
    }
}