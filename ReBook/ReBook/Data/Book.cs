using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using Newtonsoft.Json;
using Xamarin.Forms;

namespace ReBook.Data
{
    [Table("Books")]
    public class Book
    {
        [PrimaryKey, Column("_id"), AutoIncrement]
        [JsonProperty("build_id")]
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("author")]
        public string Author { get; set; }
        [JsonProperty("img_src")]
        public string Image { get; set; }
        public UriImageSource ImagePath =>
            new UriImageSource
            {
                Uri = new Uri($"https://book-cover.ru{Image}"),
                CachingEnabled = true,
            };
    }
}