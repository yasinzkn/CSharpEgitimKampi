using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region If Else

            #region Örnek 1

            //Console.Write("Lütfen şifreyi giriniz: ");
            //string password;
            //password = Console.ReadLine();
            //if (password == "abcd")
            //{
            //    Console.WriteLine("Şifre Doğru");
            //}
            //else 
            //{
            //    Console.WriteLine("Şifre yanlış");
            //}

            #endregion

            #region Örnek 2

            //string capital, country;
            //Console.Write("Başkenti giriniz: ");
            //capital =Console.ReadLine();
            //Console.Write("Ülkeyi giriniz: ");
            //country = Console.ReadLine();

            //if (capital == "ankara" & country == "türkiye")
            //{
            //    Console.WriteLine("Veriler doğrulandı");
            //}
            //else
            //{
            //    Console.WriteLine("Hatalı bilgi");
            //}

            #endregion

            #region Örnek 3

            //int number;
            //Console.Write("Sayıyı giriniz: ");
            //number = int.Parse(Console.ReadLine());

            //if (number == 7)
            //{
            //    Console.WriteLine("Sayı doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı yanlış");
            //}

            #endregion

            #region Örnek 4

            //int exam1, exam2, exam3, average;
            //string result = "Hata!";

            //Console.Write("Birinci Sınav Notu: ");
            //exam1 = int.Parse(Console.ReadLine());

            //Console.Write("İkinci Sınav Notu: ");
            //exam2 = int.Parse(Console.ReadLine());

            //Console.Write("Üçüncü Sınav Notu: ");
            //exam3 = int.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine("Sınav Not Ortalaması: " + average);

            //if (average >= 0 & average < 50)
            //{
            //    result = "Sonuç kötü";
            //}
            //if (average >= 50 & average < 70)
            //{
            //    result = "Sonuç orta";
            //}
            //if (average >= 70 & average < 85)
            //{
            //    result = "Sonuç iyi";
            //}
            //if (average >= 85 & average <= 100)
            //{
            //    result = "Sonuç çok iyi";
            //}


            //Console.WriteLine(result);

            #endregion

            #region Örnek 5

            //string city;
            //Console.WriteLine("Lütfen Şehir giriniz: ");
            //city = Console.ReadLine();

            //if (city == "istanbul" | city == "izmir" | city == "ankara" | city == "antalya")
            //{
            //    Console.WriteLine("Şehir mevcut");
            //}
            //else
            //{
            //    Console.WriteLine("Şehir mevcut değil");
            //}

            #endregion

            #region Örnek 6

            //Console.Write("Kullanıcı adını giriniz: ");
            //string username = Console.ReadLine();
            //if (username != "admin")
            //{
            //    Console.Write("Kullanıcı adı yanlış!");
            //}
            //else
            //{
            //    Console.Write("Hoşgeldiniz");
            //}

            #endregion

            #endregion

            #region Mod İşemleri

            #region Örnek 1

            //int number;
            //number = 17;
            //int result = number % 5;
            //Console.WriteLine(result);


            //Console.Write("Birinci sayıyı giriniz: ");
            //int number1 = int.Parse(Console.ReadLine());

            //Console.Write(("İkinci sayıyı giriniz: "));
            //int number2 = int.Parse(Console.ReadLine());

            //int result = number1 % number2;

            //Console.Write("Birinci sayının ikinci sayıya bölümünden kalan: " + result);

            #endregion

            #region Örnek 2

            //Console.Write("Lütfen bir sayı giriniz: ");
            //int number = int.Parse(Console.ReadLine());

            //if (number % 2 == 0)
            //{
            //    Console.WriteLine("Sayı çift");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı tek");
            //}

            #endregion

            #endregion

            #region Char Değişkenler ile Karar Yapıları

            //char team;
            //Console.Write("Lütfen takım sembolünü giriniz: ");
            //team = char.Parse(Console.ReadLine());

            //if (team == 'f' | team == 'F')
            //{
            //    Console.Write("Fenerbahçe");
            //}
            //if (team == 'g' | team == 'G')
            //{
            //    Console.Write("Galatasaray");
            //}
            //if (team == 'b' | team == 'B')
            //{
            //    Console.Write("Beşiktaş");
            //}
            //else
            //{
            //    Console.Write("Hatalı sembol girişi");
            //}

            #endregion

            #region Örnek Proje Uygulaması

            //Console.WriteLine("***** C# Eğitim Kampı Restoran Menüsü *****");
            //Console.WriteLine();
            //Console.WriteLine("--------------------------------------------------");

            //Console.WriteLine("1- Ana Yemekler");
            //Console.WriteLine("2- Çorbalar");
            //Console.WriteLine("3- Pizzalar");
            //Console.WriteLine("4- İçecekler");
            //Console.WriteLine("5- Tatlılar");

            //Console.WriteLine("--------------------------------------------------");
            //Console.WriteLine();

            //string menuItem;
            //Console.Write("Menüyü görmek için seçim yapınız: ");
            //menuItem = Console.ReadLine();

            //if (menuItem == "1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------Ana Yemekler------------");
            //    Console.WriteLine();

            //    Console.WriteLine("1-Köri Soslu Tavuk");
            //    Console.WriteLine("2-Kızartma Tabağı");
            //    Console.WriteLine("3-Fasulye Pilav");
            //    Console.WriteLine("4-Fırında Somon");
            //    Console.WriteLine("5-Karnıyarık");

            //    Console.WriteLine();
            //    Console.WriteLine("------------Ana Yemekler------------");
            //}

            //if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------Çorbalar------------");
            //    Console.WriteLine();

            //    Console.WriteLine("1-Mercimek Çorbası");
            //    Console.WriteLine("2-Ezogelin Çorba");
            //    Console.WriteLine("3-Arpa Şehriye Çorbası");
            //    Console.WriteLine("4-Tarhana Çorbası");
            //    Console.WriteLine("5-Sulu Köfte Çorba");

            //    Console.WriteLine();
            //    Console.WriteLine("------------Çorbalar------------");
            //}

            //if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------Pizzalar------------");
            //    Console.WriteLine();

            //    Console.WriteLine("1-Akdeniz Pizza");
            //    Console.WriteLine("2-Margarita Pizza");
            //    Console.WriteLine("3-Tavuklu Pizza");
            //    Console.WriteLine("4-Mantarlı Pizza");
            //    Console.WriteLine("5-Sucuklu Pizza");

            //    Console.WriteLine();
            //    Console.WriteLine("------------Pizzalar------------");
            //}

            //if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------İçecekler------------");
            //    Console.WriteLine();

            //    Console.WriteLine("1-Kola");
            //    Console.WriteLine("2-Ayran");
            //    Console.WriteLine("3-Su");
            //    Console.WriteLine("4-Portakal Suyu");
            //    Console.WriteLine("5-Gazoz");

            //    Console.WriteLine();
            //    Console.WriteLine("------------İçecekler------------");
            //}

            //if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------Tatlılar------------");
            //    Console.WriteLine();

            //    Console.WriteLine("1-Triliçe");
            //    Console.WriteLine("2-Kazandibi");
            //    Console.WriteLine("3-Sütlaç");
            //    Console.WriteLine("4-Puding");
            //    Console.WriteLine("5-Magnolya");

            //    Console.WriteLine();
            //    Console.WriteLine("------------Tatlılar------------");
            //}

            #endregion

            #region Switch Case Uygulamaları

            #region Örnek 1 (Takvim / Aylar)


            //Console.Write("Lütfen ay girişi yapınız: ");
            //int monthNumber = int.Parse(Console.ReadLine());

            //switch (monthNumber)
            //{
            //    case 1:
            //        Console.Write("Ocak");
            //        break;
            //    case 2:
            //        Console.Write("Şubat");
            //        break;
            //    case 3:
            //        Console.Write("Mart");
            //        break;
            //    case 4:
            //        Console.Write("Nisan");
            //        break;
            //    case 5:
            //        Console.Write("Mayıs");
            //        break;
            //    case 6:
            //        Console.Write("Haziran");
            //        break;
            //    case 7:
            //        Console.Write("Temmuz");
            //        break;
            //    case 8:
            //        Console.Write("Ağustos");
            //        break;
            //    case 9:
            //        Console.Write("Eylül");
            //        break;
            //    case 10:
            //        Console.Write("Ekim");
            //        break;
            //    case 11:
            //        Console.Write("Kasım");
            //        break;
            //    case 12:
            //        Console.Write("Aralık");
            //        break;
            //    default:
            //        Console.WriteLine("Hatalı veri girişi!");
            //        break;
            //}

            #endregion

            #region Örnek 2 (Hesap Makinesi)

            //int number1, number2, result;

            //char symbol;

            //Console.Write("Birinci sayıyı giriniz: ");
            //number1 = int.Parse(Console.ReadLine());

            //Console.Write("İkinci sayıyı giriniz: ");
            //number2 = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen yapmak istediğiniz işlemi seçiniz: ");
            //symbol = char.Parse(Console.ReadLine());

            //switch (symbol)
            //{
            //    case '+':
            //        result = number1 + number2;
            //        Console.WriteLine("Sonuç: " + result);
            //        break;
            //    case '-':
            //        result = number1 - number2;
            //        Console.WriteLine("Sonuç: " + result);
            //        break;
            //    case '*':
            //        result = number1 * number2;
            //        Console.WriteLine("Sonuç: " + result);
            //        break;
            //    case '/':
            //        result = number1 / number2;
            //        Console.WriteLine("Sonuç: " + result);
            //        break;
            //    case '%':
            //        result = number1 % number2;
            //        Console.WriteLine("Sonuç: " + result);
            //        break;
            //    default:
            //        Console.WriteLine("Hatalı işlem girişi!");
            //        break;
            //}

            #endregion

            #endregion

            Console.Read();

        }
    }
}
