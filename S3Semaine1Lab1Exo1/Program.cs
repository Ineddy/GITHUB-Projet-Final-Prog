using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S3Semaine1Lab1Exo1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Exercice 1*/
            Cpoints1 monPoint = new Cpoints1(4,8);
            monPoint.affiche();
            monPoint.deplace();
            monPoint.affiche();
            Console.ReadLine();


            /*Exercice 2*/
            /* Cette partie du main gère l'affichage afin de répondre à la demande de l'exercice 2*/

            Cpoint2 monPoint2 = new Cpoint2(7, 12);
            Console.WriteLine(monPoint2.abscisse());
            Console.WriteLine(monPoint2.ordonnee());

            monPoint2.deplace();
            Console.WriteLine(monPoint2.abscisse());
            Console.WriteLine(monPoint2.ordonnee());
            Console.ReadLine();

            /*Exercice 3*/

            Cpoint3 monPoint3 = new Cpoint3(4, 8);
            monPoint3.affiche();
            monPoint3.deplace();
            Cpoint3 monPoint4 = new Cpoint3(4, 8);
            monPoint4.affiche();
            Console.ReadLine();

        }
    }
}
