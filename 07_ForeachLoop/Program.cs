using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Foreach Döngüsü

            //Foreach(1;2;3;4)
            //4 parametre alır. Bunlar;
            //1: Değişken Türü
            //2: Değişken Adı
            //3: In
            //4: Liste, Koleksiyon, Dizi

            #region Örnek 1

            //string[] cities = { "Madrid", "Londra", "Viyana", "İstanbul", "Paris" };
            //foreach (string city in cities)
            //{
            //    Console.WriteLine(city);
            //}

            #endregion

            #region Örnek 2

            //int[] numbers = { 26, 89, 467, 807, 53, 78, 156, 1023, 1895, 67, 2003, 952 };
            //foreach (int i in numbers)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            #endregion

            #region Örnek 3

            //int[] numbers = { 35, 46, 467, 89, 153, 258, 167, 1363, 3895, 2067, 201, 298, 751 };
            //int total = 0;
            //foreach (int i in numbers)
            //{
            //    total += i;
            //}
            //Console.WriteLine(total);

            #endregion

            #region Örnek 4

            //List<int> numbers = new List<int>()
            //{
            //    2,5,7,9,10
            //};
            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            #endregion

            #region Örnek 5

            //string word = "Merhaba";
            //foreach (char s in word)
            //{
            //    Console.WriteLine(s);
            //}

            #endregion

            #endregion

            #region Sınav Sistemi Örneği

            //Console.Write("***** C# Eğitim Kampı Sınav Uygulaması *****");
            //Console.WriteLine();

            ////Öğrenci sayısını alma
            //Console.WriteLine("------------------------------");
            //Console.Write("Sınıftaki öğrenci sayısı: ");
            //int studentCount = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("------------------------------");

            ////Öğrenci isim ve not ortalamasının tutulacağı yer
            //string[] studentNames = new string[studentCount];
            //double[] studentExamAvrage = new double[studentCount];

            //for (int i = 0; i < studentCount; i++)
            //{
            //    Console.Write($"{i + 1}. öğrencinin adını giriniz: ");
            //    studentNames[i] = Console.ReadLine();
            //    double totalExamResult = 0;

            //    //Her öğrenci için 3 sınav not girişi
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write($"{studentNames[i]} adlı öğrencinin {j + 1}. sınav notunu giriniz: ");
            //        double value = Convert.ToDouble(Console.ReadLine());

            //        //Notların Toplanması
            //        totalExamResult += value;
            //    }
            //    Console.WriteLine("------------------------------");
            //    studentExamAvrage[i] = totalExamResult / 3;
            //}

            ////Ortalamalar
            //for (int i = 0; i < studentCount; i++)
            //{
            //    Console.WriteLine($"{studentNames[i]} adlı öğrencinin not ortalaması: {studentExamAvrage[i]}");

            //    //Geçma kalma durumu
            //    if (studentExamAvrage[i] >= 50)
            //    {
            //        Console.WriteLine($"{studentNames[i]} adlı öğrenci dersten geçti");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{studentNames[i]} adlı öğrenci dersten kaldı");
            //    }
            //    Console.WriteLine("------------------------------");
            //}

            #endregion

            Console.Read();

        }
    }
}
