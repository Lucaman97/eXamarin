using System;
using System.Collections.Generic;
using System.Text;

namespace eXamarin.Models
{
    class Appunto
    {
        public int ID { get; set; }
        public string Subject { get; set; }
        public string Title { get; set; }
        public string Date { get; set; }
        public string Note { get; set; }

        public Appunto(int ID, string Subject, string Title, string Date, string Note)
        {
            this.ID = ID;
            this.Subject = Subject;
            this.Title = Title;
            this.Date = Date;
            this.Note = Note;
        }
    }
}
