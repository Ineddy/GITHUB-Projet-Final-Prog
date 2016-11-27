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
        //CVaisseauLeger vaisseau2 = new CVaisseauLeger();
        CCentreTri ct1 = new CCentreTri();
        CCentreTri ct2 = new CCentreTri();
        Random R = new Random();

        public CGestion() {

        }

        public int[] qteElement(int capacite)
        {
            int[] tabQteMateriaux = new int[5];

            for (int i=0;i<=4;i++)
            {


            }

            return null;
        }

        public void testRemplirVaisseau() {
            int[] tabElement = new int[5];
            tabElement[0]=100;
            vaisseau1.remplirVaisseaux(tabElement);
            //Afficher le contenu des piles des tableaux
        }
    }
}
