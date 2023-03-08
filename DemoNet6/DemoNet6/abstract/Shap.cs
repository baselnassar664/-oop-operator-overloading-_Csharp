using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoNet6.Abstract
{
    internal abstract class Shap
       {

        public double Dim1{ get; set; } //proprety not need to implemented
        public double Dim2{ get; set; } //proprety not need to implemented

        public abstract  double Parametr { get;  } //proprety need to implemented

        public abstract double CalcluateArea(); //methode abstract need to implemented
   
        
        public void print() //methode not need to implemented
        {
            Console.WriteLine("a");
        }

    }

   abstract class ParentRestangle : Shap
    {
        public override double CalcluateArea() //just override to methode CalcluateArea because use abstract  before class ParentRestangle
        {
           return Dim1*Dim2;
        }
    }

    class React : ParentRestangle 
    {
        public override double Parametr
        { //override to proprety paramter becuase class ParentRestangle not override to proprety paramter

            get { return 2 * (Dim1 + Dim2); }
        }

      
    }

    class Square : ParentRestangle
    {
        public override double Parametr  //override to proprety paramter becuase class ParentRestangle not override to proprety paramter
        {                                    

            get { return 2 * Dim1 ; }
        }

    }
}
