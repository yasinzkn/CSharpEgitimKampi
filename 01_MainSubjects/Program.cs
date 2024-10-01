using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Yazdırma Komutları
            //Console.WriteLine("Merhaba Dünya!");
            //Console.Write("Selam");


            //Console.WriteLine("***** Yemek Kategorileri *****");
            //Console.WriteLine();
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("3-Soğuk Başlangıçlar");
            //Console.WriteLine("4-Salatalar");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("6-İçecekler");
            //Console.WriteLine();
            //Console.WriteLine("***** Yemek Kategorileri *****");
            #endregion

            #region String Değişkenler

            //string
            //Değişken_türü değişken_adı;

            //string name;
            //name = "Yasin";
            //Console.Write(name);

            //string customerName;
            //string customerSurname;
            //string customerPhone;
            //string customerEmail, district, city;

            //customerName = "Yasin";
            //customerSurname = "Özkan";
            //customerPhone = "+90 500 600 30 40";
            //customerEmail = "deneme@gmail.com";
            //district = "Kılavuz";
            //city = "Sivas";

            //Console.WriteLine("**** Rezervasyon Kartı ****");
            //Console.WriteLine();
            //Console.WriteLine("-----------------------------------------------");
            //Console.WriteLine("Müşteri: "+ customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: " + customerPhone);
            //Console.WriteLine("Email: " + customerEmail);
            //Console.WriteLine("Adres: "+ district + "/" + city);
            //Console.WriteLine("-----------------------------------------------");

            //Console.WriteLine();

            //customerName = "Ayşegül";
            //customerSurname = "Kaya";
            //customerPhone = "+90 500 700 50 60";
            //customerEmail = "test@gmail.com";
            //district = "Kadıköy";
            //city = "İstanbul";

            //Console.WriteLine("-----------------------------------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: " + customerPhone);
            //Console.WriteLine("Email: " + customerEmail);
            //Console.WriteLine("Adres: " + district + "/" + city);
            //Console.WriteLine("-----------------------------------------------");



            #endregion

            #region Int Değişkenler

            //int
            //int number = 58;
            //Console.WriteLine(number);



            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 30;

            Console.WriteLine("**** Restoran Menü Fiyatı ****");
            Console.WriteLine();
            Console.WriteLine("-----Hamburger: " + hamburgerPrice + " TL");
            Console.WriteLine("-----Pizza: " + pizzaPrice + " TL");
            Console.WriteLine("-----Kızartma: " + friesPrice + " TL");
            Console.WriteLine("-----Su: " + waterPrice + " TL");
            Console.WriteLine("-----Kola: " + cokePrice + " TL");
            Console.WriteLine("-----Limonata: " + lemonadePrice + " TL");

            Console.WriteLine();

            Console.WriteLine("**** Restoran Menü Fiyatı ****");
            Console.WriteLine();
            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int friesCount;
            int pizzaCount;
            int lemonadeCount;

            int totalHamburgerPrice = 0;
            int totalCokePrice = 0;
            int totalWaterPrice = 0;
            int totalFriesPrice = 0;
            int totalPizzaPrice = 0;
            int totalLemonadePrice = 0;

            hamburgerCount = 3;
            cokeCount = 3;
            waterCount = 3;
            friesCount = 1;
            pizzaCount = 0;
            lemonadeCount = 0;

            totalHamburgerPrice = hamburgerCount * hamburgerPrice;
            totalCokePrice = cokeCount * cokePrice;
            totalWaterPrice = waterCount * waterPrice;
            totalFriesPrice = friesCount * friesPrice;
            totalPizzaPrice = pizzaCount * pizzaPrice;
            totalLemonadePrice = lemonadeCount * lemonadePrice;

            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Hamburger Tutarı: " + totalHamburgerPrice + " TL");
            Console.WriteLine("Pizza Tutarı: " + totalPizzaPrice + " TL");
            Console.WriteLine("Kızartma Tutarı: " + totalFriesPrice + " TL");
            Console.WriteLine("Kola Tutarı: " + totalCokePrice + " TL");
            Console.WriteLine("Su Tutarı: " + totalWaterPrice + " TL");
            Console.WriteLine("Limonata Tutarı: " + totalLemonadePrice + " TL");

            Console.WriteLine();
            
            int totalPrice = totalLemonadePrice + totalWaterPrice + totalFriesPrice + totalCokePrice + totalHamburgerPrice + totalPizzaPrice;
            Console.WriteLine("Toplam Ödenecek Tutar: "+totalPrice+ " TL");

            #endregion

            Console.Read();
        }
    }
}