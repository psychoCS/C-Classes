using Assignment_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
    {
        class Rational
        {          
            public Int32 Num { get; set; }
           
            public Int32 Den { get; set; }

        public Rational (int num = 0, int den = 1) 
        {
            Num = num;
            Den = den;
        }

            public override string ToString() => $"[{Num}/{Den}]";
            
            public void IncreaseBy(Rational other)
            {
            Num = (Num * other.Den) + (other.Num * Den);
            Den = Den * other.Den;
            }

        public void DecreaseBy(Rational other)
        {
            Num = (Num * other.Den) - (other.Num * Den);
            Den = Den * other.Den;
        }
    }
    }

class program { 

    static void Main(string[] args)
    {
        Rational x = new Rational(); 
        Rational y = new Rational(3);
        Rational w = new Rational(9,8);
        Rational z = new Rational(4, 7);

        Console.WriteLine("So, we have created the 4 rational objects.\n");
        Console.WriteLine($"a:{x}, b:{y}, c:{w}, d{z}\n");

        x.IncreaseBy(w);
        Console.WriteLine($"If we add a nd c the result is {x}.\n");


        z.DecreaseBy(w);
        Console.WriteLine($"If we subtract d nd c the result is {z}.\n");


    }
}

