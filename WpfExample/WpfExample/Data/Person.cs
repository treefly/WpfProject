using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfExample.Data
{
    public class Person
    {
        public Person(string s)
        {
           
        }
        public Person()
        {
          
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string HomeTown { get; set; }
        public string PersonName { get; set; }

        public string Name { get; set; }
        public override string ToString()
        {
            return FirstName.ToString();
        }
    }
}
