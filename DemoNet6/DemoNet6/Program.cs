using DemoNet6.inhertaince;
using DemoNet6.Interface;
using DemoNet6.operator_overloading;
using System.Globalization;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;

namespace DemoNet6
{
 

    internal class Program
    {
     

        static void Main(string[] args)

        {
            Complexx complex1 = new Complexx() 
            {
                Real = 1,      //by object inilaizer without use constroctor
                Image = 2,
            };
            Complexx complex2 = new Complexx() 

            {
                Real = 3,       //by object inilaizer without use constroctor
                Image = 4,
            };
            Complexx complex3 = complex1 + complex2;

            Console.WriteLine(complex3);

            complex3++;

            Console.WriteLine(complex3);

            complex3 += 5;
            Console.WriteLine(complex3);

            if(complex3> complex2)
                Console.WriteLine("complex3 greater than complex2  ");

            int x = complex1;//implicit
            Console.WriteLine(x);

            string y =(string) complex2; //explicit
            Console.WriteLine(y);
            Employee employee = new Employee()
            {
                ID = 1,
                Name = "Basel Nassar",
                Salary = 5000,

            };

            Person person = (Person)employee; //copy basel to object person (first name) and copy nassar to object person (last name)
            Console.WriteLine(person);
        }
    }
}
