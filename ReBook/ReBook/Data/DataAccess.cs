using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace ReBook.Data
{
    public class DataAccess
    {
        SQLiteConnection database;
        public DataAccess(string databasePath)
        {
            database = new SQLiteConnection(databasePath);
            database.CreateTable<Book>();
        }
        public int SaveBook(Book book)
        {
            return database.Insert(book);
        }
    }
}
