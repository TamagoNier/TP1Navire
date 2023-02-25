using System;

namespace TP1Navire
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
                //TesterInstanciations();
                //TesteEnregistArrive();
                //TesteEnregistDepart();
                TesterRecupPosit();

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

        public static void TesteEnregistArrive()
        {
            Navire depardieux = new Navire("IMO1564879", "SS Depardieux");
            Navire astier = new Navire("IMO1564880", "SS Astier");
            Navire chabat = new Navire("IMO1564881", "SS Chabat");
            Navire darmon = new Navire("IMO1564882", "SS Darmon");

            Navire funes = new Navire("IMO1564881", "SS Funès");
            Navire dujardin = new Navire("IMO1564882", "SS Dujardin");

            Port laSalle = new Port("Port LaSalle");
            laSalle.EnregistrerArrive(astier);
            laSalle.EnregistrerArrive(depardieux);
            laSalle.EnregistrerArrive(chabat);
            laSalle.EnregistrerArrive(darmon);
            laSalle.EnregistrerArrive(funes);
            laSalle.EnregistrerArrive(dujardin);

            Console.WriteLine("Tous les navires ont été enregistrés");
        }

        public static void TesteEnregistDepart()
        {
            Port port = new Port("Toulon");
            Navire depardieux = new Navire("IMO1564879", "SS Depardieux");
            Navire astier = new Navire("IMO1564880", "SS Astier");
            Navire chabat = new Navire("IMO1564881", "SS Chabat");
            Navire darmon = new Navire("IMO1564882", "SS Darmon");

            port.EnregistrerArrive(astier);
            port.EnregistrerArrive(depardieux);
            port.EnregistrerArrive(chabat);
            port.EnregistrerArrive(darmon);

            port.EnregistrerDepart("IMO1564880");
            Console.WriteLine("Depart de IMO1564880 enregistré");
            port.EnregistrerDepart("IMO1564883");
            Console.WriteLine("Depart de IMO1564883 enregistré");

            Console.WriteLine("Fin du Programme");
        }
        
        public static void TesterRecupPosit()
        {
            (new Port("Toulon")).TesteRecupPositV2();
        }
    }
}
