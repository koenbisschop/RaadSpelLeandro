using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raadspelletje
{
    public class Raadspel
    {
        private static Random rnd = new Random();
        public int AantalBeurten { get; set; }
        public Boolean gewonnen = false;
        public Boolean einde = false;
        public int teRaden { get; private set; }
        public void Worp()
        {
            teRaden = rnd.Next(1, 11);
        }
        public void Gok(int gok)
        {
            if (gok == teRaden)
                gewonnen = true;
            else gewonnen = false;
        }
        public void Einde()
        {
            AantalBeurten++;
            if (AantalBeurten == 3)
                einde = true;
            else einde = false;
        }
    }
}
