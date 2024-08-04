using System;
namespace PratikMetotUygulamasi
{
    class Program
    {
        static void Main() // Ana metot oluşturup diğer metotları buradan çağırdım.
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
        static void SarkiSozu() // Geriye Değer Döndürmeyen Bir void metot.
        {
            // Ekrana sevdiğiniz bir şarkı sözünü yazdırsın. 
            Console.WriteLine("Aşkın ateşi yakarmış ateşi");
        }

        
        static double GeriyeSayi() // Geriye Tamsayı Döndüren Bir metot
        {
            // Rastgele bir sayı üretip bu sayının 2'ye bölümünden kalanı geriye döndürsün.
            Random rnd = new Random();
            int rastgele = rnd.Next(10,21);
            Console.WriteLine($"\nRastgele üretilen sayı = {rastgele} ");
            return (double)rastgele / 2;
        }

        static double CarpimSonucu(double a,double b) // Parametre Alan ve Geriye Değer Döndüren Bir Metot
        {
            // Parametre olarak aldığı iki sayının çarpımını geriye dönsün.
            return a * b;
        }

        static void EkranaYazdir(string a,string b) // Parametre Alan ve Geriye Değer Döndürmeyen bir Metot
        {
            // Parametre olarak isim ve soyisim bilgilerini alıp " Hoş Geldiniz {isim} {soyisim} " şeklinde ekrana bassın.
            Console.WriteLine($"\nHoşgeldiniz {a} {b}");
        }
    }
}
