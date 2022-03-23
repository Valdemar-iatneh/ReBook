using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using Newtonsoft.Json;

namespace ReBook.Data
{
    [Table("Books")]
    public class Book
    {
        [PrimaryKey, Column("_id")]
        [JsonProperty("build_id")]
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("author")]
        public string Author { get; set; }
        [JsonProperty("img_src")]
        public string Image { get; set; }

    }
}