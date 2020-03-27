using System;

namespace loopingpractice
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 1.	Write a program to create the following figures:
            a.	
            -----*
            ----***
            ---*****
            --*******
            -*********
            ***********
            * 
            */

            double Star = 1;


            if (Star == 1)
            {
                Console.WriteLine("-----*");
                Star = Star + 1;

                if (Star == 2) ;
                {
                    Console.WriteLine("----***");
                    Star = Star + 1;

                    if (Star == 3) ;
                    {
                        Console.WriteLine("---*****");
                        Star = Star + 1;

                        if (Star == 4) ;
                        {
                            Console.WriteLine("--*******");
                            Star = Star + 1;

                            if (Star == 5) ;
                            {
                                Console.WriteLine("-*********");
                                Star = Star + 1;

                                if (Star == 6) ;
                                {
                                    Console.WriteLine("***********");
                                }
                            }
                        }
                    }
                }
            }

            Int32 num = 6, diff = 1;

            do
            {

                for (int i = 0; i < (num - diff); i++)
                {
                    Console.Write("-");
                }

                for (int i = 0; i < diff; i++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
                num += 1;
                diff += 2;
            } while (num < 12);


        }
    }
}
            
            

            
        
    


