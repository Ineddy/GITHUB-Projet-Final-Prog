using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S3Semaine1Lab1Exo1
{
    class Cpoints1
    {

        private double x;
        private double y;
        public Cpoints1() {
        }


        public Cpoints1(double X, double Y)
        {
            x = X;
            y = Y;
        }

        public void deplace() {
            x = x + 2;
            y = y + 2;
        }
        public void affiche() {
            Console.WriteLine("Les coordonnées du points sont : x = " + x + " et y = " + y );
        }

    }
}
