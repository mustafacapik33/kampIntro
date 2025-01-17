internal class Program
{
    private static void Main(string[] args)
    {
        string adi = "engin ";
        int yas = 18;

        Kurs kurs1 = new Kurs();
        kurs1.KursAdi = "C#";
        kurs1.KursunEgitmeni = "engin demiroğ";
        kurs1.IzlenmeOrani = 68;

        Kurs kurs4 = new Kurs();
        kurs4.KursAdi = "HERBOKOLOG";
        kurs4.KursunEgitmeni = "MUSTAFA ARSLAN ";
        kurs4.IzlenmeOrani = 500;

        Kurs kurs2 = new Kurs();
        kurs2.KursAdi = "Java";
        kurs2.KursunEgitmeni = "celil unver";
        kurs2.IzlenmeOrani = kurs4.IzlenmeOrani + 5;

        Kurs kurs3 = new ()
        {
            KursAdi = "phyton",
            KursunEgitmeni = "halil unver ",
            IzlenmeOrani = 200,
            KursTarihi = DateTime.Now
        };


        Kurs[] kurslar = [kurs1, kurs2, kurs3,kurs4];

        foreach (Kurs kurs  in  kurslar)
        {
            Console.WriteLine(kurs.KursAdi + ":" + kurs.KursunEgitmeni + "=" + kurs.IzlenmeOrani);
        }

        //Console.WriteLine( kurs1.kursAdi+ "" + kurs1.kursunEgitmeni);

        //Console.WriteLine("Hello, World!");
    }

    class Kurs 
    {
        public string KursAdi { get; set; }
        
        public string KursunEgitmeni { get; set; }
        
        public int IzlenmeOrani { get; set; }
        public DateTime KursTarihi { get; set; }
    }
}