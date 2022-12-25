using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace KardashHW6
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string path = @".\input.json";
            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                var books = await JsonSerializer.DeserializeAsync<List<Book>>(fs);
                foreach (var book in books)
                {
                    Console.WriteLine($"{book.PublishingHouseId} - {book.Title} - {book.PublishingHouse.Id} - {book.PublishingHouse.Name} - {book.PublishingHouse.Adress}");
                }
            }
            Console.ReadKey();
        }
    }
}
