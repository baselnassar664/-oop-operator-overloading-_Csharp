using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoNet6.operator_overloading
{
    internal class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
       
        
        public static explicit operator Person(Employee e)
        {
            string[] names=e.Name.Split(' ');
            return new Person()
            {
                FirstName = names[0],
                LastName = names[1]

            };

        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }


    }
}
