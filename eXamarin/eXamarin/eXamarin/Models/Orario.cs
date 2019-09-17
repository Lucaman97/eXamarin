using System;
using SQLite;

namespace eXamarin.Models
{
    public class Orario
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string giorno { get; set; }
        public string materia { get; set; }
        public string orario { get; set; }
        public string aula { get; set; }
    
    }
}
