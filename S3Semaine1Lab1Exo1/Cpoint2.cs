using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S3Semaine1Lab1Exo1
{
    class Cpoint2
    {
        private double x;
        private double y;


        public double X
        {
            get
            {
                return x;
            }
        }
        public double Y
        {
            get
            {
                return y;
            }
        }


        public Cpoint2()
        {
        }


        public Cpoint2(double X, double Y)
        {
            x = X;
            y = Y;
        }

        public void deplace()
        {
            x = x + 2;
            y = y + 2;
        }

        /*On aurait pu nommer et utiliser les accesseurs directements abcisse et ordonnee  ??? */
        public double abscisse() {
            return x;
        }
        public double ordonnee()
        {
            return y;
        }
    }
}
