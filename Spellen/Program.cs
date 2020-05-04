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
            Boolean stoppen = false;
            while (!stoppen)
            {
                Boolean einde = false;
                Console.WriteLine("Druk op Enter om te beginen.");
                Console.ReadLine();
                raadspel.Worp();
                raadspel.AantalBeurten = 1;
                while (einde == false)
                {
                    int gokken;
                    try
                    {
                        Console.WriteLine($"Kans {raadspel.AantalBeurten}: Geef een gok in tussen 1 en 10.");
                        gokken = Convert.ToInt32(Console.ReadLine());
                        raadspel.Gok(gokken);
                        if (raadspel.win == true)

                            einde = true;
                        else if (raadspel.lose == true)
                            einde = true;
                        raadspel.Einde();
                    }
                    catch
                    {
                        Console.WriteLine("Deze invoer is niet correct");
                    }

                }
                if (raadspel.win == true)
                {
                    Console.WriteLine("Je hebt het kunnen raden!");

                }
                else
                {
                    Console.WriteLine("Je hebt het niet kunnen raden.");
                    Console.WriteLine("Schrijf S als je wil stoppen en druk enter");
                    String JaNee = Console.ReadLine().ToUpper();
                    if (JaNee == "S")
                        stoppen = true;
                }
            }
        }

    }
}
