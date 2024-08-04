using System;
namespace PratikMetotUygulamasi
{
    class Program
    {
        static void Main()
        {
            SarkiSozu();        
            Console.WriteLine($"Bölümün sonucu = {GeriyeSayi()}");
            Random rnd = new Random();
            double a = rnd.Next(1,11);
            double b = rnd.Next(1,11);
            Console.WriteLine($"\nÇarpımın sonucu = {CarpimSonucu(a, b)}");

            string name = "Nihat Nadir";
            string surname = "BÖRLÜ";
            EkranaYazdir(name, surname);

        }
        static void SarkiSozu()
        {
            // Ekrana sevdiğiniz bir şarkı sözünü yazdırsın. 
            Console.WriteLine("Aşkın ateşi yakarmış ateşi");
        }

        
        static double GeriyeSayi()
        {
            // Rastgele bir sayı üretip bu sayının 2'ye bölümünden kalanı geriye döndürsün.
            Random rnd = new Random();
            int rastgele = rnd.Next(10,21);
            Console.WriteLine($"\nRastgele üretilen sayı = {rastgele} ");
            return (double)rastgele / 2;
        }

        static double CarpimSonucu(double a,double b)
        {
            // Parametre olarak aldığı iki sayının çarpımını geriye dönsün.
            return a * b;
        }

        static void EkranaYazdir(string a,string b)
        {
            // Parametre olarak isim ve soyisim bilgilerini alıp " Hoş Geldiniz {isim} {soyisim} " şeklinde ekrana bassın.
            Console.WriteLine($"\nHoşgeldiniz {a} {b}");
        }
    }
}