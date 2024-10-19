using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Metotlar

            //1- Geriye değer döndürmeyen metotlar
            //2- Geriye değer döndüren metotlar

            #region Geriye Değer Döndürmeyen Metotlar

            //void CustomerList()
            //{
            //    Console.WriteLine("Ahmet");
            //    Console.WriteLine("Ayşe");
            //    Console.WriteLine("Mehmet");
            //    Console.WriteLine("Fatma");
            //}

            //CustomerList();
            //CustomerList();



            //void Sum() {
            //    int x = 5;
            //    int y = 10;
            //    int z = x + y;
            //    Console.WriteLine(z);
            //}

            //Sum();

            #endregion

            #endregion

            #region Geriye Değer Döndürmeyen String Parametreli Metotlar

            //void WriteMethod(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}

            //WriteMethod("Ali Yıldız");



            //void CustomerCard(string name, string surname)
            //{
            //    Console.WriteLine("Müşteri: " + name + " " + surname);
            //}

            //CustomerCard("Ahmet", "Çimen");
            //CustomerCard("Fadime", "Ceylan");

            #endregion

            #region Geriye Değer Döndürmeyen Int Parametreli Metotlar

            //void Sum(int number1,  int number2, int number3)
            //{
            //    int result = number1 + number2 + number3;
            //    Console.WriteLine(result);
            //}

            //Sum(7, 9, 4);

            #endregion

            #region Geriye Değer Döndüren Metotlar

            //string CustomerName()
            //{
            //    return "Mehmet Kaya";
            //}

            //CustomerName();

            //string StudentCard()
            //{
            //    string name = "Murat";
            //    string surname = "Kazan";

            //    return name + " " + surname;
            //}

            //Console.WriteLine(StudentCard());

            #endregion

            #region Geriye Değer Döndüren String Parametreli Metotlar

            //string CountryCard(string countryName, string capital, string flagColor)
            //{
            //    string cardInfo = "Ülke: " + countryName + "\nBaşkent: " + capital + "\nBayrak Rengi: " + flagColor;

            //    return cardInfo;
            //}

            //Console.Write("Ülke adını giriniz: ");
            //string a = Console.ReadLine();

            //Console.Write("Başkenti giriniz: ");
            //string b = Console.ReadLine();

            //Console.Write("Bayrak rengini giriniz: ");
            //string c = Console.ReadLine();

            //Console.WriteLine(CountryCard(a, b, c));

            //Console.WriteLine(CountryCard("Türkiye", "Ankara", "Kırmızı Beyaz"));

            #endregion

            #region Geriye Değer Döndüren Int Parametreli Metotlar

            //int Sum(int number1, int number2)
            //{
            //    int result = number1 + number2;
            //    return result;
            //}

            //Console.WriteLine(Sum(56, 29));
            //Console.WriteLine(Sum(27, 38));
            //Console.WriteLine(Sum(43, 76));

            #endregion

            #region Örnek Uygulama

            //string ExamResult(string student, int exam1, int exam2, int exam3)
            //{
            //    int result = (exam1 + exam2 + exam3) / 3;
            //    if (result > 49)
            //    {
            //        return student + " isimli öğrenci dersi geçti" + "\nNot ortalaması: " + result;
            //    }
            //    else
            //    {
            //        return student + " isimli öğrenci dersten kaldı" + "\nNot ortalaması: " + result;
            //    }
            //}

            //Console.WriteLine(ExamResult("Ahmet", 26, 47, 54));
            //Console.WriteLine(ExamResult("Ayşe", 74, 56, 68));

            #endregion

            Console.Read();
        }
    }
}
