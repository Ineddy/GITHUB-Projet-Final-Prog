using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S3ProjetFinalEddyFranck
{
    class CCentreTri
    {
        Stack<CPapier> pilePapier = new Stack<CPapier>();
        Stack<CPlastique> pilePlastique = new Stack<CPlastique>();
        Stack<CVerre> pileVerre = new Stack<CVerre>();
        Stack<CFerraille> pileFerraille = new Stack<CFerraille>();
        Stack<CTerre> pileTerre = new Stack<CTerre>();

        protected int[] tabQteMateriauxMax = new int[5];
        //Standard utilisé
        // 0 -> Papier
        // 1 -> Verre
        // 2 -> Plastique
        // 3 -> Ferraille
        // 4 -> Terre contaminée

        Queue<CVaisseau> FileDepart = new Queue<CVaisseau>();
        Queue<CVaisseau> FileArrivee = new Queue<CVaisseau>();


        public CCentreTri() {
           
        }
        //Gère le tri des matières : appelle les méthodes charger et decharger vaisseai
        public void trier() {
        }

        public void chargerVaisseau() {
        }

        public void dechargerVaisseau()
        {
        }

        //Cette méthode va récupérer la quantité de déchets par pile par CT
        public void dechetParPile()
        {
        }





    }
}
