using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace eXamarin.Models
{
    public class ListItemSubjects
    {
        public string Name { get; set;}

        public static explicit operator ListItemSubjects(ListView v)
        {
            throw new NotImplementedException();
        }

        public static explicit operator ListView(ListItemSubjects v)
        {
            throw new NotImplementedException();
        }
    }
}
