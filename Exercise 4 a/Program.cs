using System;

namespace Exercise_4_a
{
    class Program
    {
        static void Main(string[] args)
        {
            /*4.Write a program to create the following figures:
            a.
            
                 *
                ***
               *****
              *******
             *********
            ***********
             *********
              *******
               *****
                ***
                 *
            */

            Int32 Space = 5, Star = 1;
            bool build = true;

            while ((Space >= 0) && (Space < 6))
            {
                
                for (int i = 0; i < Space; i++)
                {
                    Console.Write(" ");
                }

                for (int i = 0; i < Star; i++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();

                if (Space == 0)
                {
                    build = false;
                }

                if (build == true)
                {
                    Space -= 1;
                    Star += 2;
                }

                else { Space += 1;
                    Star -= 2;
                }
            }
            

        }
    }
}

