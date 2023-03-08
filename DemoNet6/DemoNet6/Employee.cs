using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoNet6
{
    public class Employee
    {
        private int id; //attribute

        private string name;
       
        private int salary;
        //proprety;

        //1.full proprety
        public int Salary
        {
            get {
                return salary;
            }
            set {
                salary = (value <2500) ? 2500:value;
            } 
        
        }
        //2.automtic prop
        public string Name { get; set; }

        //2.automtic prop
        public int ID { get; set; }
    }
}
