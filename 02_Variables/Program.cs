using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Double Değişkenler

            //double number;

            //number = 3.14;

            //Console.WriteLine(number);



            //Console.WriteLine("***** Fiyat Listesi *****");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice, tomatoPrice, potatoPrice;

            //applePrice = 15.95;
            //orangePrice = 22.15;
            //strawberryPrice = 30;
            //tomatoPrice = 8.85;
            //potatoPrice = 7.45;

            //Console.WriteLine("----- ELma Birim Fiyatı: " + applePrice + " TL");
            //Console.WriteLine("----- Portakal Birim Fiyatı: " + orangePrice + " TL");
            //Console.WriteLine("----- Çilek Birim Fiyatı: " + strawberryPrice + " TL");
            //Console.WriteLine("----- Domates Birim Fiyatı: " + tomatoPrice + " TL");
            //Console.WriteLine("----- Patates Birim Fiyatı: " + potatoPrice + " TL");
            //Console.WriteLine();

            //Console.WriteLine("---------------------------------------------------------");

            //double appleGram, orangeGram, strawberryGram, tomatoGram, potatoGram;

            //appleGram = 1.245;
            //orangeGram = 2.340;
            //strawberryGram = 0.750;
            //tomatoGram = 4.825;
            //potatoGram = 5.620;

            //double appleTotalPrice = appleGram * applePrice;
            //double orangeTotalPrice = orangeGram * orangePrice;
            //double strawberryTotalPrice = strawberryGram * strawberryPrice;
            //double tomatoTotalPrice = tomatoGram * tomatoPrice;
            //double potatoTotalPrice = potatoGram * potatoPrice;

            //Console.WriteLine("Alınan Ürün: Elma - "+"Birim Fiyat: "+applePrice +" TL" + " - Gramaj: " +appleGram +" - Toplam Tutar: "+appleTotalPrice);
            //Console.WriteLine("Alınan Ürün: Portakal - "+"Birim Fiyat: "+orangePrice+ " TL" + " - Gramaj: " + orangeGram +" - Toplam Tutar: "+orangeTotalPrice);
            //Console.WriteLine("Alınan Ürün: Çilek - "+"Birim Fiyat: "+strawberryPrice+ " TL" + " - Gramaj: " + strawberryGram +" - Toplam Tutar: "+strawberryTotalPrice);
            //Console.WriteLine("Alınan Ürün: Domates - "+"Birim Fiyat: "+tomatoPrice+ " TL" + " - Gramaj: " + tomatoGram +" - Toplam Tutar: "+tomatoTotalPrice);
            //Console.WriteLine("Alınan Ürün: Patates - "+"Birim Fiyat: "+potatoPrice+ " TL" + " - Gramaj: " + potatoGram +" - Toplam Tutar: "+potatoTotalPrice);

            //double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + tomatoTotalPrice + potatoTotalPrice;

            //Console.WriteLine();

            //Console.WriteLine("Alışveriş Toplam Tutarı: " + shoppingTotalPrice + " TL");

            #endregion

            #region Char Değişkenler

            //char character;
            //character = 'a';

            //Console.WriteLine(character);


            #endregion

            #region Klavyeden Veri Girişleri String Değişkenler

            //Console.WriteLine("***** Havayolları YOlcu Bilgileri *****");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber,
            //    passengerGender, passengerCountry, passengerPhone;

            //Console.Write("TC Kimlik No: ");
            //passengerIdentityNumber = Console.ReadLine();
            //Console.Write("Ad: ");
            //passengerName = Console.ReadLine();
            //Console.Write("Soyad: ");
            //passengerSurname = Console.ReadLine();
            //Console.Write("Yaş: ");
            //passengerAge = Console.ReadLine();
            //Console.Write("Telefon: ");
            //passengerPhone = Console.ReadLine();
            //Console.Write("Cinsiyet: ");
            //passengerGender = Console.ReadLine();
            //Console.Write("İlçe: ");
            //passengerDistrict = Console.ReadLine();
            //Console.Write("Şehir: ");
            //passengerCity = Console.ReadLine();
            //Console.Write("Ülke: ");
            //passengerCountry = Console.ReadLine();

            //Console.WriteLine();

            //Console.WriteLine("-----------------------------------------------------");

            //Console.WriteLine("Yolcu TC Kimlik No: " + passengerIdentityNumber + " - Yolcu Ad Soyad: " + passengerName + " " + passengerSurname + " - Yolcu Yaş: "  + passengerAge
            //    + " - Yolcu Cinsiyet: " + passengerGender + " - Yolcu Telefon No: " + passengerPhone + " - Yolcu İlçe: " + passengerDistrict + " - Yolcu Şehir: " + passengerCity + " - Yolcu Ülke: " + passengerCountry);



            #endregion

            #region Klavyeden Veri Girişleri ve Dönüşümler

            //int shoesPrice, jeansPrice, tvPrice, computerPrice;
            //shoesPrice = 1000;
            //jeansPrice = 1250;
            //computerPrice = 25000;
            //tvPrice = 18000;

            //int shoesCount, jeansCount, computerCount, tvCount;

            //Console.Write("Alınan ayakkabı sayısını giriniz: ");
            //shoesCount = int.Parse(Console.ReadLine());
            //Console.Write("Alınan kot pantolon sayısını giriniz: ");
            //jeansCount = int.Parse(Console.ReadLine());
            //Console.Write("Alınan bilgisayar sayısını giriniz: ");
            //computerCount= int.Parse(Console.ReadLine());
            //Console.Write("Alınan televizyon sayısını giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice = shoesCount * shoesPrice + jeansCount * jeansPrice + computerCount * computerPrice + tvCount * tvPrice;

            //Console.WriteLine();
            //Console.WriteLine("Toplam Ödenecek Tutar: " + totalPrice);

            #endregion

            #region Klavyeden Ondalıklı Sayı İşlemleri

            //double exam1, exam2, exam3, result;

            //Console.Write("Lütfen birinci sınav notunu giriniz: ");
            //exam1 = double.Parse(Console.ReadLine());
            //Console.Write("Lütfen ikinci sınav notunu giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());
            //Console.Write("Lütfen üçüncü sınav notunu giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine();

            //Console.WriteLine("Sınav ortamalanız: " + result);

            #endregion

            #region Klavyeden Karakter Giriş İşlemleri

            //char gender;
            //Console.Write("Lütfen cinsiyet seçiniz: ");
            //gender = char.Parse(Console.ReadLine());
            //Console.WriteLine("Seçilen cinsiyet: " + gender);

            #endregion

            Console.Read();
        }
    }
}
