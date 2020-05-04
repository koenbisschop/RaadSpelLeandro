using System;

namespace Raadspelletje
{
    public class Raadspel
    {
        private static Random random = new Random();
        public int AantalBeurten { get; set; }
        public Boolean win = false;
        public Boolean lose = false;
        public int teRaden { get; private set; }
        public void Worp()
        {
            teRaden = random.Next(1, 11);
        }
        public void Gok(int gok)
        {
            if (gok == teRaden)
                win = true;
            else win = false;
        }
        public void Einde()
        {
            AantalBeurten += 1;
            if (AantalBeurten == 3)
                lose = true;
            else lose = false;
        }
    }
}
