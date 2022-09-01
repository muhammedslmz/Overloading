using System;
namespace Program
{
    class Overloading
    {
        static void Main(string[]args)
        {
            // out parametreler
            string sayi ="999";
            bool sonuc= int.TryParse(sayi, out int outSayi);
            if (sonuc)
            {
                Console.WriteLine("Başarılı");
                Console.WriteLine(outSayi);
            }
            else
            {
                Console.WriteLine("Başarısız.");
            }
            Metotlar instance = new Metotlar();
            instance.Topla(4,5, out int  toplamSonucu);
            Console.WriteLine(toplamSonucu);

            //Metoda Aşırı Yükleme - Overloading
            int ifade = 555;
            instance.EkranaYazdir(Convert.ToString( ifade));
            instance.EkranaYazdir(ifade);
            instance.EkranaYazdir(5,8);

        }
    }
    class Metotlar
    {
        public void Topla(int a, int b, out int toplam)
        {
            toplam= a+b;
        }

        public void EkranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        }

        public void EkranaYazdir(int veri)
        {
            Console.WriteLine(veri);
        }

        public void EkranaYazdir(int veri, int veri2)
        {
            int toplam= veri+ veri2;
            Console.WriteLine(toplam);
        }
    }
}