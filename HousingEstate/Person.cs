using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
namespace HousingEstate
{
    class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }

    
    public Person()
       {


       }

       public override string ToString()
       {
           return Name;
       }


    }
}