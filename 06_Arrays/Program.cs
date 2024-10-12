using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Diziler / Temel Örnek Uygulamalar

            // Dizilerin kullanım şekli:
            // DeğişkenTürü[] diziAdı = new DeğişkenTürü[];

            #region Örnek 1 / Renkler

            //string[] colors = new string[7];
            //colors[0] = "Kırmızı";
            //colors[1] = "Beyaz";
            //colors[2] = "Mavi";
            //colors[3] = "Mor";
            //colors[4] = "Turuncu";
            //colors[5] = "Yeşil";
            //colors[6] = "Kahverengi";

            //Console.WriteLine(colors[4]);

            #endregion

            #region Örnek 2 / Başkentler

            //string[] capitals = new string[6];
            //capitals[0] = "Rome";
            //capitals[1] = "Berlin";
            //capitals[2] = "Ankara";
            //capitals[3] = "Madrid";
            //capitals[4] = "Sofia";
            //capitals[5] = "Moscow";

            //Console.WriteLine(capitals[2]);

            #endregion

            #region Örnek 3 / Sayılar

            //int[] numbers = new int[10];
            //numbers[0] = 58;
            //numbers[1] = 34;
            //numbers[2] = 5;
            //numbers[5] = 106;
            //numbers[8] = 9;

            //Console.WriteLine(numbers[4]);

            #endregion

            #region Örnek 4 / Şehirler

            //string[] cities = {"istanbul", "Ankara", "Antalya", "İzmir", "Bursa" };

            //Console.WriteLine(cities[4]);

            #endregion

            #endregion

            #region Dizi Elemanlarını Listeleme

            #region Örnek 1

            //string[] colors = { "Kırmızı", "Beyaz", "Mavi", "Sarı", "Yeşil" };
            //for (int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}

            #endregion

            #region Örnek 2

            //int[] numbers = { 127, 89, 36, 41, 784, 657, 795, 488, 19, 1028, 1115, 129, 13, 27, 875 };
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 3 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            #endregion

            #region Örnek 3

            //char[] chars = { 'a', 'f', 'n', '*', '-', '/' };
            //for (int i = 0; i < chars.Length; i++)
            //{
            //    Console.WriteLine(chars[i]);
            //}

            #endregion

            #region Örnek 4

            //int[] numbers = { 145, 53, 86, 129, 251, 97, 567, 435, 782, 335 };

            //int maxNumber = numbers[0];

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] > maxNumber)
            //    {
            //        maxNumber = numbers[i];
            //    }
            //}
            //Console.WriteLine(maxNumber);

            #endregion

            #region Örnek 5

            //string[] person = { "Ali", "Veli", "Ayşe", "Fatma", "Ahmet" };
            //Console.WriteLine(person.Length);

            #endregion

            #endregion

            #region Dizi Metotlar

            #region Örnek 1 Dizideki sayıları küçükten büyüğe sıralama / Sort Metodu

            //int[] numbers = { 46, 78, 24, 89, 157, 54, 38, 60 };
            //Array.Sort(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            #endregion

            #region Örnek 2 Dizideki sayıları büyükten küçüğe sıralama / Sort Metodu

            //int[] numbers = { 46, 78, 24, 89, 157, 54, 38, 60 };
            //Array.Sort(numbers);
            //for (int i = numbers.Length - 1; i >= 0; i--)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            #endregion

            #region Örnek 3 Diziyi tersten yazdırma / Reverse Metodu

            //int[] numbers = { 46, 78, 24, 89, 157, 54, 38, 60 };
            //Array.Reverse(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            #endregion

            #region Örnek 4 IndexOf Metodu

            //string[] customers = { "Ali", "Ahmet", "Fatma", "Ayşe", "Kemal", "Buse", "Deniz", "Elif" };
            //int index = Array.IndexOf(customers, "Buse");
            //Console.WriteLine(index);

            #endregion

            #region Örnek 5 Max ve Min Metotları

            //int[] numbers = { 53, 67, 32, 68, 90, 23, 75, 89 };
            //Console.WriteLine("En büyük sayı: " + numbers.Max());
            //Console.WriteLine("En küçük sayı: "+ numbers.Min());

            #endregion

            #endregion

            #region Kullanıcıdan Değer Alma 

            //string[] cities = new string[7];
            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write($"Lütfen {i + 1}. şehri giriniz: ");
            //    cities[i] = Console.ReadLine();
            //}
            //Console.WriteLine();
            //Console.WriteLine("-------------------------");

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}

            #endregion

            #region Dizideki sayıların toplamı

            //int[] numbers = { 15, 56, 35, 23, 78, 89 };
            //int sum = 0;

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    sum += numbers[i];
            //}
            //Console.WriteLine(sum);

            #endregion

            #region Örnek Tek ve Çift Sayılar

            //int[] numbers = { 13, 54, 78, 34, 64, 57, 9, 33, 26, 85, 45, 60 }; ;

            //Console.WriteLine("Çift Sayılar");
            //Console.WriteLine("-----------------------");
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            //Console.WriteLine();

            //Console.WriteLine("Tek Sayılar");
            //Console.WriteLine("-----------------------");
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 1)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            #endregion

            Console.Read();
        }
    }
}
