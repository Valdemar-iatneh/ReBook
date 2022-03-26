using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using ReBook.Pages;

namespace ReBook.Data
{
    public class DataAccess
    {
        SQLiteConnection database;
        public DataAccess(string databasePath)
        {
            database = new SQLiteConnection(databasePath);
            database.CreateTable<Book>();
            database.CreateTable<Review>();
        }
        public int SaveBook(Book book)
        {
            return database.Insert(book);
        }
        public List<Book> GetBooks()
        {
            return database.Table<Book>().ToList();
        }
        public List<Review> GetReviewsById()
        {
            return database.Table<Review>().Where(a => a.IdBook == BooksCatalogPage.book.Id).ToList();
        }
        public List<Review> GetReviews()
        {
            return database.Table<Review>().ToList();
        }
        public int DeleteAllBooks()
        {
            return database.DeleteAll<Book>();
        }
        public int SaveReview(Review review)
        {
            if (review.Id != 0)
            {
                database.Update(review);
                return review.Id;
            }
            else
            {
                return database.Insert(review);
            }
        }
        public int DeleteItem()
        {
            return database.DeleteAll<Review>();
        }
    }
}