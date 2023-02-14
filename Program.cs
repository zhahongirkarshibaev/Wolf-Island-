using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WolfIsland
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rebite rebite = new Rebite();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(rebite.X + ";" + rebite.Y);
                rebite.Muve();
            }
            Console.WriteLine();

            for (int i = 0; i < 15; i++)
            {
                Animall r = rebite.Reprodaction();
                if (r != null)
                {
                    Console.WriteLine(r.X + ";" + r.Y);
                }
            }
            Console.WriteLine();

            WolfFam wolf = new WolfFam();
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(wolf.X + ";" + wolf.Y);
                wolf.Muve(i);
            }
            Console.WriteLine();

            //for (int i = 0; i < 3; i++)
            //{
             //   Console.WriteLine();
            //}

                Console.ReadLine();
        }
    }
}
