internal class Program
{
    private static void Main(string[] args)
    {

        // int,decimal ,float ,double bool, = değer tip 
        // sayılsal görüntüde olanlar deger tip 
        // array ,class ,interface = referance type     

        int sayi1 = 10;
        int sayi2 = 30;
        sayi1 = sayi2;
        sayi2 = 65;
        //sayi1 = ??? --cevap =30


        int[] sayilar1 = new int[] { 10,20 ,30 };
        int[] sayilar2 = new int[] { 100, 200, 300 };
        sayilar1 = sayilar2;
        sayilar2[0] = 999;
        //sayilar1[0]= ??--cevap =999

    }
    
}