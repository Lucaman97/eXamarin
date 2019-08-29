using System;
using SQLite;

namespace eXamarin.Models
{
    public class Note
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Subject { get; set; }
        public string Title { get; set; }
        public string Date { get; set; }
        public string Notes { get; set; }
    }
}
