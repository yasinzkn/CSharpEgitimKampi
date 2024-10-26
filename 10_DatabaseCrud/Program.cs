using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // CRUD -> Create-Read-Update-Delete

            //Console.WriteLine("***** Menü İşlem Paneli *****");
            //Console.WriteLine();

            //Console.WriteLine("------------------------------");

            #region Veri Tabanına Kategori Ekleme

            //Console.Write("Eklenecek kategori adı: ");
            //string categoryName = Console.ReadLine();

            //SqlConnection conn = new SqlConnection("Data Source= LAPTOP-8VQTI9O3\\SQLEXPRESS; initial catalog = EgitimKampiDb; " +
            //    "integrated security = true");
            //conn.Open();
            //SqlCommand cmd = new SqlCommand("insert into TblCategory (CategoryName) values (@p1)", conn);
            //cmd.Parameters.AddWithValue("@p1", categoryName);
            //cmd.ExecuteNonQuery();
            //conn.Close();

            //Console.Write("Kategori Eklendi");

            #endregion

            #region Veri Tabanına Ürün Ekleme

            //string productName;
            //decimal productPrice;
            ////bool productStatus;

            //Console.Write("Eklenecek ürün adı: ");
            //productName = Console.ReadLine();
            //Console.Write("Ürün fiyatı: ");
            //productPrice = decimal.Parse(Console.ReadLine());

            //SqlConnection conn = new SqlConnection("Data Source = LAPTOP-8VQTI9O3\\SQLEXPRESS; initial catalog = EgitimKampiDb; " +
            //    "integrated security = true");
            //conn.Open();
            //SqlCommand cmd = new SqlCommand("insert into TblProduct (ProductName, ProductPrice, ProductStatus) " +
            //    "values (@productName, @productPrice, @productStatus)", conn);
            //cmd.Parameters.AddWithValue("@productName", productName);
            //cmd.Parameters.AddWithValue("@productPrice", productPrice);
            //cmd.Parameters.AddWithValue("@productStatus", true);
            //cmd.ExecuteNonQuery();
            //conn.Close();

            //Console.Write("Ürün Eklendi");

            #endregion

            #region Veri Tabanından Ürün Listeleme

            //SqlConnection conn = new SqlConnection("Data Source = LAPTOP-8VQTI9O3\\SQLEXPRESS; initial catalog = EgitimKampiDb; " +
            //    "integrated security = true");
            //conn.Open();
            //SqlCommand cmd = new SqlCommand("Select * From TblProduct", conn);
            //SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            //DataTable dataTable = new DataTable();
            //adapter.Fill(dataTable);

            //foreach (DataRow row in dataTable.Rows)
            //{
            //    foreach (var item in row.ItemArray)
            //    {
            //        Console.Write(item.ToString() + " ");
            //    }
            //    Console.WriteLine();
            //}

            //conn.Close();

            #endregion

            #region Ürün Silme

            //Console.Write("Silinecek ürün: ");
            //int productId = int.Parse(Console.ReadLine());

            //SqlConnection conn = new SqlConnection("Data Source = LAPTOP-8VQTI9O3\\SQLEXPRESS; initial catalog = EgitimKampiDb; " +
            //    "integrated security = true");
            //conn.Open();
            //SqlCommand cmd = new SqlCommand("Delete From TblProduct Where ProductId = @productId", conn);
            //cmd.Parameters.AddWithValue("@productId", productId);
            //cmd.ExecuteNonQuery();
            //conn.Close();

            //Console.Write("Ürün Silindi");

            #endregion

            #region Ürün Güncelleme

            //Console.Write("Güncellenecek Ürün Id: ");
            //int productId = int.Parse(Console.ReadLine());
            //Console.Write("Güncellenecek Ürün Adı: ");
            //string productName = Console.ReadLine();
            //Console.Write("Güncellenecek Ürün Fİyatı: ");
            //decimal productPrice = decimal.Parse(Console.ReadLine());

            //SqlConnection conn = new SqlConnection("Data Source = LAPTOP-8VQTI9O3\\SQLEXPRESS; initial catalog = EgitimKampiDb; " +
            //    "integrated security = true");
            //conn.Open();
            //SqlCommand cmd = new SqlCommand("Update TblProduct Set ProductName = @productName," +
            //    "ProductPrice = @productPrice Where ProductId = @productId", conn);
            //cmd.Parameters.AddWithValue("@productName", productName);
            //cmd.Parameters.AddWithValue("@productPrice", productPrice);
            //cmd.Parameters.AddWithValue("@productId", productId);
            //cmd.ExecuteNonQuery();
            //conn.Close();

            //Console.WriteLine("Ürün Güncellendi");

            #endregion

            Console.Read();
        }
    }
}
