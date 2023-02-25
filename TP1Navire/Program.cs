using System;

namespace TP1Navire
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
                //TesterInstanciations();
                Navire depardieux = new Navire("IMO1564879", "SS Depardieux");
                Navire astier = new Navire("IMO1564880", "SS Astier");
                Navire chabat = new Navire("IMO1564881", "SS Chabat");

                Port laSalle = new Port("Port LaSalle");
                laSalle.EnregistrerArrive(astier);
                laSalle.EnregistrerArrive(depardieux);
                laSalle.EnregistrerArrive(chabat);

                Console.ReadKey();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void TesterInstanciations()
        {
            //Declaration de l'objet unNavire de la classe Navire
            Navire unNavire;

            //Instantiation de l'objet
            unNavire = new Navire("IMO9427639", "Copper Spirit", "Hydrocarbures", 156827);
            Affiche(unNavire);

            //Declaration et instantiation de d'un autre objet de la classe Navire
            Navire unAutreNavire = new Navire("IMO9839272", "MSC Isabella", "Porte-conteneurs", 197500);
            Affiche(unAutreNavire);

            //??
            unAutreNavire = new Navire("IMO8715871", "MSC PILAR");
            Affiche(unAutreNavire);

            Console.WriteLine("Fin de la Methode");
        }

        public static void Affiche(Navire navire)
        {
            Console.WriteLine("Identification : " + navire.Imo);
            Console.WriteLine("Nom : " + navire.Nom);
            Console.WriteLine("Type de frêt : " + navire.LibelleFret);
            Console.WriteLine("Quantité de frêt : " + navire.QteFretMaxi);
            Console.WriteLine("------------------------------");
        }
    }
}
