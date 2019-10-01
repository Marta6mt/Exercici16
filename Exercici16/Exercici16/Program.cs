using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercici16
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static public void Menu()
        {
            Console.WriteLine("Llista Jocs: ");
            Console.WriteLine();
            Console.WriteLine("1 - Sims");
            Console.WriteLine("2 - Sims2");
            Console.WriteLine("3 - Sims3");
            Console.WriteLine("4 - Sims4");

            int opcio = int.Parse(Console.ReadLine());
            if (opcio>0 && opcio<5)
            {
                switch (opcio)
                {
                    case 1:
                        Sims();
                        break;

                    case 2:
                        Sims2();
                        break;

                    case 3:
                        Sims3();
                        break;
                    case 4:
                        Sims4();
                        break;
                }
            }
            
        }
        static public void Sims()
        {
            Console.WriteLine("Hola, Soc els sims");
	    Console.WriteLine("El més basic");
        }
        static public void Sims2()
        {
            Console.WriteLine("Hola, Soc els sims2");
        }
        static public void Sims3()
        {
            Console.WriteLine("Hola, Soc els sims3");
        }
        static public void Sims4()
        {
            Console.WriteLine("Hola, Soc els sims4");
        }
    }
}
