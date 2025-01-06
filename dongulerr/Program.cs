internal class Program
{
    private static void Main(string[] args)
    {
        //array -diziler
        string[] Kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kamp", "Programlamaya Başlangıç", "java","pyhton","c++" };

        for (int i = 0 ; i < Kurslar.Length; i++)  
        {
            Console.WriteLine(Kurslar[i]);

        }

        Console.WriteLine("for bitti ");  

        foreach (string kurs in Kurslar)
        {
            Console.WriteLine(kurs);    
            
        }

        Console.WriteLine("sayfa sonu-footer");  
    }
}