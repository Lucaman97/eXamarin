using System;
using SQLite;

namespace eXamarin.Models
{
    public class Subjects
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Subject { get; set; }
    }
}
