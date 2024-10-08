using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region For Döngüsü

            // For(x; y; z;)
            // x: başlangıç
            // y: bitiş
            // z: artış ve azalış


            //int i;

            //for (i = 1; i <=5; i++)
            //{
            //    Console.WriteLine("C# Eğitim Kampı");
            //}


            //for (int i = 1; i <= 15; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //for (int i = 3; i <= 50; i += 3)
            //{
            //    Console.WriteLine(i);
            //}


            //Console.Write("Kaç adet yazılacağını giriniz: ");
            //int finishValue = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= finishValue; i++)
            //{
            //    Console.WriteLine("Yaşasın Cumhuriyet");
            //}

            #endregion

            #region For Döngüsü ile Karar Yapıları

            // 1 ile 100 arasında 5'e tam bölünen sayılar
            //for (int i = 1; i<= 100; i++)
            //{
            //    if (i % 5 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}


            // 1'den 15'e kadar olan sayıların toplamı
            //int total = 0;
            //for (int i = 0; i <= 15; i++)
            //{
            //    total += i;
            //}
            //Console.WriteLine(total);


            // 1'den 50' ye kadar olan çift sayıların toplamı
            //int totalValue = 0;
            //for (int i = 1; i <= 50; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        totalValue += i;
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.WriteLine("----------");
            //Console.WriteLine(totalValue);


            //1 ile 50 arasında 7'ye tam bölünebilen kaç adet sayı olduğunu gösteren program
            //int count = 0;
            //for (int i = 1; i < 51; i++)
            //{
            //    if (i % 7 == 0)
            //    {
            //        count++;
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.WriteLine("----------");
            //Console.WriteLine(count + " tane sayı var");


            //Bakteri örneği
            //int bacterium = 1;
            //for (int i = 1; i <= 24; i++)
            //{
            //    bacterium *= 2;
            //    Console.WriteLine(i + ". saat sonunda " + bacterium);
            //}

            #endregion

            #region While Döngüsü

            //While(şart)
            //{
            //    işlemler
            //        .
            //        .
            //        .
            //}


            //int i = 1;
            //while (i < 11)
            //{
            //    Console.WriteLine(i + "- Merhaba Dünya!");
            //    i++;
            //}


            //int i = 1;
            //while (i < 21)
            //{
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}


            //int i = 0;
            //int sum = 0;
            //while (i <= 15)
            //{
            //    sum += i;
            //    i++;
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("----------");
            //Console.WriteLine(sum);

            #endregion

            #region Örnek Sınav Sorusu

            // Klavyeden girilen 3 basamaklı sayının basamakları toplamını hesaplayan kodu giriniz.
            //int ones, tens, hundreds;
            //int sum;
            //Console.Write("Sayı giriniz: ");
            //int num = int.Parse(Console.ReadLine());

            //ones = num % 10;
            //tens = (num % 100) / 10;
            //hundreds = num / 100;

            //Console.WriteLine(ones + "-" + tens + "-" + hundreds);
            //sum = ones + tens + hundreds;
            //Console.WriteLine(sum);

            #endregion

            Console.Read();
        }
    }
}
