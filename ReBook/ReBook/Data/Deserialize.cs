using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Reflection;

namespace ReBook.Data
{
    public static class Deserialize
    {
        public static void Main()
        {
            var assembly = Assembly.GetExecutingAssembly();
            string path = @"ReBook.Data.BooksData.json";
            string json;
            using (Stream stream = assembly.GetManifestResourceStream(path))
            using (StreamReader sr = new StreamReader(stream))
            {
                json = sr.ReadToEnd();
            }
            var books = JsonConvert.DeserializeObject<List<Book>>(json);
            App.Db.DeleteAllBooks();
            foreach (Book book in books)
            {
                App.Db.SaveBook(book);
            }
        }
    }
}
