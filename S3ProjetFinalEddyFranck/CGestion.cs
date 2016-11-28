using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S3ProjetFinalEddyFranck
{
    class CGestion
    {
        CVaisseauCargo vaisseau1 = new CVaisseauCargo();
        Random random = new Random();
        public CGestion()
        {

        }

        public int[] qteElement(int capacite)
        {
            int[] tabQteMateriaux = new int[5];

            tabQteMateriaux[0] = random.Next(1, capacite - 3);
            tabQteMateriaux[1] = random.Next(1, capacite - tabQteMateriaux[0] - 2);
            tabQteMateriaux[2] = random.Next(1, capacite - (tabQteMateriaux[0] + tabQteMateriaux[1]) - 1);
            tabQteMateriaux[3] = random.Next(1, capacite - (tabQteMateriaux[0] + tabQteMateriaux[1] + tabQteMateriaux[2]));
            tabQteMateriaux[4] = capacite - (tabQteMateriaux[0] + tabQteMateriaux[1] + tabQteMateriaux[2] + tabQteMateriaux[3]);

            return tabQteMateriaux;
        }
    }
}
