//mise a jour le 28/11/2016

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S3ProjetFinalEddyFranck
{
    class Program
    {
        static void Main(string[] args)
        {
            CGestion maGestion = new CGestion();


            // Eddy - Test des méthodes CGestion > qteElement() et CVaisseau > remplirVaisseaux() 
            CVaisseau vaisseauTest = new CVaisseau();
            CVaisseauCargo vaisseauCargoTest = new CVaisseauCargo();
            CVaisseauLeger vaisseauLegerTest = new CVaisseauLeger();

            vaisseauTest.remplirVaisseaux(maGestion.qteElement(367));
            vaisseauLegerTest.remplirVaisseaux(maGestion.qteElement(vaisseauLegerTest.Capacite));
            vaisseauCargoTest.remplirVaisseaux(maGestion.qteElement(vaisseauCargoTest.Capacite));
            Console.WriteLine("Place un point d'arret ici si tu veux vérifier les chargement aléatoires de tes vaisseaux");
            Console.ReadLine();
        }
    }
}
