using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace DemoNet6.operator_overloading
{
    internal class Complexx
    {
        public int Real{ get; set; }
        public int Image{ get; set; }



        //collection two object must use static

        public static Complexx operator +(Complexx left,Complexx right)
        {
            return new Complexx()
            {
                Real = right.Real + left.Real,
                Image = right.Image + left.Image,
            };
        }

        
        //add one to object
        public static Complexx operator ++(Complexx c)
        {

            return new Complexx()
            {
             Real = c.Real + 1,
             Image = c.Image + 1,

            };
        }

        //add number to object
        public static Complexx operator+(Complexx c,int number)
        {

            return new Complexx()
            {
                Real = c.Real + number,
                Image = c.Image + number,

            };

        }

        //compare between two object
        public static bool operator >(Complexx left, Complexx right)
        {
            if(left.Real != right.Real) 
                return left.Real > right.Real;
            else
                return left.Image > right.Image;
            
            

        }

        //compare between two object
        public static bool operator <(Complexx left, Complexx right)
        {
            if (left.Real != right.Real)
                return left.Real < right.Real;
            else
                return left.Image < right.Image;



        }

        //convert object to int (implicit )

        public static implicit operator int (Complexx c)
        {
            return c.Real+c.Image;
        }


        public static explicit operator string(Complexx c)
        {
            return c.ToString();
        }


        public override string ToString()
        {
            return $"{Real}+{Image}";
        }
    }
}
