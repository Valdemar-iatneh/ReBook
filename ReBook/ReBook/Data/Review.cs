
using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace ReBook.Data
{
    [Table("Reviews")]
    public class Review
    {
        [PrimaryKey, Column("_id"), AutoIncrement]
        public int Id { get; set; }
        public string Author { get; set; }
        public string Comment { get; set; }
        public int Rank { get; set; }
        public DateTime Date { get; set; }
        public int IdBook { get; set; }


    }
}
