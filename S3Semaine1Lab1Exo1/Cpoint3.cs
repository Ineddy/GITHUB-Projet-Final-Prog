using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S3Semaine1Lab1Exo1
{
    class Cpoint3
    {
        private double x;
        private double y;
        static int cpt = 0;
        public Cpoint3()
        {
            cpt = cpt + 1;
        }


        public Cpoint3(double X, double Y)
        {
            x = X;
            y = Y;
            cpt = cpt + 1;

        }

        public void deplace()
        {
            x = x + 2;
            y = y + 2;
        }
        public void affiche()
        {
            Console.WriteLine("Les coordonnées du points sont : x = " + x + " et y = " + y);
            Console.WriteLine("la fonction Cpoint3 à été appelé " + cpt + " fois. ");
        }
    }
}
