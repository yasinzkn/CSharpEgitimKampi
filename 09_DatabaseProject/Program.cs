using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_DatabaseProject
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Veri Tabanlı Ürün Kategori Bilgi Sistemi Uygulaması
            Console.WriteLine("***** C# Veri Tabanlı Ürün Kategori Bilgi Sistemi *****");
            Console.WriteLine();

            string tableNumber;

            Console.WriteLine("--------------------------------------------------");

            //Kategori Seçimi
            Console.WriteLine("1-Kategoriler");
            Console.WriteLine("2-Ürünler");
            Console.WriteLine("3-Siparişler");
            Console.WriteLine("4-Çıkış Yap");
            Console.Write("Lütfen  tablo numarasını giriniz: ");
            tableNumber = Console.ReadLine();

            Console.WriteLine("--------------------------------------------------");

            //Veri Tabanı İşlemleri
            SqlConnection connection = new SqlConnection("Data Source= LAPTOP-8VQTI9O3\\SQLEXPRESS; initial catalog = EgitimKampiDb; " +
                "integrated security = true");
            connection.Open();
            SqlCommand command = new SqlCommand("Select * From TblCategory", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            connection.Close();

            //Veri Tabanındaki Verilerin Kullanılması (Ekranda İlgili Bilgileri Gösterme)
            foreach (DataRow row in dataTable.Rows)
            {
                foreach (var item in row.ItemArray)
                {
                    Console.Write(item.ToString() + " ");
                }
                Console.WriteLine();
            }

            Console.Read();
        }
    }
}
