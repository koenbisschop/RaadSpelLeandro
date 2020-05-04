using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Raadspelletje;

namespace Spellen
{
    class Program
    {
        static Raadspel raadspel = new Raadspel();
        static void Main(string[] args)
        {
            Boolean stopen = false;
            while (!stopen)
            {
                Boolean einde = false;
                Console.WriteLine("Druk Enter om te beginen.");
                Console.ReadLine();
                raadspel.Worp();
                raadspel.AantalBeurten = 1;
                while (einde == false)
                {
                    int gok;
                    try
                    {
                        Console.WriteLine($"Kans {raadspel.AantalBeurten}: Geef een gok in tussen 1 en 10.");
                        gok = Convert.ToInt32(Console.ReadLine());
                        raadspel.Gok(gok);
                        if (raadspel.gewonnen == true)
                            einde = true;
                        else if (raadspel.einde == true)
                            einde = true;
                        raadspel.Einde();
                    }
                    catch
                    {
                        Console.WriteLine("Geen juiste invoer");
                    }

                }
                if (raadspel.gewonnen == true)
                    Console.WriteLine("Proficiat je hebt het juiste getal geraden.");
                else
                    Console.WriteLine("Spijtig je hebt je hebt het juiste getal niet kunnen raden.");
                Console.WriteLine("Als je wil stoppen voer S in.");
                String jaOfNee = Console.ReadLine().ToUpper();
                if (jaOfNee == "S")
                    stopen = true;
            }
        }

    }
}
