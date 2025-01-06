using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodlar

{

    //naming convention -- isimlendirme kuralları metodlarda kodun düngün bir şekilde okunabilmesi için bu zorunlu  
    //syntax - yazım şekilleri 
    internal class SepetManager
    {
        public void Ekle (Urun urun)
        {

            Console.WriteLine( "Tebrikler.sepete eklendi : " + urun.Adi );


        }

        public void Ekle2(string urunAdi ,string acikmala,double fiyat) 
        { 
            Console.WriteLine("Tebrikler.sepete eklendi : " + urunAdi);



        }
       

    }
}
