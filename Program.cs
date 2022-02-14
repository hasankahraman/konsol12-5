using System;

namespace konsol12_5
{
    class Program
    {
        static void Main(string[] args)
        {
   
            // erişim_belirteci geri_dönüş_tipi metot_adı(parametreler) {
            //komutlar
            //return
            // }

            int a = 2;
            int b = 3;

            Console.WriteLine(a+b);
            Console.ReadLine();

            int Topla (int a, int b){
            return a+b;
            }

            Console.WriteLine(Topla(a,b));
            Console.ReadLine();

            Metotlar metot = new Metotlar();
            metot.EkranaYaz(Convert.ToString(Topla(a,b)));

            int sonuc = metot.ArttirVeTopla(ref a, ref b);

            Console.WriteLine(sonuc);
            Console.ReadLine();

            Console.WriteLine(Topla(a,b));
            Console.ReadLine();

        }
    }


    class Metotlar {

        public void EkranaYaz(string veri){
            Console.WriteLine(veri);
            Console.ReadLine();
        }

        public int ArttirVeTopla(ref int s1, ref int s2){

            s1 ++;
            s2 ++;

            return s1+s2;
        }
    }
}
