﻿//MAJ Remplir vaisseau
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S3ProjetFinalEddyFranck
{
    class CVaisseau
    {
        protected int capacite;
        int[] tabQteMateriaux = new int[5]; 

        public CVaisseau() {

        }

        public int Capacite
        {
            get { return capacite; }

            set { capacite = value; }
        }
        


        // Permet de remplir aléatoirement le vaisseau lors de sa création
        public void remplirVaisseaux(int[] tabElement) {
            for (int i = 0; i < 5; i++) {
                this.tabQteMateriaux[i] = tabElement[i];
            }
        }

        //Permet au vaisseau de se deplacer de file en file (déplacement interne et externe)
        private void deplacement() {

        }
    }
}
